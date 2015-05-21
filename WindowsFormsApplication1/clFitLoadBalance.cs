using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPartitionTest
{
    class clFitLoadBalance
    {
        #region "Private Memory"

            private double dblLFitValue;
            private bool booLIsValid;

        #endregion

        #region "Properties"

            public double FitValue
            {
                get { return dblLFitValue;  }
                set { dblLFitValue = value; }
            }

            public bool IsValid
            {
                get { return booLIsValid;  }
                set { booLIsValid = value; }
            }

        #endregion
    }
}
