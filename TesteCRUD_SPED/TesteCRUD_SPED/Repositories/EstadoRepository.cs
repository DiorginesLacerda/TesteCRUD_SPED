using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Repositories
{
    public class EstadoRepository
    {
        private dbContext context;

        public EstadoRepository(dbContext context)
        {
            this.context = context;
        }

        public IList<ESTADOS_IBGE> GetAll()
        {
            return this.context.Estados.ToList();
        }
    }
}