using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPartitionTest
{
    class clTask
    {

        #region "Private Memory"

            private int intLID;
            private double dblLCPULoad;
            private bool booLActive;
            private int intLProcessorID;

        #endregion

            #region "Properties"

                public int ID
                {
                    get { return intLID;  }
                    set { intLID = value; }
                }

                public double CPULoad
                {
                    get { return dblLCPULoad;  }
                    set { dblLCPULoad = value; }
                }

                public bool Active
                {
                    get { return booLActive;  }
                    set { booLActive = value; }
                }

                public int ProcessorID
                {
                    get { return intLProcessorID;  }
                    set { intLProcessorID = value; }
                }

            #endregion

            #region "Constructors"

                public clTask()
                {
                    this.ID = 0;
                    this.Active = true;
                    this.CPULoad = 0.0;
                    this.ProcessorID = -1;
                }

                public clTask( int ID )
                {
                    this.ID = ID;
                    this.Active = true;
                    this.CPULoad = 0.0;
                    this.ProcessorID = -1;
                }

                public clTask(int ID, double CPULoad)
                {
                    this.ID = ID;
                    this.Active = true;
                    this.CPULoad = CPULoad;
                    this.ProcessorID = -1;
                }

                public clTask(int ID, double CPULoad, bool Active)
                {
                    this.ID = ID;
                    this.Active = Active;
                    this.CPULoad = CPULoad;
                    this.ProcessorID = -1;
                }

                public clTask(int ID, double CPULoad, bool Active, int ProcessorID)
                {
                    this.ID = ID;
                    this.Active = Active;
                    this.CPULoad = CPULoad;
                    this.ProcessorID = ProcessorID;
                }

        #endregion
    }
}
