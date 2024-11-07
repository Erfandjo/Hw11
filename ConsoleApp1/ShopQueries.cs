using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ShopQueries
    {
        public static string Add = "insert into Products (Name , CategoryId , Price) values (@Name , @CategoryId , @Price);";
        public static string Get = "SELECT p.Id , p.Name  , p.Price , c.Name As CatrgoryName FROM Products As p join Categories AS c On p.CategoryId = c.Id";
        public static string GetById = "SELECT p.Id , p.Name  , p.Price , c.Name As CatrgoryName FROM Products As p join Categories AS c On p.CategoryId = c.Id WHERE p.Id = @Id";
        public static string Delete = "DELETE Products WHERE Id = @Id";
        public static string Update = "UPDATE Products SET Name = @Name , Price = @Price , CategoryId = @CategoryId Where Id = @Id";
        
    }
}
