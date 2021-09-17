using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");

            Console.WriteLine("Упражнение 2.2");
            int a = int.Parse(Console.ReadLine());
            double a2 = Convert.ToDouble(a);
            int b = int.Parse(Console.ReadLine());
            double b2 = Convert.ToDouble(b);
            if (b2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            else
            { 
                Console.WriteLine(a2 / b2);

            }
            
            Console.WriteLine("Домашнее задание 2.1 ");
            char character = Console.ReadKey().KeyChar;
            char letter = char.ToLower(character);
            char nextcharacter;
            if (letter == 'z')
                nextcharacter = 'a';
            else
                nextcharacter = (char)(((int)letter) + 1);
            Console.WriteLine();
            Console.WriteLine(nextcharacter);
    
 
     
          Console.WriteLine("Домашнее задание 2.2 ");
            Console.WriteLine("Введите коэффициент а");
            var a1=Console.ReadLine();
            double A = Convert.ToDouble(a1);
            Console.WriteLine("Введите коэффициент b");
            var b1=Console.ReadLine();
            double B = Convert.ToDouble(b1);
            Console.WriteLine("Введите коэффициент с");
            var c1=Console.ReadLine();
            double C = Convert.ToDouble(c1);
            double D = B * B - 4 * A * C;
            if (D < 0)
            { Console.WriteLine("Дискриминант меньше нуля. Корней нет"); }
            else
            {
                if (D == 0)

                {
                    double x = (-B / 2 * A);
                    Console.WriteLine("Корень уравнения равен " + x);
                }
                else
                { 
              
                
                    double x1 = ((-B - Math.Sqrt(D)) / (2 * A));
                    double x2 = ((-B + Math.Sqrt(D)) / (2 * A));
                    Console.WriteLine("Первый корень уравнение равен " +x1 );
                    Console.WriteLine("Второй корень уравнение равен " + x2 );
                }
            }

            Console.ReadKey();


                
        }
    }
}
