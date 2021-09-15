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
            double inumber1 = Convert.ToDouble(number1);
            double inumber2 = Convert.ToDouble(number2);
            double arifm = ((inumber1 + inumber2) / 2);
            double geomet = Math.Sqrt((inumber1 * inumber2));
            Console.WriteLine("Среднее арифметическое= "+arifm);
            Console.WriteLine("Среднее геометрическое= "+geomet);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.8");
            var v = Console.ReadLine();
            var massa = Console.ReadLine();
            double vd = Convert.ToToDouble(v);
            double massad = Convert.ToDouble(massa);
            double plotnv = massad / vd;
            Console.WriteLine("Плотность вещесва= " + plotnv);
            Console.ReadKey(); 

            Console.WriteLine("\nЗадание 2.9");
            var kolvo = Console.ReadLine();
            var terr = Console.ReadLine();
            double kolvod = Convert.ToDouble(kolvo);
            double terrd = Convert.ToDouble(terr);
            double plotnn = kolvod / terrd;
            Console.WriteLine("Плотность населения " + plotnn);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.10");
            var A = Console.ReadLine();
            var B = Console.ReadLine();
            double Ad = Convert.ToDouble(A);
            double Bd = Convert.ToDouble(B);
            if (Ad!=0)
            {double X = (-Bd / Ad);
            Console.WriteLine("Корень уравнения " + X);
            }
            else
            {if Ad==0:
            Console.WriteLine("Неверно");
            }
            
           

            Console.WriteLine("\nЗадание 2.11");
            var katetA = Console.ReadLine();
            var katetB = Console.ReadLine();
            double kateta = Convert.ToDouble(katetA);
            double katetb = Convert.ToDouble(katetB);
            double gipotenuza = Math.Sqrt(kateta * kateta + katetb * katetb);
            Console.WriteLine("Гипотенуза треугольника равна=" + gipotenuza);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.12");
            var smallrad = Console.ReadLine();
            var bigrad = Console.ReadLine();
            double Pi = Math.PI;
            int smallRad = Convert.ToInt32(smallrad);
            int bigRad  = Convert.ToInt32(bigrad);
            double Ssmall = Pi * smallRad * smallRad;
            double Sbig = Pi * bigRad * bigRad;
            double Sall = Sbig - Ssmall;
            Console.WriteLine("Площадь кольца=" + Sall);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.13");
            var kateTA = Console.ReadLine();
            var kateTB = Console.ReadLine();
            double kateTa = Convert.ToDouble(kateTA);
            double kateTb = Convert.ToDouble(kateTB);
            double gipoten= Math.Sqrt(kateTa * kateTa + kateTb * kateTb);
            double perimetr = kateTa + kateTb + gipoten;
            Console.WriteLine("Периметр треугольника=" + perimetr);
            Console.ReadKey(); 

            Console.WriteLine("\nЗадание 2.13A");
            var ch1 = Console.ReadLine();
            var ch2 = Console.ReadLine();
            double Ch1 = Convert.ToDouble(ch1);
            double Ch2 = Convert.ToDouble(ch2);
            double arif = (Math.Abs(Ch1) + Math.Abs(Ch2)) / 2;
            double geom = Math.Sqrt(Math.Abs(Ch1) * Math.Abs(Ch2));
            Console.WriteLine("Среднее арифметическое= " + arif);
            Console.WriteLine("Среднее геометрическое= " + geom);
            Console.ReadKey(); 

            Console.WriteLine("\nЗадание 2.14");
            Console.WriteLine("\nВведите размер верхнего основания");
            string osnovanie1 = Console.ReadLine();
            Console.WriteLine("\nВведите размер нижнего основания");
            string osnovanie2 = Console.ReadLine();
            Console.WriteLine("\nВведите размер высоты трапеции");
            string vusota = Console.ReadLine();
            double osnovaniE1 = Convert.ToDouble(osnovanie1);
            double osnovaniE2 = Convert.ToDouble(osnovanie2);
            double vusotA = Convert.ToDouble(vusota);
            double otrezok = (Math.Abs(osnovaniE1 - osnovaniE2))/2;
            double storona = Math.Sqrt(otrezok * otrezok + vusotA * vusotA);
            double ptrapecia = osnovaniE1 + osnovaniE2 + 2 * storona;
            Console.WriteLine("Периметр трапеции=" + ptrapecia);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.15");
            Console.WriteLine("\nВведите первое число");
            string num1 = Console.ReadLine();
            Console.WriteLine("\nВведите второе число");
            string num2 = Console.ReadLine(); 
            double NUM1 = Convert.ToDouble(num1);
            double NUM2 = Convert.ToDouble(num2);
            double plus = NUM1 + NUM2;
            double ranozt = Math.Abs(NUM1 - NUM2);
            double ymnozh = NUM1 * NUM2;
            if (NUM2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            else
            {
                double chastnoe = NUM1 / NUM2;

                Console.WriteLine("Сумма чисел " + plus);
                Console.WriteLine("Разность чисел " + ranozt);
                Console.WriteLine("Произведение чисел " + ymnozh);
                Console.WriteLine("Частное чисел " + chastnoe);
            }
            Console.ReadKey(); 

            Console.WriteLine("\nЗадание 2.16");
            Console.WriteLine("\nВведите длину первой стороны основания параллепипеда");
            string paral1 = Console.ReadLine();
            Console.WriteLine("\nВведите длину второй стороны основания параллепипеда");
            string paral2 = Console.ReadLine();
            Console.WriteLine("\nВведите длину бокового ребра параллепипеда");
            string paral3 = Console.ReadLine();
            double Paral1 = Convert.ToDouble(paral1);
            double Paral2 = Convert.ToDouble(paral2);
            double Paral3 = Convert.ToDouble(paral3);
            double Vparal = Paral1 * Paral2 * Paral3;
            double Sparal = 2 * Paral3 * (Paral1 + Paral2);
            Console.WriteLine("Объем параллепипеда " + Vparal);
            Console.WriteLine("Площадь боковой поверхности параллепипеда " + Sparal);
            Console.ReadKey();
            
            Console.WriteLine("\nЗадание 2.17");
            Console.WriteLine("\nВведите координаты точки А");
            string koordx1 = Console.ReadLine();
            string koordy1 = Console.ReadLine();
            double koordX1 = Convert.ToDouble(koordx1);
            double koordY1 = Convert.ToDouble(koordy1);
            Console.WriteLine("\nВведите координаты точки В");
            string koordx2 = Console.ReadLine();
            string koordy2 = Console.ReadLine();
            double koordX2 = Convert.ToDouble(koordx2);
            double koordY2 = Convert.ToDouble(koordy2);
            double rasst = Math.Sqrt(Math.Pow(koordX2 - koordX1, 2) + (Math.Pow(koordY2 - koordY1, 2)));
            Console.WriteLine("Расстояние между точками равно " + rasst);
         
            //Задание 2.18 идентично 2.15//

            Console.WriteLine("\nЗадание 2.19");
            double osnovaniebig = double.Parse(Console.ReadLine());//большее основание
            double osnovaniesmall = double.Parse(Console.ReadLine());//меньшее основание
            double angl = double.Parse(Console.ReadLine());//угол
            double sq = ((Math.Pow(osnovaniebig, 2) - Math.Pow(osnovaniesmall, 2)) * Math.Tan(angl)) / 4;
            Console.WriteLine("Площадь трапеции "+sq );
            
            Console.WriteLine("\nЗадание 2.20");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            double len1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double len2 = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            double len3 = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            double Perim = len1 + len2 + len3;
            double perim = Perim / 2;//полупериметр
            double striangle = Math.Sqrt(perim * (perim - len1) * (perim - len2) * (perim - len3));
            Console.WriteLine("Площадь треугольника " + striangle);
            Console.WriteLine("Периметр треугольника " + Perim);
            Console.ReadKey();
            
            Console.WriteLine("\nЗадание 2.21");
            int x11 = int.Parse(Console.ReadLine());
            int y11 = int.Parse(Console.ReadLine());
            int x22 = int.Parse(Console.ReadLine());
            int y22 = int.Parse(Console.ReadLine());
            int x33 = int.Parse(Console.ReadLine());
            int y33 = int.Parse(Console.ReadLine());
            int x44 = int.Parse(Console.ReadLine());
            int y44 = int.Parse(Console.ReadLine());
            double length12= Math.Sqrt((x22 - x11) * (x22 - x11) + (y22 - y11) * (y22 - y11));
            double length23 = Math.Sqrt((x22 - x33) * (x22 - x33) + (y22 - y33) * (y22 - y33));
            double length34 = Math.Sqrt((x33 - x44) * (x33 - x44) + (y33 - y44) * (y33 - y44));
            double length41 = Math.Sqrt((x44 - x11) * (x44 - x11) + (y44 - y11) * (y44 - y11));
            double length13 = Math.Sqrt((x33 - x11) * (x33 - x11) + (y33 - y11) * (y33 - y11));
            double perimetr1 = (length12 + length23 + length13) / 2;//полупериметр
            double perimetr2 = (length34 + length41 + length13) / 2;
            double Striangle1= Math.Sqrt(perimetr1 * (perimetr1 - length12) * (perimetr1 - length23) * (perimetr1 - length13));
            double Striangle2 = Math.Sqrt(perimetr1 * (perimetr1 - length13) * (perimetr1 - length34) * (perimetr1 - length41));
            double Spram = Striangle1 + Striangle2;
            Console.WriteLine("Площадь четырехугольника "+Spram);
            */
            Console.WriteLine("\nЗадание 2.22");
            int appleprice= int.Parse(Console.ReadLine());
            int candyprice = int.Parse(Console.ReadLine());
            int cookieprice = int.Parse(Console.ReadLine());
            int countapple = int.Parse(Console.ReadLine());
            int countcandy = int.Parse(Console.ReadLine());
            int countcookie = int.Parse(Console.ReadLine());
            int cost = appleprice * countapple + candyprice * countcandy + cookieprice * countcookie;
            Console.WriteLine(cost);

            Console.WriteLine("\nЗадание 2.23");
            int monitorprice = int.Parse(Console.ReadLine());
            int keybprice = int.Parse(Console.ReadLine());
            int mouseprice = int.Parse(Console.ReadLine());
            int blockprice = int.Parse(Console.ReadLine());
            int countcomp = int.Parse(Console.ReadLine());
            int Price = countcomp * (monitorprice + keybprice + blockprice + mouseprice);
            Console.WriteLine(Price);

            Console.WriteLine("\nЗадание 2.24");
            Console.WriteLine("\nВохраст Тани");
            int Tanya = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВозраст Мити");
            int Mitya = int.Parse(Console.ReadLine());
            double SrVozrast = (Tanya + Mitya) / 2;
            double raznoctM = Math.Abs(Mitya - SrVozrast);
            double raznoctT = Math.Abs(Tanya- SrVozrast);
            Console.WriteLine(SrVozrast);
            Console.WriteLine(raznoctM);
            Console.WriteLine(raznoctT);

            Console.WriteLine("\nЗадание 2.25");
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine(S / (v1 + v2));

            Console.WriteLine("\nЗадание 2.26");


        }

    }
}

