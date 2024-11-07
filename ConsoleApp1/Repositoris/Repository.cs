using ConsoleApp1.Contians;
using ConsoleApp1.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositoris
{
    public class Repository : IRepository
    {

     

        public List<ProductCategory> Get()
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                return db.Query<ProductCategory>(ShopQueries.Get).ToList();
            }
        }

     

  
        public void Add(Product product)
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                db.Execute(ShopQueries.Add, new { product.Name , product.CategoryId , product.Price });
            }

        }

        public ProductCategory GetById(int id)
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                return db.QueryFirstOrDefault<ProductCategory>(ShopQueries.GetById, new { id });
            }
        }

        public void Update(int id ,Product product)
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                db.Execute(ShopQueries.Update, new {Name = product.Name , Price = product.Price , CategoryId = product.CategoryId , Id = id});
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                db.Execute(ShopQueries.Delete, new { id });
            }
        }
    }
}


