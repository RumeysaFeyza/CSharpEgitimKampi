using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü

            //    int i = 0;
            //    for (i = 0; i <= 5; i++)
            //    { 
            //        Console.WriteLine("C sharp eğitim kampı");
            //}

            //for (int i = 1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Read();

            //Console.Write("Ekrana ykaç kere yazdırmak istersiniz?");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i =1; i<= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Zafer Bayramı");
            //}








            #endregion
            #region for döngüsü ile karar yapıları
            //int totalValue = 0;
            //for (int i=1; i<20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;

            //    }
            //}

            //Console.WriteLine(totalValue);


            #endregion
            #region while döngüsü
            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion
            #region döngülerle uygulamalar

            //  for (int i = 1; i <= 5; i++)

            //{
            //      for (int j = 1; j <= i; j++)
            //      {
            //          Console.Write("*");

            //      }
            //      Console.WriteLine();


            //  }
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)

            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //            }
            //    Console.WriteLine();
            //    }

            //int n = 5;
            

            //// Üst yarı
            //for (int i = 1; i <= n; i++)
            //{
            //    // Sol boşluklar
            //    for (int j = 0; j < n - i; j++)
            //        Console.Write(" ");

            //    // Yıldızlar
            //    for (int k = 0; k < 2 * i - 1; k++)
            //        Console.Write("*");

            //    Console.WriteLine();
            //}

            //// Alt yarı
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    // Sol boşluklar
            //    for (int j = 0; j < n - i; j++)
            //        Console.Write(" ");

            //    // Yıldızlar
            //    for (int k = 0; k < 2 * i - 1; k++)
            //        Console.Write("*");

            //    Console.WriteLine();
            //}

            #endregion
            Console.Read();
        }
    }
}
