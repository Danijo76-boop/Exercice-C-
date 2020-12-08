using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Carg.models
{
    class Routiere : Cargaison
    {

        private const int VAL_1 = 4;
        private const int VAL_2 = 6;
        public Routiere()
        {
            Type = TYPE_CARGAISON.ROUTIERE;
        }


        public override double Cout()
        {
            if (this.VolumeTotal < 380000)
            {
                return VAL_1 * this.Distance * this.PoidsTotal;
            }
            else
            {
                return VAL_2 * this.Distance * this.PoidsTotal;
            }
        }
    }
}
