using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество золота: ");
            int money = Convert.ToInt32(Console.ReadLine());
            int cristalPrice = 20;
            int count = money / cristalPrice;
            int remainsMoney = money % cristalPrice;
            Console.WriteLine($"Количество кристаллов: {count},остаток золота {remainsMoney}");
        }
    }
}
