using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Budget_Value
{
    //[Serializable] //What is this for again..?
    public class Spend
    {
        // Importable Data
        public DateTime vTimestamp { get; set; }
        public string sTitle { get; set; }
        public decimal dAmount { get; set; }
        public string sAdditionalInfo { get; set; }
        // User Assigned Data
        public string sCatagory { get; set; }
        //
        public string sDescription
        {
            get
            {
                //?
                string sReturning = "" + sAdditionalInfo;
                Match oMatch;
                if ((oMatch = Regex.Match(sReturning, "TERMINAL ", RegexOptions.IgnoreCase)).Success)
                {
                    sReturning = sReturning.Substring(sReturning.IndexOf(" ", oMatch.Index + 9));//oMatch.Index + 9 + 8);
                }
                if ((oMatch = Regex.Match(sReturning, "XXXXXX[ ]?XXXXXX[0-9]{4}", RegexOptions.IgnoreCase)).Success)
                {
                    sReturning = sReturning.Substring(0, oMatch.Index);
                }
                sReturning = Regex.Replace(sReturning, "[ ]{2,}", " ", RegexOptions.IgnoreCase);
                sReturning = sReturning.Trim();
                sReturning = vTimestamp.ToString("MM/dd/yyyy") + "," + dAmount.ToString().PadRight(8) + "," + sReturning;
                return sReturning;
            }
        }
    }
}
