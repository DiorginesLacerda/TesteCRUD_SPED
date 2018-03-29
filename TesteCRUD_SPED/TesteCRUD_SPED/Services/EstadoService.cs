using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Repositories;

namespace TesteCRUD_SPED.Services
{
    public class EstadoService
    {
        private EstadoRepository repository;

        public EstadoService(EstadoRepository repository)
        {
            this.repository = repository;
        }

        public IList<ESTADOS_IBGE> GetAll()
        {
            return repository.GetAll();
        }
    }
}