using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LSP.Bad
{
    internal class Worker : IWorker
    {
        public void Eat()
        {
            // yeme islemleri
        }

        public void Work()
        {
            // calısma islemleri
        }
    }
}
