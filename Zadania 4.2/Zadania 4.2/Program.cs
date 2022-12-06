using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_4._2
{
    internal class Program
    {
         static void F(int n, int b)
        {
            if (n < b)
            {
                var s = n.ToString();
                var result = "";
                for(int i = s.Length-1; i >= 0; i--)
                {
                   result += s[i];
                }
                Console.WriteLine(result);
            }

        }
        static void Main(string[] args)
        {  
            int a;
            int b;

            while (true)
            {
                try
                {
                    Console.WriteLine("A=");
                    a = int.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("0 - не натуральное число");
                        continue;
                    }
                    else if (a < 0)
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
                    Console.WriteLine("B=");
                    b = int.Parse(Console.ReadLine());
                    if (b == 0)
                    {
                        Console.WriteLine("0 - не натуральное число");
                        continue;
                    }
                    else if (b < 0)
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
            if (a>b)
            {
                Console.WriteLine(" A не может быть больше B ");
                Console.WriteLine("A=");
                a=int.Parse(Console.ReadLine());
                Console.WriteLine("B=");
                b=int.Parse(Console.ReadLine());
            }
            for (int i = a; a < b; a++)

            {
               F(a,b);
            }
            
        }
    }
}
