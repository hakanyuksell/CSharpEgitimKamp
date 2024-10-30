using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Kategori Ekleme İşlemi

			//Console.WriteLine("***** Menü Sipariş İşlem Paneli*****");
			//Console.WriteLine();

			//Console.WriteLine("--------------------------------------");
			//Console.WriteLine("Eklemek istediğiniz kategori Adı:");
			//string categoryName = Console.ReadLine();

			//SqlConnection connection = new SqlConnection("Data Source=HAKAN; " + //veri tabanı bilgilerimiz
			//"initial Catalog=EgitimKampiDb; integrated security=true ");

			//connection.Open(); //bağlantıyı açma komutu
			//SqlCommand command = new SqlCommand("insert into Tbl_Category (CategoryName) values (@p1)", connection); //sorgu burada
			//command.Parameters.AddWithValue("@p1", categoryName);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.WriteLine("Kategori Başarılı bir şekilde eklendi");

			#endregion

			#region Ürün Ekleme İşlemi 

			//string productName;
			//decimal productPrice;

			//Console.Write("Ürün Adı :");
			//productName = Console.ReadLine();

			//Console.Write("Ürün Fiyatı: ");
			//productPrice=decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=HAKAN; " + //veri tabanı bilgilerimiz
			//"initial Catalog=EgitimKampiDb; integrated security=true ");
			//connection.Open();

			//SqlCommand command = new SqlCommand("insert into Tbl_Product" +
			//" (ProductName, ProductPrice, ProductStatus) values (@p1,@p2,@p3)", connection);
			//command.Parameters.AddWithValue("@p1", productName);
			//command.Parameters.AddWithValue("@p2", productPrice);
			//command.Parameters.AddWithValue("@p3", true);
			//command.ExecuteNonQuery(); // Değişiklikleri kaydet ve bunu veri tabanına yansıt 
			//connection.Close();

			//Console.WriteLine("Ürün eklemesi başarılı");


			#endregion

			#region Ürün Listeleme İşlemi 

			//SqlConnection connection = new SqlConnection("Data Source=HAKAN; " + //veri tabanı bilgilerimiz
			//   "initial Catalog=EgitimKampiDb; integrated security=true ");

			//connection.Open();
			//SqlCommand command = new SqlCommand("Select * From Tbl_Product", connection);
			//SqlDataAdapter adapter = new SqlDataAdapter(command); //sql verileri çeken bir köprü 
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);


			////gelen verileri kullanıcıya göstermek için bir döngü kullanmamız gerekmekte

			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach (var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString() + " ");
			//	}
			//	Console.WriteLine();
			//}

			//connection.Close();

			#endregion

			#region Ürün Silme İşlemi

			//Console.WriteLine("Silinecek Veri");
			//int productId = int .Parse(Console.ReadLine());	

			//SqlConnection connection = new SqlConnection("Data Source=HAKAN; " +
			//"initial Catalog=EgitimKampiDb; integrated security=true ");

			//connection.Open();
			//SqlCommand command = new SqlCommand("Delete From Tbl_Product Where ProductId=@productId" , connection);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.ExecuteNonQuery();
			//connection.Close();

			//Console.WriteLine("Silme İşlemi Yapıldı");

			#endregion

			#region Ürün Güncelleme İşlemi


			//Console.Write("Güncellenecek Ürün ID: ");
			//int ProductId = int.Parse(Console.ReadLine());

			//Console.Write("Güncellenecek Ürün Adı:  ");
			//string ProductName = Console.ReadLine();

			//Console.Write("Güncellenecek Ürün Fiyatı:  ");
			//decimal productPrice = decimal.Parse(Console.ReadLine());	

			//SqlConnection connection = new SqlConnection("Data Source=HAKAN; " +
			//"initial Catalog=EgitimKampiDb; integrated security=true ");
			//connection.Open();
			//   SqlCommand command = new SqlCommand("Update Tbl_Product Set ProductName=@ProductName, " +
			//"ProductPrice=@ProductPrice where ProductId=@ProductId",connection);
			//command.Parameters.AddWithValue("@ProductName" , ProductName);
			//command.Parameters.AddWithValue("@ProductPrice", productPrice);
			//command.Parameters.AddWithValue("@ProductId", ProductId);
			//command.ExecuteNonQuery();

			//connection.Close();
			//Console.WriteLine("Güncelleme İşlemi Başarılı");


			#endregion

			Console.Read();

		}
	}
}
