using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Ado.Net sql yapılarını kullanmamıza olanak sağlayan çerçeve 

			Console.WriteLine("***** C# Ürün Kategori Bilgi Sistemi *****");
			Console.WriteLine();
			Console.WriteLine();

			string tableNumber;

			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("1- Kategoriler");
			Console.WriteLine("2- Ürünler");
			Console.WriteLine("3- Siparişler");
			Console.WriteLine("4- Çıkış Yap");
			Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz");
			tableNumber = Console.ReadLine();
			Console.WriteLine("-------------------------------------------");

			SqlConnection connection = new SqlConnection("Data Source=HAKAN; " + //veri tabanı bilgilerimiz
			"initial Catalog=EgitimKampiDb; integrated security=true ");
			connection.Open(); //bağlantıyı açma komutu
			SqlCommand command = new SqlCommand("Select * From Tbl_Category", connection); //sorgu burada
			SqlDataAdapter adapter = new SqlDataAdapter(command); //köprü görevi görecek komut
			DataTable dataTable = new DataTable(); //verileri ram belleğe almayı sağlar
			adapter.Fill(dataTable); 
			connection.Close(); // bağlantıyı kapatma komutu

			foreach (DataRow row in dataTable.Rows)
			{
				foreach(var item in row.ItemArray)
				{
					Console.Write(item.ToString());
				}
				Console.WriteLine() ;
			}
			
			Console.Read();
		}
	}
}
