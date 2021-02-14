using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.CarId+" "+c.Description);

            }
        }
    }
}
