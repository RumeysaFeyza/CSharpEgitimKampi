using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Murat Yıldırım");
            //    Console.WriteLine("Can Aktaş");
            //    Console.WriteLine("Serhat Tecer");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();




            #endregion

            #region geriye değer döndürmeyen string parametreli metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");




            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar
            //void Sum (int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}
            //Sum(4, 5, 6);


            #endregion
            #region geriye değer döndüren metotlar

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            #endregion
            #region geriye değer döndüren string parametreli metotlar
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke " + countryName + "- Başkent: " + capital + "- Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Turkiye","Ankara","Kırmızı"));












            #endregion
            #region geriye değer döndüren int  parametreli metotlar
            //int sum (int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(45, 95));
            //Console.WriteLine(sum(36, 25));
            //Console.WriteLine(sum(43, 50));
            //Console.WriteLine(sum(37, 19));
            //Console.WriteLine(sum(45, 65));


            #endregion
            #region örnek uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti " + "ortalama: " + result;

            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi " + "ortalama: " + result;

            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 26));
            //Console.WriteLine(ExamResult("Demir", 70, 60, 65));









            #endregion


            Console.Read();

        }
    }
}
