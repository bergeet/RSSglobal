using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class TimeConverter
    {
       

        public static int hourToMS(int input)
        {
            var result = input * 3600000;

            return result;
        }
    }
}
