using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Repositories;

namespace TesteCRUD_SPED.Services
{
    public class PaisService
    {
        private PaisRepository repository;

        public PaisService(PaisRepository repository)
        {
            this.repository = repository;
        }

        public IList<PAISES_IBGE> GetAll()
        {
            return this.repository.GetAll();
        }
    }
}