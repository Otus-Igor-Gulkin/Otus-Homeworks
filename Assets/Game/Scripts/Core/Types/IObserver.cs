using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Core.Types {
    public interface IObserver {
        void Register();
        void Unregister();
    }
}
