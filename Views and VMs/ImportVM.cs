using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Value
{
    public class ImportVM
    {
        private static ImportVM instance;
        public static ImportVM Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new ImportVM();
                }
                return instance;
            }
        }
    }
}
