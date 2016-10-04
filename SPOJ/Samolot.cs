using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{

    class Samolot
    {
        //ID 1502
        public void samolot()
        {
            var miejsca = Console.ReadLine();
            var ilosc = miejsca.Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine((ilosc[0]*ilosc[1])+(ilosc[2]*ilosc[3]));
        }
      
    }
}
