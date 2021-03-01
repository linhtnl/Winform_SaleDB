using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class Product
    {
      
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float SubTotal { get { return Quantity*UnitPrice; } }
        public void display()
        {
            Console.WriteLine("ID: " + ProductID +"\nName: "+ProductName + "\nPrice: " + UnitPrice + "\nQuantity: " + Quantity);
        }
    }
    public class ProductDB
    {
        private readonly string strConnection = @"server=localhost;database=SaleDB;uid=linhtnl;pwd=123";
        public bool AddNewProduct(Product p)
        {
            
            string SQL = "insert Products values(@id,@name,@price,@quantity)";
            int row = 0;
            SqlConnection connection = null;
            try
            {
               connection = new SqlConnection(strConnection);
               SqlCommand command = new SqlCommand(SQL, connection);
               command.Parameters.AddWithValue("@id", p.ProductID);
               command.Parameters.AddWithValue("@name", p.ProductName);
               command.Parameters.AddWithValue("@price", p.UnitPrice);
               command.Parameters.AddWithValue("@quantity", p.Quantity);
               connection.Open();
               row = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }     
            return row==1;
        }
        public bool RemoveProduct(Product p)
        {
            string SQL = "Delete Products where ProductID=@id";
            int row = 0;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.AddWithValue("@id", p.ProductID);
                connection.Open();
                row = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return row == 1;
        }
        public bool UpdateProduct(Product p)
        {
            string SQL = "UPDATE Products set ProductName=@name,UnitPrice=@price,Quantity=@quantity where ProductID=@id";
            int row = 0;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.AddWithValue("@id", p.ProductID);
                command.Parameters.AddWithValue("@name", p.ProductName);
                command.Parameters.AddWithValue("@price", p.UnitPrice);
                command.Parameters.AddWithValue("@quantity", p.Quantity);
                connection.Open();
                row = command.ExecuteNonQuery();
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return row == 1;
        }
        public Product FindProduct(int ProductID)
        {
            string SQL = "Select * from Products Where ProductID=@id";
            Product p = null;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.AddWithValue("@id", ProductID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = int.Parse(reader.GetValue(0).ToString());
                    string name = reader.GetValue(1).ToString();
                    float price = float.Parse(reader.GetValue(2).ToString());
                    int quantity = int.Parse(reader.GetValue(3).ToString());
                    p = new Product()
                    {
                        ProductID = id,ProductName=name,UnitPrice=price,Quantity=quantity
                    
                    };
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return p;
        }
        public List<Product> GetProductList()
        {
            string SQL = "Select * from Products ";          
            List<Product> rs = new List<Product>();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Product p = null;
                while (reader.Read())
                {
                    int id = int.Parse(reader.GetValue(0).ToString());
                    string name = reader.GetValue(1).ToString();
                    float price = float.Parse(reader.GetValue(2).ToString());
                    int quantity = int.Parse(reader.GetValue(3).ToString());
                    p = new Product()
                    {
                        ProductID = id,
                        ProductName = name,
                        UnitPrice = price,
                        Quantity = quantity
                    };
                    rs.Add(p);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return rs;
        }

       
    }
}
