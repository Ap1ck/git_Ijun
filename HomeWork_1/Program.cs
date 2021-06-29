using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturAll = 52;
            int picturSeries = 3;
            int series = picturAll / picturSeries;
            int aboveNorm = picturAll % series;
            Console.WriteLine($"Количество заполненых рядов: {series} , картинок сверх нормы {aboveNorm}");
        }
    }
}
