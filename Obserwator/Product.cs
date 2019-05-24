using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator {
    class Product : IObservable {
        private double price;
        private string name;
        public double Price { get {
                return price;
            }
            set {   
                if(value != price) {
                    this.price = value;
                    Console.WriteLine("Aktualizacja ceny");
                    Notify();
                }
            }
        }

        private List<Client> observers = new List<Client>();

        public Product(string name,double price) {
            this.name = name;
            this.price = price;
        }
        public void Notify() {
           foreach(var item in observers) {
                item.Update();
            }
        }

        public void Subscribe(Client observer) {
            observers.Add(observer);
        }

        public void UnSubscribe(Client observer) {
            observers.Remove(observer);
        }
        public override string ToString() {
            return $"Produkt {name} o cenie {price}";
        }
    }
}
