using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoTestFoundation.Util
{
    class RegUtil
    {
        public static bool IsNumber(object obj)
        {
            if (obj is string)
            {
                string objStr = (string)obj;
                Regex reg = new Regex("^\\d+$");
                return reg.IsMatch(objStr);
            }
            return false;
        }

    }
}
