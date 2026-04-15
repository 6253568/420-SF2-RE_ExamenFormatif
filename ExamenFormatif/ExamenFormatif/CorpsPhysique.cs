using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFormatif
{
    internal abstract class CorpsPhysique
    {
        double masse;
        public Vecteur3D position { get; set; }

        public List<Capteur> capteurs { get; set; } = new List<Capteur>();

        // Définition de la méthode abstraite

        public abstract void Deplacer(Vecteur3D force);
    }
}
