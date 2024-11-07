using ConsoleApp1.Contians;
using ConsoleApp1.Entities;
using ConsoleApp1.Repositoris;

namespace ConsoleApp1.Service
{
    public class ProductService : IService
    {
        IRepository Repo;

        public ProductService()
        {
            Repo = new Repository();
        }

        public void Get()
        {
            foreach(var item in Repo.Get())
            {
                Console.WriteLine($"Id : {item.Id} , Name : {item.Name} , Price : {item.Price} , CategoryName : {item.CatrgoryName}");
            }

        }

        public void GetById(int id)
        {
            var item = Repo.GetById(id);
            Console.WriteLine($"Id : {item.Id} , Name : {item.Name} , Price : {item.Price} , CategoryName : {item.CatrgoryName}");
        }
        public void Add(string name , int price , int categoryId)
        {
            Product p = new Product()
            {
                Name = name,
                Price = price ,
                CategoryId = categoryId
            };
            Repo.Add(p);

        }

        public void Update(int id , string name, int price, int categoryId)
        {
            Product p = new Product()
            {
                Name = name,
                Price = price,
                CategoryId = categoryId
            };
            Repo.Update(id , p);
        }

        public void Delete(int id)
        {
            Repo.Delete(id);
        }

  
    }
}
