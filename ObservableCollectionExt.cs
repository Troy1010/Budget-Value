using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Value
{
    public static class ObservableCollectionExt
    {
        public static ObservableCollection<Spend> ConcatListNoDups(this ObservableCollection<Spend> cSpends1, List<Spend> cSpends2)
        {
            // Remove duplicates
            foreach (Spend vSpend2 in cSpends2.ToList())
            {
                foreach (Spend vSpend1 in cSpends1)
                {
                    if (vSpend1.sAdditionalInfo == vSpend2.sAdditionalInfo)
                    {
                        cSpends2.Remove(vSpend2);
                    }
                }
            }
            // Concat
            foreach (Spend vSpend1 in cSpends2)
            {
                cSpends1.Add(vSpend1);
            }
            return cSpends1;
        }
    }
}
