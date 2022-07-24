using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Get_V_S(double a, out double s, out double v)
        {
            s = Math.Pow(a, 2) * 6;
            v = Math.Pow(a, 3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №2.Создать метод для вычисления объема и площади поверхности куба по длине его ребра. \n\nУ вас 10 попыток, удачи!");
            int o = 1;
            while (o < 11)
            {
                Console.WriteLine("\n\nПопытка №{0} из 10!", o);

                #region решение
                Console.WriteLine("Введите длину ребра куба");
                double a = Convert.ToDouble(Console.ReadLine());
                a = Math.Abs(a);
                double s;
                double v;
                Get_V_S(a, out s, out v);
                Console.WriteLine("{0:.0} {1:.0}", s, v);
                #endregion

                o++;
            }
        }
    }
}
