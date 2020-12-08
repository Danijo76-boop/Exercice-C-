using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Carg.models
{
    class Aerienne : Cargaison
    {
        private const int VAL_1 = 10;
        private const int VAL_2 = 12;

        public Aerienne()
        {
            Type = TYPE_CARGAISON.AERIENNE;
        }
        public override double Cout()
        {
            if (this.VolumeTotal < 80000)
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
