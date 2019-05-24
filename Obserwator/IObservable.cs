using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator {
    interface IObservable {
        void Subscribe(Client observer);
        void UnSubscribe(Client observer);
        void Notify();
       
    }
}
