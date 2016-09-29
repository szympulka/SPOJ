using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Pesel
    {
        public void pesel()
        {
            int[] numbers = new[] {1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1};
            List<string> peselRekords = new List<string>();
            string helpString;
            int sum = 0;
            while (true)
            {
                helpString = Console.ReadLine();
                if (!String.IsNullOrEmpty(helpString))
                {
                    peselRekords.Add(helpString);
                }

                else
                {
                    break;
                }
            }
            foreach (var model in peselRekords)
            {
                if (model.Length == 11)
                {
                    
                    for (int i = 0; i < model.Length; i++)
                    {
                        var val = model[i] - '0'; //Int32.Parse(model[i].ToString());
                        sum = sum + (val * numbers[i]);                      
                    }
                    helpString = sum.ToString();
                    int length = helpString.Length;
                    var val2 = helpString[length - 1] - '0';
                    if (val2 == 0)
                    {
                        Console.WriteLine("D");
                    }
                    Console.WriteLine("N");
                    //44051401458
                    sum = 0;
                }
                Console.ReadKey();
            }
        } 
    }
}
