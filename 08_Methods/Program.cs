using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Void Metotlar

			//Bir yapının metot olduğunu anlamamız için () sonuna bu gelir ve mor olurlar
			//Özünde 2 ye ayrılır; geriye değer döndüren ve geriye değer döndürmeyen 
			//

			//void CustomerList ()
			//{
			//	Console.WriteLine("Ali Yıldız");
			//	Console.WriteLine("Hakan Öztürk");
			//	Console.WriteLine("Sema Kara");
			//}

			//CustomerList(); 


			//void Sum()
			//{
			//	int x = 1;
			//	int y = 2;
			//	int z = x + y;
			//	Console.WriteLine(z);
			//}

			//Sum();

			#endregion

			#region Geriye Değer Döndürmeyen Parametreli Metotlar

			//void writeMethod(string customerName)
			//{
			//	Console.WriteLine(customerName);
			//}
			//writeMethod("Mehmet Yıldırım");

			//         void customerCard (string name, String Surname)
			//{
			//	Console.WriteLine("Müşteri: " + name + " " + Surname);
			//}
			//customerCard("Mehmet", "Yıldız");
			#endregion

			#region Geriye Değer Döndürmeyen Int Parametreli Metotlar 

			//void burak(int number, int number2, int number3)
			//{
			//	int toplam = number + number2 + number3;
			//	Console.WriteLine(toplam);
			//}

			//burak(100, 266, 10);
			//burak(1,1,1);	


			#endregion

			#region Geriye Değer Döndüren Metotlar 
			//string customerName()
			//{
			//	return "Buse Yıldız";
			//}
			//customerName(); 
			//Geriye değer döndüren metotlar return ile döndürür


			//string StudentCard()
			//{
			//	string name = "Ali";
			//	string surname = "Kaya";

			//	return name + " " + surname;	
			//}
			//Console.WriteLine(StudentCard());
			#endregion

			#region Geriye Değer Döndüren String Parametreli Metotlar

			//string countryCard(string countryName, string capital, string flagColor)
			//{
			//	string cardInfo =	"Ülke: " + countryName + "Başkent " + capital + "Bayrak Rengi: " + flagColor;
			//	return cardInfo;
			//}

			//string x, y, z;
			//Console.WriteLine("Ülke adı giriniz");
			//x = Console.ReadLine();

			//Console.WriteLine("Başkent adı giriniz");
			//y	= Console.ReadLine();

			//Console.WriteLine("Bayrak Rengi giriniz");
			//z = Console.ReadLine();

			//Console.WriteLine(countryCard(x, y, z));
			#endregion

			#region Örnek Uygulama 

			////string examResult (string student, int exam1, int exam2, int exam3)
			////{
			////	int result = (exam1 + exam2 + exam3) / 3;
			////	if (result >= 50)
			////	{
			////		return student + " isimli öğrenci sınavı geçti " + " Ortalama :" + result;
			////	}
			////	else
			////	{
			////		return student + "isimli öğrenci sınavı geçemedi" + "Ortalama :" + result;

			////	}
			////}

			////Console.WriteLine(examResult("Ali", 100, 50, 30));


			#endregion

			Console.ReadLine();
		}
	}
}
