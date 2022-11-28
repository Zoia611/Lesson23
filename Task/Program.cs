using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = Convert.ToInt32(Console.ReadLine());
                FactAsync(n);
                Console.ReadKey();
            }
            static void Fact(int n)
            {
                decimal f = 1;
                for (int i = 1; i < n + 1; i++)
                {
                    f *= i;
                    Thread.Sleep(10);
                }
                Console.WriteLine(f);
            }
            static async void FactAsync(int n)
            {
            object p = await new Task.Run(() => Fact(n));
            // CS0234 
        }
    }
    }

