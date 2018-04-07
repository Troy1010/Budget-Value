using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Budget_Value
{
    public class MainVM : ViewModelTemplate
    {
        public SpendablesVM Spendables { get; } = new SpendablesVM();
        public SpendingsHistoryVM SpendingsHistory { get; }
        public MainView mainView;
        public MainVM(MainView mainView)
        {
            SpendingsHistory = new SpendingsHistoryVM(this);
            this.mainView = mainView;
        }
    }
}