using Projet_Carg.dao;
using Projet_Carg.dao.liste;
using Projet_Carg.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Carg.services.liste
{
    class Service 
    {

        //IDao<Cargaison> dao = new CargaisonDao();
        IDao<Cargaison> dao;
        public bool addCargaison(Cargaison cargaison)
        {
            this.dao.add(cargaison);
            return true;
        }

        public Service(IDao<Cargaison> dao)
        {
            this.dao = dao;
        }

        public List<Cargaison> Cargaison()
        {
            return this.dao.getAll();
        }

        public IEnumerable<object> listerCargaison()
        {
            return this.dao.getAll();
        }
    }
}
