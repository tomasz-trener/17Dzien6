using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03TypObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = 1; //na te jedynke patrze z perspektywy obiektu
            object b = (object)"ala ma kota";
            object c = new StringBuilder(); // to tez jest rzutowanie (niejawne)

            int d = 1; // na te jedynke patrze z perspektywy liczby 

            StringBuilder e = new StringBuilder();

            StringBuilder f = (StringBuilder)c; // rzutowanie (jawne)

            StringBuilder g = c as StringBuilder;

            // rzutowanie to nie konwersja 

            int h = 1;
            string i = Convert.ToString(h);

           // string j = (string)h;
        }
    }
}
