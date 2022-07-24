using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Get_S(double x, double y, double z, out double s)
        {
            double t;
            t = (x + y + z)/2;
            s= Math.Sqrt(t * (t - x) * (t - y) * (t - z));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1\n Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше.\n\nУ вас 10 попыток, удачи!");
            int o = 1;
            while (o < 11)
            {
                Console.WriteLine("\nПопытка №{0} из 10!", o);


                Console.WriteLine("Введите длины первого треугольника (x,y,z):");
                #region  ввод 
                Console.WriteLine("Введите x:");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите z:");
                double z1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите длины второго треугольника (x,y,z):");
                Console.WriteLine("Введите x:");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите z:");
                double z2 = Convert.ToDouble(Console.ReadLine());
                double s1; double s2; double smax=0;
                #endregion 

                Get_S(x1, y1, z1, out s1);
                Get_S(x2, y2, z2, out s2);
                #region сравнение треугольников
                if (s1 > s2)
                {
                    smax = s1;
                    Console.WriteLine("S первого треугольника больше");
                }
                else
                    if(s1<s2)
                    {
                    smax = s2;
                    Console.WriteLine("S второго треугольника больше");
                }
                else
                    if(s1 == s2)
                    {
                    Console.WriteLine("Площади равны");
                }
                #endregion
                Console.WriteLine("\nS большего треугольника = {0}",smax);


                o++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Cпасибо!");
            Console.ReadKey();
        }
    }
}
