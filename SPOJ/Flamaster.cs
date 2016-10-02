using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Flamaster
    {
        public void flamaster()
        {
            List<string> word = new List<string>();
            var helpstring = Console.ReadLine();
            //while (!string.IsNullOrEmpty(helpstring))
            //{             
            //    word.Add(helpstring);
            //    helpstring = Console.ReadLine();
            //}
            do
            {

                word.Add(helpstring);
                helpstring = Console.ReadLine();

            } while (!string.IsNullOrEmpty(helpstring));



        }
    }
}
