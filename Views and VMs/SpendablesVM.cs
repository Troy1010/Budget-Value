using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Budget_Value
{
    public class SpendablesVM : ViewModelTemplate
    {
        public ICommand RunningTotalIncrementCommand { get; }
        public SpendablesVM()
        {
            this.RunningTotalIncrementCommand = new CommandHandler(IncrementRunningTotal);
        }

        private int _RunningTotal = 23;
        public int RunningTotal
        {
            get
            {
                return _RunningTotal;
            }
            set
            {
                if (_RunningTotal != value)
                {
                    _RunningTotal = value;
                    OnPropertyChanged();
                }
            }
        }

        public void IncrementRunningTotal()
        {
            RunningTotal++;
        }
    }
}
