using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPartitionTest
{
    class clSingleObjectiveDifferentialEvolution
    {

        #region "Public Structures"

            [Flags]
            public enum enmDEFitnessAlgorithm
            {
                TaskPartitioningBenchmark,
                SphereFunctionBenchmark
            }

        #endregion

        #region "Private Memory"

            private enmDEFitnessAlgorithm enmFDEFitnessAlgorithm;
            private double FitUpperBound;
            private double FitLowerBound;

            private clPopulation objFPopulation;
            private int intFPopulationSize;
            private int intFPopulationDimension;

            private List<clTask> lstFTasks;
            private int intFNumberOfTasks;

            private double dblFCromossomeRate;
            private double dblFMutationFactor;
            
            private int intFGenerations;

            private string strFOutputFolder;

            private int intFNumberOfProcessors;
            
            private double dblFCPUMaxLoad;

            private Random ranFGenerator;

        #endregion

            #region "Constructors"

                public clSingleObjectiveDifferentialEvolution()
                {
                    // starts the randomizer.
                    ranFGenerator = new Random(DateTime.Now.Millisecond);
                }

            #endregion

            #region "Private Properties"

            private Random Generator
            {
                get { return ranFGenerator; }
            }

        #endregion

        #region "Properties"

            public enmDEFitnessAlgorithm DEFitnessAlgorithm
            {
                get { return enmFDEFitnessAlgorithm;  }
                set { enmFDEFitnessAlgorithm = value; }
            }

            public clPopulation Population
            {
                get { return objFPopulation;  }
                set { objFPopulation = value; }
            }

            public int PopulationSize
            {
                get { return intFPopulationSize;  }
                set { intFPopulationSize = value; }
            }

            public int PopulationDimension
            {
                get { return intFPopulationDimension;  }
                set { intFPopulationDimension = value; }
            }

            public double CromossomeRate
            {
                get { return dblFCromossomeRate;  }
                set { dblFCromossomeRate = value; }
            }

            public double MutationFactor
            {
                get { return dblFMutationFactor;  }
                set { dblFMutationFactor = value; }
            }

            public int Generations
            {
                get { return intFGenerations;  }
                set { intFGenerations = value; }
            }

            public string OutputFolder
            {
                get { return strFOutputFolder;  }
                set { strFOutputFolder = value; }
            }

            public int NumberOfProcessors
            {
                get { return intFNumberOfProcessors;  }
                set { intFNumberOfProcessors = value; }
            }

            public int NumberOfTasks
            {
                get { return intFNumberOfTasks; }
                set { intFNumberOfTasks = value; }
            }

            public double CPUMaxLoad
            {
                get { return dblFCPUMaxLoad;  }
                set { dblFCPUMaxLoad = value; }
            }

            public List<clTask> Tasks
            {
                get { return lstFTasks;  }
                set { lstFTasks = value; }
            }

    #endregion

    #region "Public Methods"

            public bool InitializePopulation(bool CalculateFitness)
            {

                List<clTask> Tasks;
                //double dblLCPULoad;
                clPopulation Population;
                clIndividual Individual;

                try
                {


                    //Random Generator = new Random(DateTime.Now.Millisecond);

                    //// generate tasks
                    //Tasks = new List<clTask>();
                    //for (int i = 0; i < this.NumberOfTasks; i++)
                    //{
                    //    dblLCPULoad = Generator.NextDouble() / 10.0; // I want small values here!
                    //    Tasks.Add(new clTask(i, dblLCPULoad, true));
                    //}

                    // Generate Tasks
                    Population = new clPopulation();

                    Tasks = Population.GenerateRandonTasks(this.NumberOfTasks, this.NumberOfProcessors);
                    this.Tasks = Tasks;
                   

                    // generate Population
                    //Population = new clPopulation();
                    for (int i = 0; i < this.PopulationSize; i++)
                    {
                        //generate a new individual
                        Individual = new clIndividual();

                        // create a new individual based on the existing task list
                        // but randomizing its processor association.
                        for (int k = 0; k < this.PopulationDimension; k++)
                        {

                            // randomize the processor ID for the next task
                            int ProcID = Generator.Next(0, this.NumberOfProcessors);

                            Individual.Add(new clTask(Tasks[k].ID, Tasks[k].CPULoad, Tasks[k].Active, ProcID));

                        }

                        Population.Add(Individual);
                    }

                    // do I have to calculate the Fitness ?
                    if ( CalculateFitness )
                    {
                        for(int i=0; i < this.PopulationSize; i++)
                        {
                            Population.Individuals[i].FitnessLoadBalanceCalculation( this.NumberOfProcessors );
                        }
                    }

                    this.Population = Population;

                    return true;
                }
                catch(Exception Error)
                {
                    throw Error;
                }


            }

            public bool Pick3IndividualIndexes(out int Idx1, out int Idx2, out int Idx3, bool AmongNonDominated)
            {
                /*
                ** Pick up 3 unique random individual indexes from the Population.
                */
                // the routine to pick it up from the non dominated individuals wasnt implemented yet!

                try
                {
                    int[] Idx = { -1, -1, -1 };
                    bool match = false;
                    int i = 0;
                    while (i<3)
                    {
                        int x = this.Generator.Next(this.PopulationSize);

                        for(int k=0; k < 3; k++)
                        {
                            if (Idx[k] == x) match = true;
                        }
                        
                        if(!match)
                        {
                            Idx[i] = x;
                            i++;
                        }
                        match = false;
                    }
                    Idx1 = Idx[0];
                    Idx2 = Idx[1];
                    Idx3 = Idx[2];

                    return true;

                }
                catch (Exception Error)
                {
                    throw Error;
                }
            }

            public bool Pick3IndividualIndexes(out int Idx1, out int Idx2, out int Idx3)
            {
                return Pick3IndividualIndexes(out Idx1, out Idx2, out Idx3, false);
            }

            public bool Mutate(out clIndividual DonorVector)
            {
                /*
                ** Use mutation to generate a new Individual. 
                */

                try
                {

                    double x1, x2, x3;
                    double dblLNewValue;
                    int Idx1, Idx2, Idx3;
                    clIndividual NewIndividual = new clIndividual();

                    // pick up 3 random individuals from Population
                    if (!this.Pick3IndividualIndexes(out Idx1, out Idx2, out Idx3))
                    {
                        throw new Exception("Error on Mutation function!");
                    }


                    for (int j = 0; j < this.PopulationDimension; j++)
                    {
                        //clIndividual Individual1 = this.Population.Individuals.ElementAt(Idx1);
                        //clIndividual Individual2 = this.Population.Individuals.ElementAt(Idx2);
                        //clIndividual Individual3 = this.Population.Individuals.ElementAt(Idx3);

                        //x1 = this.Population.Individuals[Idx1].Tasks[j].CPULoad;
                        //x2 = this.Population.Individuals[Idx2].Tasks[j].CPULoad;
                        //x3 = this.Population.Individuals[Idx3].Tasks[j].CPULoad;

                        x1 = this.Population.Individuals[Idx1].Tasks[j].ProcessorID;
                        x2 = this.Population.Individuals[Idx2].Tasks[j].ProcessorID;
                        x3 = this.Population.Individuals[Idx3].Tasks[j].ProcessorID;

                        dblLNewValue = x1 + this.MutationFactor * (x2 - x3);

                        int intLNewProcessorID = (int)Math.Abs(Math.Floor(dblLNewValue));
                        if (intLNewProcessorID > this.intFNumberOfProcessors - 1) 
                        {
                            // make sure the ID is valid!
                            intLNewProcessorID = this.NumberOfProcessors - 1;
                        }
                        clTask NewTask = new clTask(j, this.Tasks[j].CPULoad, true, intLNewProcessorID);

                        NewIndividual.Add(NewTask);
                    }

                    DonorVector = NewIndividual;

                    return true;
                }
                catch(Exception Error)
                {
                    throw Error;
                }
            }

            public bool Mutate( out clIndividual DonoverVector, double LowerBound, double UpperBound)
            {
                /*
                ** Use mutation to generate a new Individual and make sure its tasks
                ** containg only valid values.
                */

                try
                {
                    bool ValidIndividual = true;
                    int intLMaxAttempts = 1000;
                    int intLCount = 0;
                    clIndividual NewIndividual = new clIndividual();

                    while( ValidIndividual && intLCount < intLMaxAttempts )
                    {
                        // try to generate a new donor vector.
                        if( !Mutate(out NewIndividual) )
                        {
                            throw new Exception("Error performing mutation!");
                        }

                        // Check if those task values are valid.
                        for(int j=0; j < this.PopulationDimension; j++)
                        {
                            if( NewIndividual.Tasks[j].CPULoad < this.FitLowerBound && 
                                NewIndividual.Tasks[j].CPULoad > this.FitUpperBound)
                            {
                                // invalid value detected!
                                ValidIndividual = false;
                            }
                        }
                        intLCount++;
                    }

                    if( !ValidIndividual && intLCount >= intLMaxAttempts)
                    {
                        // error detected: max amount of attempts
                        // was rechead without generating a valid new individual!
                        throw new Exception("Error generating a new donor vector: max amount of attempts reached!");
                    }

                    DonoverVector = NewIndividual;

                    return true;

                }
                catch(Exception Error)
                {
                    throw Error;
                }
            }

            public clIndividual Recombination (/*ref*/ clIndividual DonorVector, /*ref*/ clIndividual PopulationIndividual)
            {
                /*
                ** Executes the recombination using the two Individuals received
                ** and a randomic decision factor. Results in a new individual.
                */
                double dblLDecidionFactor;
                clIndividual NewIndividual;

                try
                {

                    NewIndividual = new clIndividual();

                    for (int j = 0; j < this.intFPopulationDimension; j++ )
                    {
                        
                        dblLDecidionFactor = this.Generator.NextDouble(); // a double between 0.0 and 1.0.

                        if( dblLDecidionFactor < this.CromossomeRate )
                        {
                            //NewIndividual.Tasks.Add( DonorVector.Tasks[j] );
                            NewIndividual.Add( DonorVector.Tasks[j] );
                        }
                        else
                        {
                            //NewIndividual.Tasks.Add( PopulationIndividual.Tasks[j] );
                            NewIndividual.Add(PopulationIndividual.Tasks[j]);
                        }

                    }

                    // update the fitness value for the new individual
                    NewIndividual.FitnessLoadBalanceCalculation(this.intFNumberOfProcessors); 

                    return NewIndividual;

                }
                catch(Exception Error)
                {
                    throw Error;
                }
            }

    #endregion

    }
}
