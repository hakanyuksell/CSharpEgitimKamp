using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_makingdecision
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Karar Yapıları İf 
			//Console.WriteLine("Lütfen şifre girin");
			//string password;
			//password = Console.ReadLine();

			//if (password == "abcd")
			//{
			//	Console.WriteLine("Şifre doğru");
			//}
			//else
			//{
			//	Console.WriteLine("Şifre yanlış");
			//}



			//string capital;
			//string country;
			//Console.WriteLine("Başkenti giriniz");
			//capital = Console.ReadLine();

			//Console.WriteLine("Ülkeyi Giriniz");
			//country = Console.ReadLine();

			//if (capital =="a" & country =="t")
			//{
			//	Console.WriteLine("Veriler doğrulandı");
			//}
			//else
			//{
			//	Console.WriteLine("Yanlış");
			//}

			//-------------------------------------------- 

			//int sayi;
			//Console.WriteLine("Sayıyı giriniz");
			//sayi = int.Parse(Console.ReadLine());

			//if (sayi == 5)
			//{
			//	Console.WriteLine("Sayı Doğru");
			//}
			//else
			//{
			//	Console.WriteLine("Sayı Yanlış");
			//}

			//-------------------------------------------- 

			//double exam1, exam2, ortalama;
			//Console.WriteLine("Vize Notunuzu giriniz");
			//exam1 = double.Parse(Console.ReadLine());

			//Console.WriteLine("final Notunuzu giriniz");
			//exam2 = double.Parse(Console.ReadLine());	

			//ortalama = (exam1 + exam2) / 2;

			//Console.WriteLine("Sınavların ortalaması: " + ortalama);
			//Console.WriteLine("------------------------------");

			//if (ortalama >= 0 & ortalama <= 50)
			//{			
			//		Console.WriteLine("Vasatsın");		
			//}
			//else if(ortalama >50 & ortalama <70)
			//{
			//	Console.WriteLine("İdare eder");
			//}
			//else if (ortalama >= 70 & ortalama <= 100)
			//{
			//	Console.WriteLine("Harika bir öğrencisin");
			//}
			//else
			//{
			//	Console.WriteLine("Bu işte bir yanlışlık olmalı");
			//}

			//-------------------------------------------- 


			//string city;
			//Console.WriteLine("Lütfen Şehir Girişi Yapınız");
			//city = Console.ReadLine();

			//if(city == "ankara" | city == "adana")
			//{
			//	Console.WriteLine("Doğru bildin kral");
			//}
			//else
			//{
			//	Console.WriteLine("Henüz sistemimde oralar yok");
			//}

			//-------------------------------------------- 

			//string username;

			//Console.WriteLine("Lütfen kullanıcı adını giriniz");
			//username = Console.ReadLine();

			//if (username != "admin")
			//{
			//	Console.WriteLine("Yanlış bro");
			//}
			//else
			//{
			//	Console.WriteLine("hoş geldin bro");
			//}

			#endregion

			#region mod alma
			//int number;
			//number = 26;
			//int result = 26 % 5;
			//Console.WriteLine(result);

			//--------------------------------------------------------

			//Console.WriteLine("1. Sayıyı Girin");
			//int number = int.Parse(Console.ReadLine());

			//Console.WriteLine("2. Sayıyı Girin");
			//int number2 = int.Parse(Console.ReadLine());

			//int result = number % number2;
			//Console.WriteLine("1. Sayının 2. sayıya bölümünden kalan değer:  " + result);

			//--------------------------------------------------------




			#endregion

			#region switchcase

			//Console.WriteLine("Lütfen ay girişi yapınız");
			//int monthnumber = int.Parse(Console.ReadLine());

			//switch(monthnumber)
			//{
			//	case 1: Console.WriteLine("Ocak"); break;
			//	case 2: Console.WriteLine("Şubat"); break;
			//	case 3: Console.WriteLine("Mart"); break;
			//	case 4: Console.WriteLine("Nisan"); break;
			//	case 5: Console.WriteLine("Mayıs"); break;
			//	case 6: Console.WriteLine("Haziran"); break;
			//	case 7: Console.WriteLine("Temmuz"); break;
			//	case 8: Console.WriteLine("Ağustos"); break;
			//	case 9: Console.WriteLine("Eylül"); break;
			//	case 10: Console.WriteLine("Ekim"); break;
			//	case 11: Console.WriteLine("Kasım"); break;
			//	case 12: Console.WriteLine("Aralık"); break;
			//	default: Console.WriteLine("Hatalı veri"); break;	
			//}

			#endregion

			#region hesapmakinesi

			//int number1, number2, result;
			//char symbol;

			//Console.WriteLine("Birinci sayıyı giriniz");
			//number1 = int.Parse(Console.ReadLine());

			//Console.WriteLine("İkinci sayıyı Giriniz");
			//number2 = int.Parse(Console.ReadLine());

			//Console.WriteLine("Yapmak istediğiniz işlemi giriniz");
			//symbol = char.Parse(Console.ReadLine());	

			//switch (symbol)
			//{
			//	case '+':
			//		result = number1 + number2; 
			//		Console.WriteLine("TOPLAM:  " + result); break;

			//	case '-':
			//		result = number1 - number2;
			//		Console.WriteLine("ÇIKARIM:  " + result); break;

			//	case '*':
			//		result = number1 * number2;

			//		Console.WriteLine("ÇARPIM:  " + result); break;
			//	case '/':
			//		result = number1 / number2;
			//		Console.WriteLine("BÖLÜM:  " + result); break;

			}

			#endregion
			
		}
	}
}
