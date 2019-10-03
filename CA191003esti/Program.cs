using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA191003esti
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            #region
            //int x = rnd.Next();
            //Console.WriteLine(x);

            //int y = rnd.Next(100);
            //Console.WriteLine(y);

            //int z = rnd.Next(-10, 10);
            //Console.WriteLine(z);
            #endregion
            #region 31. feladat
            //Console.WriteLine(rnd.Next(100, 1000));
            #endregion
            #region 32. feladat
            //Console.WriteLine(rnd.Next(26));
            //double x = rnd.Next(251) / 10.0;
            //Console.WriteLine(x);
            #endregion
            #region 33. feladat
            //Console.WriteLine(rnd.Next(15, 26));
            //double x = rnd.Next(150, 251) / 10.0;
            //Console.WriteLine(x);
            #endregion
            #region 34. feladat
            //int x = rnd.Next(50) * 2;
            //Console.WriteLine(x);
            #endregion
            #region 35. feladat
            //Console.WriteLine(rnd.Next(20, 41) * 5);
            #endregion
            #region 36. feladat
            //int x = rnd.Next(1000001);
            //Console.WriteLine(x);
            //int j;
            //if (x == 1000000) j = 7;
            //else if (x >= 100000) j = 6;
            //else if (x >= 10000) j = 5;
            //else if (x >= 1000) j = 4;
            //else if (x >= 100) j = 3;
            //else if (x >= 10) j = 2;
            //else j = 1;
            //Console.WriteLine($"{j} jegyű");
            //Console.WriteLine($"{x.ToString().Length} jegyű");
            #endregion
            #region 39. feladat
            //int a = rnd.Next(10, 51);
            //int b = rnd.Next(10, 51);

            //Console.Write($"{a} + {b} = ");
            //int v = int.Parse(Console.ReadLine());

            //if (v == a + b) Console.WriteLine("helyes!");
            //else Console.WriteLine("nem jó :(");
            #endregion
            //--------------...........
            #region 2/1. feladat
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Zolikaaa");
            //}
            #endregion
            #region 2/2. feladat
            //Console.Write("szám: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("szöveg: ");
            //string sz = Console.ReadLine();
            //for (int i = 0; i < n; i++)
            //    Console.Write(sz + " ");
            #endregion
            #region 2/3. feladat
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.Write(i);
            //    Thread.Sleep(1000);
            //    Console.Clear();
            //}
            //Console.WriteLine("viszont látásra!");
            //System.Threading.Thread.Sleep(3000);
            #endregion
            #region 2/4/a. feladat
            //for (int i = 0; i < 100; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("Zolikaaaa");
            //    Thread.Sleep(100);
            //    Console.Clear();
            //}
            #endregion
            #region 2/4/b. feladat
            //for (int i = 0; i < 100; i++)
            //{
            //    string nev = "Zolikaaaa";

            //    int sz = Console.WindowWidth - nev.Length;
            //    int m = Console.WindowHeight;

            //    int l = rnd.Next(sz);
            //    int t = rnd.Next(m);

            //    Console.SetCursorPosition(l, t);

            //    Console.WriteLine("Zolikaaaa");
            //    Thread.Sleep(500);
            //    Console.Clear();
            //}
            #endregion
            #region 2/5-6 feladat
            //for (int i = 0; i < 20000; i++)
            //{
            //    Console.SetCursorPosition(
            //        rnd.Next(Console.WindowWidth),
            //        rnd.Next(Console.WindowHeight -1));

            //    Console.ForegroundColor = (ConsoleColor)rnd.Next(16);
            //    Console.BackgroundColor = (ConsoleColor)rnd.Next(16);
            //    Console.Write("*");
            //}
            #endregion
            #region 1/39 v2.0
            ///specifikáció:
            ///10 db rndom összeadás
            ///mindegyiket kiérkélei
            ///megmondja, hogy hányat találtál el
            ///időre
            ///using System.Diagnostics -> stopwatch

            int p = 0;
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 10; i++)
            {
                int a = rnd.Next(1, 51);
                int b = rnd.Next(1, 51);

                Console.Write($"{a} + {b} = ");
                var v = int.Parse(Console.ReadLine());

                if(a + b  == v)
                {
                    Console.WriteLine("grat!  :)");
                    p++;
                }
                else Console.WriteLine("téves! :(");
                Console.WriteLine("----------");
            }
            sw.Stop();

            Console.WriteLine($"Helyes megoldások: {p}/10");
            Console.WriteLine(
                "Megoldási idő: {0:0.00} sec.",
                sw.Elapsed.TotalSeconds);
            #endregion
            Console.ReadKey();
        }
    }
}