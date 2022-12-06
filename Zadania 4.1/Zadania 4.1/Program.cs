using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_4._1
{
    internal class Program
    {
        static int F(int n, int i = 0)
        {
            if (n-- == 0)
                return i;
            return F(n, 1 + i + n);
        }
        static void Main(string[] args)
        {
            int m;
            int k;
            while (true)
            {
                try
                {
                    Console.WriteLine("m=");
                    m = int.Parse(Console.ReadLine());
                    if (m == 0)
                    {
                        Console.WriteLine("0 - не натуральное число");
                        continue;
                    }
                    else if (m < 0)
                    {
                        Console.WriteLine("Число должно быть положительным");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!!!");
                }
            }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("k=");
                        k = int.Parse(Console.ReadLine());
                        if (k == 0)
                        {
                            Console.WriteLine("0 - не натуральное число");
                            continue;
                        }
                        else if (k < 0)
                        {
                            Console.WriteLine("Число должно быть положительным");
                            continue;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Некорректный ввод!!!");
                    }
                }
                int sum = F(m) + F(2 * k);
                Console.WriteLine(sum);
            }
        }
    }

