using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Repositories
{
    public class MunicipioRepository
    {
        private CrudSpedContext context;

        public MunicipioRepository(CrudSpedContext context)
        {
            this.context = context;
        }

        public IList<Municipio> GetAll()
        {
            return this.context.Municipios.ToList();
        }
    }
}