using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Suma
    {
        // Id 968
        public void suma()
        {
            string x;
            int y;
            int? suma = 0;
            while (true)
            {
                x = Console.ReadLine();
                bool result = Int32.TryParse(x, out y);
                if (result)
                {
                    Console.WriteLine(suma = suma + y);
                }
                else
                {
                    break;

                }

            }
        }
    }
}
