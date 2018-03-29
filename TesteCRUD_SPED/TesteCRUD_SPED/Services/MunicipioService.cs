using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Repositories;

namespace TesteCRUD_SPED.Services
{
    public class MunicipioService
    {
        private MunicipioRepository repository;

        public MunicipioService(MunicipioRepository repository)
        {
            this.repository = repository;
        }

        public IList<MUNICIPIOS_IBGE> GetAll()
        {
            return this.repository.GetAll();
        }
    }
}