using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class LiczbyPierwsze
    {
        public void liczbyPierwsze()
        {
            List<double> liczby = new List<double>();
            var iloscLiczb = int.Parse(Console.ReadLine());
            for (int i = 0; i < iloscLiczb; i++)
            {
                var liczb = Int64.Parse(Console.ReadLine());
                liczby.Add(liczb);
            }
            foreach (var model in liczby)
            {
                if (model <= 2 || model%2 ==0){Console.WriteLine("NIE");continue;}//3
                if (model ==3) { Console.WriteLine("TAK");continue;}
                var sqrt = Math.Sqrt(model);
                bool x = false;
                
                for (int i = 2; i <= sqrt; i++)
                {
                    if (i == Math.Floor(sqrt))
                    {
                        x = true;
                    }
                    if (model%i == 0) {Console.WriteLine("NIE");break; }//nie jest pierwsza
                    if(x)Console.WriteLine("TAK");
                    
                }

            }
            Console.ReadKey();
        }
    }
}
