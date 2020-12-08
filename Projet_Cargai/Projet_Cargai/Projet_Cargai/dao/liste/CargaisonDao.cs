using Projet_Carg.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Carg.dao.liste
{
    class CargaisonDao : IDao<Cargaison>
    {
        List<Cargaison> listeCargaison;

        public CargaisonDao()
        {
            listeCargaison = new List<Cargaison>();
            listeCargaison.Add(
                new Aerienne()
                {
                    Distance=10
                });

            listeCargaison.Add(
                new Routiere()
                {
                    Distance = 20
                });

            listeCargaison.Add(
                new Aerienne()
                {
                    Distance = 30
                });
        }
        Cargaison IDao<Cargaison>.add(Cargaison cargaison)
        {
            listeCargaison.Add(cargaison);
            return cargaison;
        }

        List<Cargaison> IDao<Cargaison>.getAll()
        {
            return listeCargaison;
        }
    }
}
