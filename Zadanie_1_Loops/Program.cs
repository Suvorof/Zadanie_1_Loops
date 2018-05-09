using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_Loops
{
    class Program
    {
        static void Main()
        /*{
            int i;
            int sum = 0;

        for(i=0; i<=10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Сумма чисел лежащих в интервале от 0 до 10 включительно, равна " + sum);
            Console.ReadKey();
        }*/

        {
            int i;
            for (i=0; i<=10; i++)
                {
                    if(i % 2 != 0)
                        {
                            Console.WriteLine("Все нечётные числа, лежащие в интервале от 0 до 10 "+ i);
                        }
                }
            Console.ReadKey();
        }
    }
}
