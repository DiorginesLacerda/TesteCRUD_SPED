using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Repositories
{
    public class EstadoRepository
    {
        private CrudSpedContext context;

        public EstadoRepository(CrudSpedContext context)
        {
            this.context = context;
        }

        public IList<Estado> GetAll()
        {
            return this.context.Estados.ToList();
        }
    }
}