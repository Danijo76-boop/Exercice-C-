using Projet_Carg.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Carg.dao.liste
{
    class MarchandiseDao : IDao<Marchandise>
    {
        Marchandise IDao<Marchandise>.add(Marchandise obj)
        {
            throw new NotImplementedException();
        }

        List<Marchandise> IDao<Marchandise>.getAll()
        {
            throw new NotImplementedException();
        }
    }
}
