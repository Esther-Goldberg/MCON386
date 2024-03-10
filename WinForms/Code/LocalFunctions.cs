using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCON368.WinForms.Code
{
    public class LocalFunctions
    {
        public static bool isNumeric(string theValue)
        {
            float output;
            return float.TryParse(theValue, out output);
        }
    }
}
