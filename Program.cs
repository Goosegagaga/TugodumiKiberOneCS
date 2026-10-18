using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationl
{
    public class Human
    {
        public int Height = 170;
        public int Age = 25;
        public string Name = "Иван";

    }

    public class Child: Human
    {
        new public int Height = 100;
        new public int Age = 5;
        public void SetHeight(int x)
        {
            if((x > 100) & (x < 170))
            {
                Height = x;
            }
        }
        public void SetAge(int x)
        {
            if ((x > 0) & (x < 16))
            {
                Age = x;
            }
        }

        public void Print()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Рост: " + Height);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child Ivan = new Child();
            Ivan.Print();
            Ivan.SetHeight(140);
            Ivan.SetAge(40);
            Ivan.Print();
            Ivan.SetHeight(140);
            Ivan.SetAge(3);
            Ivan.Print();
        }
    }
}