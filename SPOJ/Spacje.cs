using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Spacje
    {
        public void spacje()
        {
            var tekst = Console.ReadLine();
            var model = tekst.Split(' ').ToArray();
            for (int i = 0; i < model.Length; i++)
            {
                if (model[i] == ",")
                {
                    Console.Write(model[i]);
                    Console.WriteLine();continue;
                }
                Console.Write(model[i]);
            }
            

        }
    }
}
