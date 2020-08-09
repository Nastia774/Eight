using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._3
{
    class Program
    {
        static int DeliveryOptions (int arg)
        {
            if (arg==0)
            {
                return 1;
            }
            return arg * DeliveryOptions(arg - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество клиентов : ");
            int cust = int.Parse(Console.ReadLine());

            int tr=DeliveryOptions(cust);
            Console.WriteLine($"Количество маршрутов доставки для {cust} клиентов : {tr}");
            Console.ReadKey();
        }
    }
}
