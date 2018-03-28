using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Repositories
{
    public class PaisRepository
    {
        private dbContext context;

        public PaisRepository(dbContext context)
        {
            this.context = context;
        }

        public IList<PAISES_IBGE> getAll()
        {
            var lista = context.Paises.ToList();
            return lista;
        }
    }
}