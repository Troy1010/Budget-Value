using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Value
{

    public class DesignerBaseValues_SpendingsHistoryGrid : Spend
    {

        #region Quasi-Singleton
        //public static DesignerBaseValues_SpendingsHistoryGrid Instance { get { return new DesignerBaseValues_SpendingsHistoryGrid(); } }
        public static DesignerBaseValues_SpendingsHistoryGrid Instance => new DesignerBaseValues_SpendingsHistoryGrid();
        #endregion

        #region Constructor
        public DesignerBaseValues_SpendingsHistoryGrid()
        {
            this.sTitle = "Cool Title";
            this.sAdditionalInfo = "Yeah I'm a description";
            this.vTimestamp = DateTime.Now;
            this.dAmount = 42.24m;
        }
        #endregion
    }
}
