using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
namespace Obserwator {
    class Program {
        static void Main(string[] args) {

            Product Witcher = new Product("The Witcher 3", 35.9);
            Client c1 = new Client("Artur");
            Client c2 = new Client("Marcin");
            Client c3 = new Client("Maciek");
            Console.WriteLine(Witcher);
            Witcher.Subscribe(c1);
            Witcher.Subscribe(c2);
            Witcher.Price = 41;
            Console.WriteLine(Witcher);
            Witcher.UnSubscribe(c1);
            Witcher.Price = 39.1;
            Console.WriteLine(Witcher);
            Console.ReadKey();
            
            
            
            
        }
    }
}
