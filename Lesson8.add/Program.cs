using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.add
{
    class Program
    {
        static void Calculate(int fir, int sec, int ther)
        {
            Console.WriteLine($"{fir} / 5 = {fir /= 5}");
            Console.WriteLine($"{sec} / 5 = {sec /= 5}");
            Console.WriteLine($"{ther} / 5 = {ther /= 5}");
        }
        static void Main(string[] args)
        {/* Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте метод с именем Calculate, который принимает в качестве параметров три целочисленных
значения и возвращает значение каждого аргумента деленного на 5.          */

            Console.Write("Введите первое число : ");
            int fir = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число : ");
            int sec = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число : ");
            int ther = int.Parse(Console.ReadLine());

            Calculate(fir, sec, ther);


            Console.ReadKey();
        }
    }
}
