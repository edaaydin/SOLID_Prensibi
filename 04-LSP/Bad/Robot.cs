using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LSP.Bad
{
    internal class Robot : IWorker
    {
        public void Eat()
        {
           // yeme islemlerini gerceklestiremez.
        }

        public void Work()
        {
            // Calısma islemlerini gerceklestirir.
        }
    }
}
