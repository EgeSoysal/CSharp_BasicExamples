#region Category Adding Operation
This operation consists of 4 CRUD steps
 Create - Read - Update - Delete

Console.WriteLine("***** Food Management Panel *****");
Console.WriteLine();

Console.WriteLine("--------------------------------------");
Console.Write("Enter Category Name: ");
string categoryName = Console.ReadLine();

SqlConnection connection = new SqlConnection("Data Source=DESKTOP-XXXXXXX; Initial Catalog=FoodOrderDb; Integrated Security=true");

connection.Open();

SqlCommand command = new SqlCommand("INSERT INTO Categories (CategoryName) VALUES (@name)", connection);
command.Parameters.AddWithValue("@name", categoryName);

command.ExecuteNonQuery();
connection.Close();

Console.Write("Category Added Successfully");
Console.Read();
#endregion



#region Product Adding Operation

string productName;
decimal productPrice;

Console.Write("Product Name: ");
productName = Console.ReadLine();

Console.Write("Product Price: ");
productPrice = decimal.Parse(Console.ReadLine());

SqlConnection connection = new SqlConnection("Data Source=DESKTOP-XXXXXXX; Initial Catalog=FoodOrderDb; Integrated Security=true");
connection.Open();

SqlCommand command = new SqlCommand("INSERT INTO Products (ProductName, ProductPrice, ProductStatus) VALUES (@name, @price, @status)", connection);

command.Parameters.AddWithValue("@name", productName);
command.Parameters.AddWithValue("@price", productPrice);
command.Parameters.AddWithValue("@status", true);

command.ExecuteNonQuery();
connection.Close();

Console.Write("Product Added Successfully");
Console.Read();

#endregion



#region Product Listing Operation

SqlConnection connection = new SqlConnection("Data Source=DESKTOP-XXXXXXX; Initial Catalog=FoodOrderDb; Integrated Security=true");

connection.Open();
SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);

SqlDataAdapter adapter = new SqlDataAdapter(command);
DataTable table = new DataTable();
adapter.Fill(table);

connection.Close();

foreach (DataRow row in table.Rows)
{
    foreach (var item in row.ItemArray)
    {
        Console.Write(item.ToString() + " ");
    }
    Console.WriteLine();
}

Console.Read();
#endregion



#region Product Deleting Operation

Console.Write("Enter Product ID to Delete: ");
int productId = int.Parse(Console.ReadLine());

SqlConnection connection = new SqlConnection("Data Source=DESKTOP-XXXXXXX; Initial Catalog=FoodOrderDb; Integrated Security=true");

connection.Open();
SqlCommand command = new SqlCommand("DELETE FROM Products WHERE ProductID=@id", connection);

command.Parameters.AddWithValue("@id", productId);
command.ExecuteNonQuery();

connection.Close();
Console.WriteLine("Product Deleted Successfully");

#endregion



#region Product Updating Operation

Console.Write("Enter Product ID to Update: ");
int productId = int.Parse(Console.ReadLine());

Console.Write("New Product Name: ");
string productName = Console.ReadLine();

Console.Write("New Product Price: ");
decimal productPrice = decimal.Parse(Console.ReadLine());

SqlConnection connection = new SqlConnection("Data Source=DESKTOP-XXXXXXX; Initial Catalog=FoodOrderDb; Integrated Security=true");
connection.Open();

SqlCommand command = new SqlCommand("UPDATE Products SET ProductName=@name, ProductPrice=@price WHERE ProductID=@id", connection);

command.Parameters.AddWithValue("@name", productName);
command.Parameters.AddWithValue("@price", productPrice);
command.Parameters.AddWithValue("@id", productId);

command.ExecuteNonQuery();
connection.Close();

Console.WriteLine("Product Updated Successfully");

#endregion

