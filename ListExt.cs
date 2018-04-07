using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Value
{
    public static class ListExt
    {
        public static List<Spend> CombineSpendLists(this List<Spend> cSpends1, List<Spend> cSpends2)
        {
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
            return cSpends1.Concat(cSpends2).ToList();
        }
    }
}
