using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Repositories
{
    public class PaisRepository
    {
        private CrudSpedContext context;

        public PaisRepository(CrudSpedContext context)
        {
            this.context = context;
        }

        public IList<Pais> getAll()
        {
            return context.Paises.ToList();
        }
    }
}