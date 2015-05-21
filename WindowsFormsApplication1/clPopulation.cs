using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPartitionTest
{
    class clPopulation
    {

        #region "Private Memory"

            private int intLSize;
            private int intLWidth;
            private List<clIndividual> lstLIndividuals;
            private List<clTask> lstFTasks;

        #endregion

        #region "Properties"

            public int Size
            {
                get { return intLSize; }
            }

            public int Width
            {
                get { return intLWidth; }
            }

            public List<clIndividual> Individuals
            {
                get { return lstLIndividuals; }
            }

            public List<clTask> Tasks
            {
                get { return lstFTasks;  }
                internal set { lstFTasks = value; }
            }


        #endregion

        #region "Constructors"

            public clPopulation()
            {
                this.intLSize = 0;
                this.intLWidth = 0;
                lstLIndividuals = new List<clIndividual>();
            }

        #endregion

        #region "Public Methods"

            public void Add( clIndividual NewIndividual )
            {
                try
                {
                    
                    this.lstLIndividuals.Add(NewIndividual);
                    this.intLSize++;
                    this.intLWidth = NewIndividual.Columns;

                }
                catch( Exception Error)
                {
                    throw new Exception("Error adding new Individual.", Error);
                }
            }

            public List<clTask> GenerateRandonTasks(int NumberOfTasks, int NumberOfProcessors)
            {

                List<clTask> Tasks;
                Random Generator;
                double dblLCPULoad;

                try
                {

                    Generator = new Random();
                    
                    // generate tasks
                    Tasks = new List<clTask>();
                    for (int i = 0; i < NumberOfTasks; i++)
                    {
                        dblLCPULoad = Generator.NextDouble() / 10.0; // I want small values here!
                        Tasks.Add(new clTask(i, dblLCPULoad, true));
                    }

                    this.Tasks = Tasks;
                    return Tasks;

                }
                catch( Exception Error )
                {
                    throw Error;
                }

            }

        #endregion

        #region "Private Methods"


        #endregion
    }
}
