using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orrangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orrangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("--- Elma Birim Fiyatı :" + applePrice + "TL");
            //Console.WriteLine("--- Portakal Birim Fiyatı :" + orrangePrice + "TL");
            //Console.WriteLine("--- Çilek Birim Fiyatı :" + strawberryPrice + "TL");
            //Console.WriteLine("--- Patates Birim Fiyatı :" + potatoPrice + "TL");
            //Console.WriteLine("--- Domates Birim Fiyatı :" + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orrangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orrangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appletotalPrice = applePrice * appleGram;
            //double orrangetotalPrice = orrangePrice * orrangeGram;
            //double strawberrytotalPrice = strawberryPrice * strawberryGram;
            //double potatototalPrice = potatoPrice * potatoGram;
            //double tomatototalPrice  = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyatı :" + applePrice + "Gramaj : " + appleGram + " - Toplam Tutar : " + appletotalPrice);
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyatı :" + orrangePrice + "Gramaj : " + orrangeGram + " - Toplam Tutar : " + orrangetotalPrice);
            //Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyatı :" + strawberryPrice + "Gramaj : " + strawberryGram + " - Toplam Tutar : " + strawberrytotalPrice);
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyatı :" + potatoPrice + "Gramaj : " + potatoGram + " - Toplam Tutar : " + potatototalPrice);
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyatı :" + tomatoPrice + "Gramaj : " + tomatoGram + " - Toplam Tutar : " + tomatototalPrice);

            //double shoppingtotalPrice= appletotalPrice + orrangetotalPrice + strawberrytotalPrice + potatototalPrice + tomatototalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Toplam Alışveriş Tutarı : " + shoppingtotalPrice + " TL ");

            #endregion

            #region Chairdeğişkenler

            // Yazmış olduğumuz her kodu bir karakter olarak algılar şifreleme komutudur.
            // örneği A HARFİ KENDİSİNDEN SONRAKİ 3. HARFE DENK GELMEKTEDİR.
            // chair değişkenler tek tırnak ile tanımlanır.
            // Örneğin: chair sembol;
            // sembol='a'; olarak gösterilir.
            //Console.WriteLine(sembol);

            #endregion

            #region Klavyeden Veri Girişleri String değişkenler

            //Console.WriteLine("*****CSharp Hava Yolları yolcu Bilgisi*****");
            //Console.WriteLine();

            //string PassengerName, PassengerSurName, PassengerDistrict, PassengerCity, PassengerAge, PassengeIdentityNumer;

            //Console.Write("Yolcu Adı :");
            //PassengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı :");
            //PassengerSurName = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Yolcu :" +  PassengerName + " " + PassengerSurName);

            //Console.Write("İlçe Bilgisi : ");
            //PassengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi : ");
            //PassengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yası : ");
            //PassengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC. Numarası : ");
            //PassengeIdentityNumer = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------");

            //Console.WriteLine("Yolcu : " + " " + PassengerName + " " + PassengerSurName + " " + PassengerDistrict + " " + PassengerCity + " " + PassengerAge + " " + PassengeIdentityNumer);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, cheirPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //cheirPrice = 5000;
            //tvPrice = 5000;

            //int shoesCound, computerCound, cheirCound, tvCound;

            //Console.Write("Lütfen Aldığınız Ayakkabı Adetini Giriniz :");
            //shoesCound = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Adetini Giriniz :");
            //computerCound = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Adetini Giriniz :");
            //cheirCound = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Tv Adetini Giriniz :");
            //tvCound = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCound + computerPrice * computerCound + cheirPrice * cheirCound + tvPrice * tvCound;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar :" + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız : " + result);



            #endregion

            #region Klavyeden Karakter Değişimi

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz : " +  gender);

            #endregion

            #region 



            #endregion

            Console.ReadLine();
        }
        
        
    }
}
