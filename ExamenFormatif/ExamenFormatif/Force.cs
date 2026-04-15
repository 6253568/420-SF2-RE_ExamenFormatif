using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFormatif
{
    internal class Force
    {
        double Intensité;
        public Vecteur3D Direction { get; set; }
        public CorpsPhysique Corps { get; set; }
    }
}
