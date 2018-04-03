using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Repositories
{
    public class MunicipioRepository
    {
        private dbContext context;

        public MunicipioRepository(dbContext context)
        {
            this.context = context;
        }

        public IList<MUNICIPIOS_IBGE> GetAll()
        {
            return this.context.Municipios.ToList();
        }

        public IList<MUNICIPIOS_IBGE> GetMunicipiosByEstado(int idEstado)
        {
            return this.context.Municipios.Where(m => m.COD_ESTADO == idEstado).ToList();
        }
    }
}