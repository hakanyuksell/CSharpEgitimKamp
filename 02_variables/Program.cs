using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Double Değişkenler 

			//Console.WriteLine("***FİYAT LİSTESİ***");
			//Console.WriteLine();

			//double applePrice, orangePrice, strawberyPrice, patatoPrice, tamatoPrice;
			//applePrice = 14.85;
			//orangePrice = 20.95;
			//strawberyPrice = 45;
			//patatoPrice = 9.74;
			//tamatoPrice = 6.88;

			//Console.WriteLine("------Elma Birim Fiyatı------" + applePrice + " TL");
			//Console.WriteLine("-----Portakal Birim Fiyatı-----" + orangePrice + " TL");
			//Console.WriteLine("------Çilek Birim Fiyatı------" + strawberyPrice + " TL");
			//Console.WriteLine("------Patates Birim Fiyatı------" + patatoPrice + " TL");
			//Console.WriteLine("------Domates Birim Fiyatı------" + tamatoPrice + " TL");
			//Console.WriteLine();
			//Console.WriteLine("**************************************************");
			//Console.WriteLine();

			//double applegram, orangegram, strawgram, patatogram, tamatogram;
			//applegram = 1.245;
			//orangegram = 2.650;
			//strawgram = 0.750;
			//patatogram = 4.589;
			//tamatogram = 3.745;

			//double appleTotalPrice = applePrice * applegram;
			//double orangeTotalPrice = orangePrice * orangegram;
			//double strawberyTotalPrice = strawberyPrice * strawgram;
			//double tomatoTotalPrice = tamatoPrice * tamatogram;
			//double patatoTotalPrice = patatoPrice * patatogram;


			//Console.WriteLine("Alınan Ürün= Elma - " + "Birim Fiyat =" + applePrice + " Gramaj =" + applegram + "- Ödenen Ücret = " + appleTotalPrice);
			//Console.WriteLine("Alınan Ürün= Portakal - " + "Birim Fiyat =" + orangePrice + " Gramaj =" + orangegram + "- Ödenen Ücret = " + orangeTotalPrice);
			//Console.WriteLine("Alınan Ürün= Çilek - " + "Birim Fiyat =" + strawberyPrice + " Gramaj =" + strawgram + "- Ödenen Ücret = " + strawberyTotalPrice);
			//Console.WriteLine("Alınan Ürün= Domates - " + "Birim Fiyat =" + tamatoPrice + " Gramaj =" + tamatogram + "- Ödenen Ücret = " + tomatoTotalPrice);
			//Console.WriteLine("Alınan Ürün= Patates - " + "Birim Fiyat =" + patatoPrice + " Gramaj =" + patatogram + "- Ödenen Ücret = " + patatoTotalPrice);
			//Console.WriteLine();
			//Console.WriteLine("**************************************************");

			//double doubleshopingprice = appleTotalPrice + orangeTotalPrice + strawberyTotalPrice + tomatoTotalPrice + patatoTotalPrice;
			//Console.WriteLine("Alışveriş Toplam Tutar = " + doubleshopingprice);

			#endregion

			#region Char Değişkenler

			//char symbol = 'a'; //tek tırnak arasında olmak zorunda
			//Console.WriteLine(symbol);


			#endregion

			#region Klavyeden String Veri Girişi

			//Console.WriteLine("****CSharp Hava Yolları Yolcu Bilgisi****");
			//Console.WriteLine();

			//string passengername, passengersurname,
			//	passengerdistrict, passengercity, 
			//	passengerage, passengeridedentityid;

			//Console.Write("Yolcu Adı: ");
			//passengername = Console.ReadLine(); //Kullanıcı Girecek

			//Console.Write("Yolcu Soy Adı: ");
			//passengersurname = Console.ReadLine();

			//Console.Write("İlçe Bilgisi: ");
			//passengerdistrict = Console.ReadLine(); 

			//Console.Write("Şehir Bilgisi: ");
			//passengercity = Console.ReadLine();

			//Console.Write("Yolcu Yaşı:  ");
			//passengerage = Console.ReadLine();

			//Console.WriteLine("Yolcu TC-Kimlik Numarası ");
			//passengeridedentityid = Console.ReadLine();

			//Console.WriteLine();

			//Console.WriteLine("-----------------------------");
			//Console.WriteLine("Yolcu TC Kimlik Numarası" +passengeridedentityid + "  Yolcu Adı: " 
			//	+ passengername + " Yolcu Soy Adı: " 
			//	+ passengersurname + " Yolcu İlçe: " 
			//	+ passengerdistrict + " Yolcu Şehir: " 
			//	+ passengercity + " Yolcu Yaşı " 
			//	+ passengerage) ;


			#endregion

			#region Tam Sayı Girişleri ve Dönüşümler 

			//int shoeprice, computerprice, chairprice, tvprice;
			//shoeprice = 1000;
			//computerprice = 2000;
			//chairprice = 5000;
			//tvprice = 12000;

			//int shoescount, computercount, chaircount, tvcount;

			//Console.WriteLine("Lütfen aldığınız ayakkanı sayısını giriniz  ");
			//shoescount = int.Parse(Console.ReadLine());

			//Console.WriteLine("Aldığınız Bilgisayar Sayısını Giriniz  ");
			//computercount = int.Parse(Console.ReadLine());

			//Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz  ");
			//tvcount = int.Parse(Console.ReadLine());

			//Console.WriteLine("Aldığınız Sandalye Sayısını Giriniz  ");
			//chaircount = int.Parse(Console.ReadLine());


			//int totalprice = shoescount * shoeprice + computercount * computerprice
			//	+ tvcount* tvprice + chaircount * chairprice;

			//Console.WriteLine();
			//Console.WriteLine("Toplam Ödemeniz gereken tutar: " + totalprice + " TL");


			#endregion

			#region Klavyeden Ondalıklı Sayı İşlemleri

			//double exam1, exam2, exam3, result;

			//Console.Write("1. Sınav notunu giriniz: ");
			//exam1 = double.Parse(Console.ReadLine());

			//Console.Write("2. Sınav notunu giriniz: ");
			//exam2 = double.Parse(Console.ReadLine());

			//Console.Write("3. Sınav notunu giriniz: ");
			//exam3 = double.Parse(Console.ReadLine());

			//result = (exam1 + exam2 + exam3) / 3;
			//Console.WriteLine();
			//Console.WriteLine("Sınav Ortalamanız : " + result);
			#endregion

			#region Klavyeden Karakter Girişleri

			//char gender;
			//Console.Write("Lütfen Cinsiyeti Seçiniz");
			//gender = char.Parse(Console.ReadLine());

			//Console.Write("Seçtiğiniz Cinsiyet = " + gender);

			#endregion

			Console.ReadKey();

		}
	}
}
