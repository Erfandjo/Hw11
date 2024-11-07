using ConsoleApp1.Contians;
using ConsoleApp1.Entities;
using ConsoleApp1.Repositoris;
using ConsoleApp1.Service;


string name = string.Empty;
int price = 0;
int categoryId = 0;
int id = 0;

IRepository repo = new Repository();
ProductService productService = new ProductService();




while (true)
{
    Console.Clear();
    Console.WriteLine("1) Add Product");
    Console.WriteLine("2) Get All");
    Console.WriteLine("3) Get By Id");
    Console.WriteLine("4) Update");
    Console.WriteLine("5)Delete");
    Console.Write("Please Enter Option : ");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            CreateProduct();
            productService.Add(name, price, categoryId);
            break;
        case 2:
            productService.Get();
            Console.ReadKey();
            break;
        case 3:
            Console.Write("Please Enter Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            productService.GetById(id);
            Console.ReadKey();
            break;
        case 4:
            Console.Write("Please Enter Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            CreateProduct();
            productService.Update(id, name, price, categoryId);
            break;

        case 5:
            Console.Write("Please Enter Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            productService.Delete(id);
            break;



    }


    void CreateProduct()
    {
        Console.Write("Please Enter Name : ");
        name = Console.ReadLine();
        Console.Write("Please Enter Price : ");
        price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please Enter CategoryId : ");
        categoryId = Convert.ToInt32(Console.ReadLine());
    }

}