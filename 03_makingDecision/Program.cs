using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_makingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else

            //Console.Write("Lütfen Şifre Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru ");

            //} else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();


            //if (capital == "ankara" && country == "türkiye")
            //    Console.WriteLine("Verilen Bilgiler Doğrulandı");
            //else
            //{
            //    Console.Write("Hatalı Bilgi.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = " Hata!";
            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Ortalamanız: " + average);

            //if (average > 0 && average <= 50)
            //{
            //    result = " Sonuç Vasat";
            //}
            //if (average > 50 && average <= 70)
            //{
            //    result =  " Sonuç Orta";

            //}
            //if (average > 70 && average <= 84)
            //{
            //    result = " Sonuç İyi";
            //}

            //if (average > 84)
            //{
            //    result = " Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);
            //Console.Read();

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if(city=="adana"  | city =="ankara"  | city=="bursa" | city == "çorum")
            //{
            //    Console.WriteLine("Şehir Mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");

            //}
            //Console.Read();

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz");
            //}
            //Console.Read();




            #endregion

            #region Mod İşlemleri
            //int number = 26;
            //int result = number  %5;
            //Console.WriteLine(result);
            //Console.Read();

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");

            //}

            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            #endregion

            #region char değişken ile karar yapıları
            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz");
            //team = char.Parse(Console.ReadLine());

            //    if (team == 'g' | team == 'G')
            //    { 
            //        Console.Write("Galatasaray");
            //}
            //    if ( team =='f' | team =='F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region örnek
            //Console.WriteLine("******C# Eğitim Restoran Kampı******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------");


            //string menuItem;
            //Console.Write("Detayını Görmek için istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Ana Yemekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Pesto Soslu Makarna");
            //    Console.WriteLine("3-Köfte Izgara");
            //    Console.WriteLine("4-Adana Kebap");
            //    Console.WriteLine("5-Urfa Kebap");
            //    Console.WriteLine();

            //    Console.WriteLine("---------------Ana Yemekler--------------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Çorbalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("Mercimek");
            //    Console.WriteLine("Ezogelin");
            //    Console.WriteLine("Tarhana");
            //    Console.WriteLine("Toyga");
            //    Console.WriteLine("İşkembe");
            //    Console.WriteLine();

            //    Console.WriteLine("---------------Çorbalar--------------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Pizzalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("Karışık");
            //    Console.WriteLine("Sebze");
            //    Console.WriteLine("Bol Sucuk");
            //    Console.WriteLine("Şefin Pizzası");
            //    Console.WriteLine("Pizza Tost");
            //    Console.WriteLine();

            //    Console.WriteLine("---------------Pizzalar--------------");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------İçecekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("Kola");
            //    Console.WriteLine("Soğuk Çay");
            //    Console.WriteLine("Gazoz");
            //    Console.WriteLine("Ayran");
            //    Console.WriteLine("Şalgam");
            //    Console.WriteLine();

            //    Console.WriteLine("---------------İçecekler--------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Tatlılar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("Brownie");
            //    Console.WriteLine("Cheseecake");
            //    Console.WriteLine("Mozaik Pasta");
            //    Console.WriteLine("Profiterol");
            //    Console.WriteLine("Sütlaç");
            //    Console.WriteLine();

            //    Console.WriteLine("---------------Tatlılar--------------");
            //}







            //Console.WriteLine("******C# Eğitim Restoran Kampı******");

















            #endregion

            #region switch case
            //Console.Write("Lütfen ay girişi Yapınız: ");
            //int montNumber = int.Parse(Console.ReadLine());

            //switch (montNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}




            #endregion

            #region örnek switch case hesap makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //            Console.Write("Toplam: " + result);
            //            break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //            Console.Write("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.Write("Bölüm: " + result);
            //        break;
            //}












            #endregion







            Console.Read();

        }
    }
}