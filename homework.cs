using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tasks
{
    class Program
    {
        public static object ToFloat { get; private set; }

        static void Main(string[] args)
        {


            /* Console.WriteLine("Задание 1.1");
               double number = double.Parse(Console.ReadLine());
               Console.WriteLine(Math.Round(number, 2));
               Console.ReadKey();

               Console.WriteLine("Задание 1.2");
               Console.WriteLine(Math.Round((Math.E), 1));
               Console.ReadKey();

               Console.WriteLine("\n Задание 1.3");
               Console.WriteLine("\n Вы ввели число");
               var a = Console.ReadLine();
               Console.WriteLine("Вы ввели число " + a);
               Console.ReadKey();


               Console.WriteLine("\n Задание 1.4");
               Console.WriteLine("\n Вы ввели число");
               var b = Console.ReadLine();
               Console.WriteLine(b + " - вот какое число Вы ввели");
               Console.ReadKey();

               Console.WriteLine("\nЗадание 1.5");
               Console.WriteLine("1 13 49");
               Console.ReadKey();


               Console.WriteLine("\nЗадание 1.6");
               Console.WriteLine("7  15  100");
               Console.ReadKey();

               Console.WriteLine("\nЗадание 1.7");
               Random n = new Random();
               int n1 = n.Next();
               int n2 = n.Next();
               int n3 = n.Next();
               string s1 = n1.ToString();
               string s2 = n2.ToString();
               string s3 = n3.ToString();
               string[] massive = new string[] {s1, s2, s3};//массив строк
               foreach (string f in massive)
                Console.Write($"{f}  "); 
               Console.ReadKey();

            Console.WriteLine("\nЗадание 1.8");
            Random rand = new Random();
            int k1 = rand.Next();
            int k2 = rand.Next();
            int k3 = rand.Next();
            int k4 = rand.Next();
            string c1 = k1.ToString();
            string c2 = k2.ToString();
            string c3 = k3.ToString();
            string c4 = k4.ToString();
            string kk = c1 + " " + c2 + " " + c3 + " " + c4;
            string[] massiv = new string[] { c1, c2, c3, c4 };//массив строк
            foreach (string i in massiv)//перебор элементов массива
            Console.Write($"{i} "); 
            Console.ReadKey();
            
            Console.WriteLine("\nЗадание 1.9");
            int w1 = 50;
            int w2 = 10;
            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 1.10");
            int r1 = 5;
            int r2 = 10;
            int r3 = 21;
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 1.11");
            var v1 = Console.ReadLine();
            var v2= Console.ReadLine();
            var v3= Console.ReadLine();
            var v4= Console.ReadLine();
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            
            Console.WriteLine("\nЗадание 1.12");
            string e1 = "5";
            string e2 = "10";
            string e3 = "7 см";
            Console.WriteLine(e1+" "+ e2);
            Console.WriteLine(e3);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 1.13");
            string t1 = "2 кг";
            string t2 = "13";
            string t3 = "17";
            Console.WriteLine(t1);
            Console.WriteLine(t2+" "+t3);
            Console.ReadKey();


            Console.WriteLine("\nЗадание 2.1");
            string x1 = Console.ReadLine();
            int x2 = Convert.ToInt32(x1);
            int y1 = 7 * x2 * x2 + 3 * x2 + 6;
            string a1 = Console.ReadLine();
            int a2 = Convert.ToInt32(a1);
            int y2 = 12 * a2 * a2 + 7 * a2 + 12;
            Console.WriteLine("y="+ y1);
            Console.WriteLine("x="+ y2);
            Console.ReadKey();


            Console.WriteLine("\nЗадание 2.2");
            var sq = Console.ReadLine();
            int sqi = Convert.ToInt32(sq);
            int perimetr = 4 * sqi;
            Console.WriteLine("Периметр квадрата="+ perimetr);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.3");
            var radius = Console.ReadLine();
            int iradius = Convert.ToInt32(radius);
            int diametr = iradius * 2;
            Console.WriteLine("Диаметр окружности=" + diametr);
            Console.ReadKey(); 
            Console.WriteLine("\nЗадание 2.4");
            int R = 6367;
            var h = Console.ReadLine();
            int ih = Convert.ToInt32(h);
            double rastoyanie = Math.Sqrt((ih + R) * (ih + R) - (R*R));
            Console.WriteLine("расстояние до линии горизонта="+ rastoyanie);
            Console.ReadKey();
            

            Console.WriteLine("\nЗадание 2.5");
            var rebro = Console.ReadLine();
            int irebro = Convert.ToInt32(rebro);
            double V= Math.Pow(irebro,3);
            int S = 4 * irebro * irebro;
            Console.WriteLine("Объем куба равен " + V);
            Console.WriteLine("Площадь боковой поверхности куба равна " +S );
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.6");
            var rad = Console.ReadLine();
            int irad = Convert.ToInt32(rad);
            double pi = Math.PI;
            double Scircle =pi*irad* irad;
            double Lcircle = 2 * pi * irad;
            Console.WriteLine("Площадь круга равна " + Scircle);
            Console.WriteLine("Длина окружности равна " + Lcircle);
            Console.ReadKey(); 

            Console.WriteLine("\nЗадание 2.7");
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();
            double inumber1 = Convert.ToInt32(number1);
            double inumber2 = Convert.ToInt32(number2);
            double arifm = ((inumber1 + inumber2) / 2);
            double geomet = Math.Sqrt((inumber1 * inumber2));
            Console.WriteLine("Среднее арифметическое= "+arifm);
            Console.WriteLine("Среднее геометрическое= "+geomet);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.8");
            var v = Console.ReadLine();
            var massa = Console.ReadLine();
            double vd = Convert.ToInt32(v);
            double massad = Convert.ToInt32(massa);
            double plotnv = massad / vd;
            Console.WriteLine("Плотность вещесва= " + plotnv);
            Console.ReadKey(); 

            Console.WriteLine("\nЗадание 2.9");
            var kolvo = Console.ReadLine();
            var terr = Console.ReadLine();
            double kolvod = Convert.ToInt32(kolvo);
            double terrd = Convert.ToInt32(terr);
            double plotnn = kolvod / terrd;
            Console.WriteLine("Плотность населения " + plotnn);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.10");
            var A = Console.ReadLine();
            var B = Console.ReadLine();
            double Ad = Convert.ToInt32(A);
            double Bd = Convert.ToInt32(B);
            double X = (-Bd / Ad);
            Console.WriteLine("Корень уравнения " + X);
            Console.ReadKey(); */




        }
    }
}

