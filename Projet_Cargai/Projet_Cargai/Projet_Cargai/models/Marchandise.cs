using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Carg.models
{
    class Marchandise
    {
        private int id;
        private String numero;
        private double poids;
        private double volume;
        private static int nbreMarchandise;




        public Marchandise()
        {
            this.id = ++nbreMarchandise;
            this.numero = string.Format("March{0}", this.id).ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; }
        public double Poids { get => poids; set => poids = value; }
        public double Volume { get => volume; set => volume = value; }
        public static int NbreMarchandise { get => nbreMarchandise; }
    }
}
