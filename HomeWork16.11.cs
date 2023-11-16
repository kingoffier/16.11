using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            ex7();
        }

        private static void ex7()
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            Console.WriteLine("-----------");
            for (int i = 0; i <= 1; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int b = 2; b < mass.Length; b++)
            {
                if (b % 2 == 0)
                {
                    mass[b] += mass[0];
                }
                if (b % 2 == 1)
                {
                    mass[b] += mass[1];
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Console.ReadKey();
        }

        private static void ex6()
        {
            int c = 0;
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i +=1)
            {
                c += 2;
                mass[i] = c;
                Console.WriteLine(mass[i]);
            }
        }

        private static void ex5()
        {
            double a = 0;
            double b = 0;
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mass = new double[n];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < mass.Length; i++)
            {
                a += mass[i];
            }
            b = a / mass.Length;
            Console.WriteLine("Среднее арифметическое этого массива: " + b);
            Console.WriteLine("--------------");
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 15)
                {
                    mass[i] = Convert.ToInt32(b);
                }
                Console.WriteLine(mass[i]);
            }
        }

        private static void ex4()
        {
            int a = 0;
            int b = 1;
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 1)
                {
                    if (mass[i] % 3 == 0)
                    {
                        a += mass[i];
                        b *= mass[i];
                    }
                }
            
            }
            Console.WriteLine("Сумма этих элементов: " + a);
            Console.WriteLine("Произведение этих элементов: " + b);
        }

        private static void ex3()
        {
            int c = 0;
            int[] mass = new int[] { -1, -2, 3, 8, -5, 8 };
            Array.Reverse(mass);
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    c = +1;
                    Array.Reverse(mass);
                    Console.WriteLine(mass[i]);
                }
            }
        }

        private static void ex2()
        {
            int k = 2;
            int[] mass = new int[] { 3, 2, 5, 6, 7, 8 };
            for (int i = 0; i < mass.Length; i++)
            {

                if (mass[i] % k == 0)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine("Номер четного элемента стоящий на нечетной позиции " + i);
                    }

                }

            }
        }

        private static void ex1()
        {
            Console.WriteLine("Введите значение числа A");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[] { 3, 5, 7 };
            int k = 0;
            foreach (var item in mass)
            {
                if (item > 0 && item < a)
                {
                    k += 1;
                }
            }
            Console.WriteLine(k);
        }
    }
}
