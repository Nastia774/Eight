using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._2
{
    class Program
    {
        static void Credit(ref int cred, int sum)
        {
            cred -= sum;
            if (cred == 0)
            {
                Console.WriteLine("Долг погашен");
            }
            else
            {
                Console.WriteLine($"Ваш долг составляет {cred}");
            }
        }
        static void Main(string[] args)
        {
            int cred = 700;
            int sum;
            for (int i = 0; i < 7; i++)
            {
                if (cred >= 0)
                {
                    Console.Write($"Введите сумму платежа {i + 1} взнос : ");
                    sum = int.Parse(Console.ReadLine());
                    if (sum > cred)
                    {
                        Console.WriteLine($"Сумма на вашем счету {sum - cred}, вы погасили долг.");
                        cred -= sum;
                    }
                    else
                    {
                        Credit(ref cred, sum);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
