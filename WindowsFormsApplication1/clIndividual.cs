using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPartitionTest
{
    class clIndividual
    {

        #region "Private Memory"

            private int intLColumns;
            private bool booLValid;
            private List<clTask> lstLTasks;
            //private clFitLoadBalance clsLFitLoadBalance;
            private double dblLFitCPUBalance;

        #endregion

        #region "Properties"

            public int Columns
            {
                get { return intLColumns;  }
                //set { intLColumns = value; }
            }

            //public clFitLoadBalance FitLoadBalance
            //{
            //    get { return clsLFitLoadBalance; }
            //}

            public List<clTask> Tasks
            {
                get { return lstLTasks; }
            }

            public bool Valid
            {
                get { return booLValid; }
            }
            
            public double FitnessCPUBalance
            {
                get { return dblLFitCPUBalance; }
            }


        #endregion

        #region "Constructors"

            public clIndividual()
            {
                this.intLColumns = 0;
                //this.clsLFitLoadBalance  = new clFitLoadBalance();
                this.lstLTasks = new List<clTask>();
                this.booLValid = true;
                this.dblLFitCPUBalance = 0.0;
            }

        #endregion

        #region "Public Methods"

            public void Add(clTask NewTask)
            {
                try
                {

                    this.lstLTasks.Add(NewTask);
                    this.intLColumns++;


                }
                catch(Exception Error)
                {
                    throw new Exception("Error adding new task.", Error);
                }
            }

            public double FitnessLoadBalanceCalculation(int AmountOfProcessors)
            {
                //
                // uses mean square error to cacluate the fitness value.
                //
                double dblSum;
                List<double> dblProcs;

                try
                {

                    dblProcs = new List<double>();

                    // initialize the processors list
                    for(int i=0; i < AmountOfProcessors; i++)
                    {
                        dblProcs.Add(0.0);
                    }

                    // now calculate the total CPU load on each processor
                    for(int j=0; j < this.Columns; j++)
                    {
                        int idx = this.Tasks[j].ProcessorID;
                        dblProcs[idx] += this.Tasks[j].CPULoad;
                    }

                    // calculate the MSE
                    dblSum = 0.0;
                    for(int i =0; i < AmountOfProcessors; i++)
                    {
                        dblSum += dblProcs[i] * dblProcs[i];
                        if( dblProcs[i] > 1.0 || dblProcs[i] < 0.0)
                        {
                            // this processor has an illegal allocation!
                            // thus, flag this individual as invalid.
                            this.booLValid = false;
                        }
                    }
                    dblSum = Math.Sqrt(dblSum / AmountOfProcessors);
                    
                    this.dblLFitCPUBalance = dblSum; // update the class property

                    return dblSum;
                }
                catch (Exception Error)
                {
                    throw Error;
                }

                
            }

        #endregion
    }
}
