using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Contians
{
    public interface IRepository
    {
      
        public void Add(Product product);
        public List<ProductCategory> Get();
        public ProductCategory GetById(int id);
        public void Delete(int id);
        public void Update(int id ,Product product);
   
    }
}
