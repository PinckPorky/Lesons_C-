using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesons_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> levels = new List<decimal>();




            Console.WriteLine("Введите верхнию цену: ");

            int priceUp = Convert.ToInt32(Console.ReadLine());

            // priceUp = Console.ReadLine();



            //  bool result = int.TryParse(a, out b);
            //if (result)
            //  {
            //                Convert.ToInt32(a);
            //  }
            // else {

            //     Console.WriteLine("Ошибка, повторите:  ");
            //  }



            //Console.WriteLine("Ведите нижнию цену: ");

            //int priceDown = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество уровней:  ");

            int Nstep = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите шаг уровня:  ");

            int steplevl = Convert.ToInt32(Console.ReadLine());



            // b - верхняя  цена, c - нижняя цена, d - количество уровней, f - шаг уровня

            for (int i = 0; i < Nstep; i++)
            {
                levels.Add(priceUp);

                priceUp -= steplevl;

            }

            for (int i = 0; i < Nstep; i++) 
            {
                Console.WriteLine(levels[i]);
            }

            Console.ReadLine();

        }
    }
}
 