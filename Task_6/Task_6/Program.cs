using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут ?");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Сколько вам лет ?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Чем вы занимаетесь в свободное время ?");
            string hobby = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Где работаете ? ");
            string work = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ваш любимый писатель ? ");
            string writer = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"Вас зовут {name} , вам {age} лет(год) , любимый писатель {writer} ,  хобби {hobby} и работаете  {work}");
            Console.ReadLine();
        }
    }
}
