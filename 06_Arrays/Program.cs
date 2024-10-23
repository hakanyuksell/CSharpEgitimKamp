using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Temel Dizi Örnekleri

			//çift sayılar kendi içerisinde bir dizidir. 
			//renkler: beyaz, kırmızı, siyah (bu da bir dizidir.)

			//DeğişkenTürü[] DiziAdı = New DeğişkenTürü [eleman sayısı]

			//string[] colors = new string[4];
			//colors[0] = "Beyaz"; //Diziler 0. elemandan başlar 
			//colors[1] = "Sarı";
			//colors[2] = "Kırmızı";
			//colors[3] = "Mavi";
			//Console.WriteLine(colors[2]);

			//******************************************************

			//string[] cities = new string [4];

			//cities[0] = "Milano";
			//cities[1] = "Budapeşte";
			//cities[2] = "Lyon";
			//cities[3] = "Kahire";
			//cities[4] = "Üsküp";
			//Console.WriteLine(cities[5]);

			//******************************************************

			//string[] cities = { "Prag", "Roma", "Atina", "Ankara" };
			//Console.WriteLine(cities[2]);


			#endregion

			#region Dizideki Tüm Elemanları Listeleme 

			//string[] colors = { "Pembe", "Beyaz", "Siyah", "Kırmızı" };
			//for (int i = 0; i < colors.Length; i++)
			//{
			//	Console.WriteLine(colors[i]);
			//}

			//*******************************************************

			//int[] numbers = { 4, 54, 6, 45454, 343, 2, 32, 23, 12, 43, 5, 6, 76, 877 };
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	if (numbers[i] % 3 == 0)
			//	{
			//		Console.WriteLine(numbers[i]);
			//	}
			//}

			//*******************************************************

			//Dizideki en büyük elemanı bulan kod

			//int[] myArray = { 1, 2, 3, 4, 5 };
			//int maxnumber = myArray[0];

			//for (int i = 0; i < myArray.Length; i++)
			//{
			//	if (myArray[i] > maxnumber)
			//	{
			//		maxnumber = myArray[i];
			//	}
			//}

			//Console.WriteLine(maxnumber);

			//string[] person = { "Hakan", "Ayşe", "Fatma" };
			//Console.WriteLine(person.Length);

			//array.sort: diziyi küçükten büyüğe çevirmektedir. 
			//array.reverse: diziyi tersten yazdırmaktadır. 

			#endregion

			#region Dizi Metotları

			//string[] customers = { "Ali", "Buse", "AyşeGül", "Emine" };
			//int index = Array.IndexOf(customers, "Buse");

			//Console.WriteLine(index);

			//****************************************************************

			#endregion

			#region Kullanıcıdan değer alma

			//string[] cities = new string[5];

			//for (int i = 0; i < cities.Length; i++)
			//{
			//	Console.Write($"Lütfen {i + 1}. Şehri Giriniz ");
			//	cities[i] = Console.ReadLine();
			//}

			//Console.WriteLine();
			//Console.WriteLine("---------------------------------");

			//for (int i = 0; i < cities.Length; i++)
			//{
			//	Console.WriteLine(cities[i]);	
			//}

			//*********************************************************

			#endregion

			Console.Read();
		}
	}
}
