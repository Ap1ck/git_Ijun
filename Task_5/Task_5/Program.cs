using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во людей в очереди: ");
            int people = Convert.ToInt32(Console.ReadLine());
            int fixedReceptionTime = 10;
            int time = fixedReceptionTime * people;
            int hour = time / 60;
            int minutes = time % 60;
            Console.WriteLine($"Ожидание в очереди состовляет: {hour} часа и {minutes} минут");
            Console.ReadLine();


        }
    }
}
