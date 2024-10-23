using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_loops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region For Döngüsü

			//for(x;y;z) x: Başlangıç, y: bitiş, z:artış-azalış 

			//for (int i = 0; i <= 50; i+=3)
			//{
			//	Console.WriteLine(i);
			//}

			//Console.ReadLine();


			//Console.WriteLine("Kaça kadar devam etsin?");
			//int adet = int.Parse(Console.ReadLine());

			//for (int i = 0; i <= adet; i++)
			//{
			//	Console.WriteLine("Yaşasın Cumhuriyet");
			//}

			//Console.ReadLine();

			#endregion

			#region Döngülerin Karar Yapıları iLE Kullanılması

			//for (int i = 1; i <=100; i++)
			//{
			//	if(i % 5 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}
			//Console.ReadLine();

			//--------------------------------------------------

			//int totalvalue = 0;

			//for (int i = 0; i <= 20; i++)
			//{
			//	if(i % 2 == 0)
			//	{
			//		totalvalue += i;
			//		Console.WriteLine(i);
			//	}
			//}
			//         Console.WriteLine("--------------");
			//Console.WriteLine(totalvalue);

			//-------------------------------------------------

			//int count = 0;
			//for (int i = 1; i<= 50; i++)
			//{
			//	if(i%7 == 0)
			//	{
			//		count++;
			//	}
			//}
			//Console.WriteLine(count);

			//-------------------------------------------------


			//int bacterium = 1;
			//for (int i = 0; i<= 24; i++)
			//{
			//	bacterium *= 2;
			//	Console.WriteLine(i + " . Saat sonunda " + bacterium);
			//}

			#endregion

			#region while döngüsü

			//While (Şart)
			//{
			//İşlemler
			//}

			//int i = 1;

			//--------------------------------------

			//while (i <= 10)
			//{
			//	Console.WriteLine("Merhaba Döngüler");
			//	i++;
			//}

			//----------------------------------------



			#endregion

			#region Örnek Sınav Sorusu

			//Klavyeden girilen 3 basamaklı sayının basamakları toplamını
			//hesaplayan kodu yazınız

			// 456 = 4 + 5 + 6 

			//Console.WriteLine("Bir sayı giriniz :");
			//int number = int.Parse(Console.ReadLine());

			//int ones, tens, hundred;
			//int sum;

			//ones = number % 10;
			//hundred = number / 100;
			//tens = (number % 100)/10;

			//sum = ones + tens + hundred;
			//Console.WriteLine(ones + "-" + tens + "-" + hundred );
			//Console.WriteLine("Girdiğiniz üç basamaklı sayının rakamları toplamı: " + sum);
			#endregion
			//Console.ReadLine();

		}
	}
}
