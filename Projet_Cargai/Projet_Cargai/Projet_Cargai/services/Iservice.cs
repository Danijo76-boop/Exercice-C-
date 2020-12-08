using Projet_Carg.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Carg.services
{
    interface Iservice
    {
        bool addCargaison(Cargaison cargaison);
        List<Cargaison> Cargaison();
        IEnumerable<object> listerCargaison();
    }
}
