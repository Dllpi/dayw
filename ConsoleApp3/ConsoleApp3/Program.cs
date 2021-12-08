using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_of_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Введите число которое будет соответствовать дню недели:");

                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Данное число соответствует понедельнику!");
                        break;
                    case 2:
                        Console.WriteLine("Данное число соответствует вторнику!");
                        break;
                    case 3:
                        Console.WriteLine("Данное число соответствует среде!");
                        break;
                    case 4:
                        Console.WriteLine("Данное число соответствует четвергу!");
                        break;
                    case 5:
                        Console.WriteLine("Данное число соответствует пятнице!");
                        break;
                    case 6:
                        Console.WriteLine("Данное число соответствует субботе!");
                        break;
                    case 7:
                        Console.WriteLine("Данное число соответствует воскресенью.!");
                        break;
                    default:
                        Console.WriteLine("Данное число не соответствует дню недели. Попробуй еще!");
                        break;
                }
            }
        }
    }
}