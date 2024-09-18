using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeployment
{
    internal static class Validation
    {
        static public bool pasValidation(string val)
        {
            if (val.Length >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool dateValidation(string val)
        {
                DateTime parsedDate;
                if (DateTime.TryParse(val, out parsedDate))
                {
                    return true;
                }
                 else
                {
                    return false;
                }
          
        }
    }
}
