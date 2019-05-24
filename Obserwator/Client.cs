using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator {
    class Client : IObserver {
        private string name;

        public Client(string name)
        {
            this.name = name;
        }
        public void Update() {
            Console.WriteLine($"Cena zmieniona powiadomienie z {name}");
        }
    }
}
