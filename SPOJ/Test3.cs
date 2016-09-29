using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Test3

    {
         public void test3()
         {
            int help42 = 0;
             int numbers = 0;
             int test = 0;
             for (;;)
             {
                var number = Int32.Parse(Console.ReadLine());
                 if (test == 1)
                 {
                     Console.WriteLine(number);
                     if (number != 42)
                     {
                         numbers++;
                     }
                     if (number == 42 && numbers > 0)
                     {
                         help42++;
                     }
                     if (help42 == 3)
                     {
                         test++;
                     }
                 }
             }

        }
        
    }
}
