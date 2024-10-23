using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_foreachdongusu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Foreach Döngüsü

			//Foreach(1;2;3;4)

			//1: Değişken Türü
			//2: Değişken Adı 
			//3: In
			//4: Liste, Koleksiyon, Dizi

			//string[] cities = { "Milano", "roma", "budapeşte", "Ankara" };

			//foreach (string x in cities)
			//{
			//	Console.WriteLine(x);
			//}

			//******************************************************************

			//int[] numbers = { 23, 4, 343443, 23, 67, 45, 98, 56, 54 };
			//foreach (int i in numbers)
			//{
			//	Console.WriteLine(i);
			//}

			//**********İkiye tam Bölünen Sayılar***********


			//int[] numbers = { 23, 4, 343443, 23, 67, 45, 98, 56, 54 };
			//foreach (int number in numbers)
			//{
			//	if(number%2 == 0)
			//	{
			//		Console.WriteLine(number);
			//	}
			//}

			//******************************************************************

			//List <int> numbers = new List<int>()
			//{
			//	1,2,3,4,5,6	
			//};

			//foreach (int i in numbers)
			//{
			//	Console.WriteLine(i);
			//}
			//Foreach döngüsü sadece dizilerde değil listelerde
			//de kullanılmaktadır. 


			//******************************************************************

			//string word = "MERHABA";
			//foreach (var c in word)
			//{
			//	Console.WriteLine(c);
			//}

			//******************************************************************

			#endregion

			#region Örnek Sınav Sistemi Uygulaması

			Console.WriteLine("*****C# EĞİTİM KAMPI SINAV UYGULAMASI*****");
			Console.WriteLine();

			//Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma 
			Console.WriteLine("------------------------------------");
			Console.Write("Sınıfınızda kaç öğrenci var?: ");
			int studentCount = int.Parse(Console.ReadLine());
			Console.WriteLine("------------------------------------");

			//Öğrenci isimleri ve not ortalamalarını saklayacak diziler
			string[] studentNames = new string[studentCount];
			double[] studentExamAvg = new double[studentCount];
			
			for (int i = 0; i < studentCount; i++)
			{
				Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
				studentNames[i] = Console.ReadLine();
			
				double totalExam = 0;
				//her öğrenci için 3 sınav notu girişi
				for (int j = 0; j < 3; j++)
				{
					Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1} sınav notunu giriniz: ");
					double value = double.Parse(Console.ReadLine());
					totalExam += value; //notları topluyoruz
					studentExamAvg[i] += totalExam / 3;
				}
				Console.WriteLine();
			}
			//Öğrencilerin ortalamaları ve geçip kalma durumları
			for (int i = 0; i < studentCount; i++)
			{
				Console.WriteLine($"{studentNames[i]}  adlı öğrencinin ortalaması  {studentExamAvg[i]}");
				if (studentExamAvg[i] >= 50)
				{
					Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
				}
				else
				{
					Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
				}
			}
			#endregion
			Console.Read();
		}
	}
}
