using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logics
{
    public class Validation
    {
        public static void checkIfEmpty(string input)
        {
            if (input == string.Empty)
            {
                throw new ValidationException("Vänligen fyll i alla fält");
            }
        }


        public static void checkIfNull(string input)
        {
            if (input == null)
            {
                throw new ValidationException("Något av fälten saknar värde");
            }
        }
        public static void checkIfEmpty(int value)
        {
            if (value < 1)
            {
                throw new ValidationException("Du måste sätta ett intervall större än 0");
            }
        }

        public static void checkIfNull(XDocument input)
        {
            if (input == null)
            {
                throw new ValidationException("Ops, det verkar som dokumentet du försöker ladda är tomt!");
            }

        }

    }
}
