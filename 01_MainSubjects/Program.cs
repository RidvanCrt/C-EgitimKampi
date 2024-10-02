using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects //Proje İsmi
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları

            //Console.WriteLine("Hello World");
            //Console.Write("Hi");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            ////string
            ////Değişkenin_türü değişken_adı

            ////string name;
            ////name = "Rıdvan";
            ////Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Veli";
            //customerPhone = "+90 500 500 45 45";
            //customerEmail = "deneme@gmail.com";
            //district = "Aziziye";
            //city = "Erzurum";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district +"/"+ city);
            //Console.WriteLine("------------------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 200 25 25";
            //customerEmail = "deneme2@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");



            //Console.Read();
            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restaurant Menu Price *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: "+ hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: "+ pizzaPrice + " TL");
            Console.WriteLine("-----Kola: "+ cokePrice + " TL");
            Console.WriteLine("-----Lemonade: "+ lemonadePrice + " TL");
            Console.WriteLine("-----Fries: "+ friesPrice + " TL");
            Console.WriteLine("-----Water: "+ waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restaurant Menu Price *****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            
            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;
            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + " TL");
            Console.WriteLine("Cola Tutarı : " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + " TL");
            Console.WriteLine("Toplam Tutar : " + totalPrice + " TL");
            
            


            #endregion 

            Console.Read();
        }
    }
}


//Yazdırma Komutları
