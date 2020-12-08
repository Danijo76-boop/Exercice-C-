using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Carg.models
{
    enum TYPE_CARGAISON {
        ROUTIERE=1,
        AERIENNE
    }
    abstract class Cargaison
    {
        protected int distance;
        protected double volumeTotal;
        protected double poidsTotal;
        private TYPE_CARGAISON type;

        //Propriete Navigation
        //OneToMany
        private List<Marchandise> marchandises;

        protected Cargaison()
        {
            marchandises = new List<Marchandise>();
        }

        public int Distance { get => distance; set => distance = value; }
        public double VolumeTotal
        {
            get
            {

                foreach (var march in marchandises)
                {
                    volumeTotal += march.Volume;
                }
                return volumeTotal;
            }
            set => volumeTotal = value;
        }
        public double PoidsTotal
        {
            get
            {

                foreach (var march in marchandises)
                {
                    poidsTotal += march.Poids;
                }
                return poidsTotal;
            }
            set => poidsTotal = value;
        }
        public List<Marchandise> Marchandises { get => marchandises; set => marchandises = value; }
        public TYPE_CARGAISON Type { get => type; set => type = value; }

        public abstract double Cout();

        public bool addMarchandise(Marchandise marchandise)
        {
            marchandises.Add(marchandise);
            return true;
        }

        public override string ToString()
        {
            return string.Format("Type: {0} Distance: {1}", Type, Distance);
        }
    }
}

