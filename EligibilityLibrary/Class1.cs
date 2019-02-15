using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligibilityLibrary
{
    public class Class1
    {
        public static Boolean eligible(Boolean naturalBorn, int age, int yearsResiding, Boolean rebel)
        {
            if (naturalBorn == false||yearsResiding<14||age<35)
            {
                return false;
            }
            else {
                if (rebel)
                {
                    return false;
                }

                else
                {
                    return true;
                }
         
            }
       

        }
    }
}
