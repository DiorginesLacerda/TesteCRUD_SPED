using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Repositories
{
    public class ParticipanteRepository
    {
        private CrudSpedContext context;

        public ParticipanteRepository(CrudSpedContext context)
        {
            this.context = context;
        }

        public void Add(Participante participante)
        {
            context.Participantes.Add(participante);
            context.SaveChanges();
        }

        public IList<Participante> GetAll()
        {
            return context.Participantes.ToList();
        }

        public Participante FindById(string cod)
        {
            return context.Participantes.Where(p => p.COD_PART.Equals(cod)).First();
        }

        public void Update(string cod)
        {

        }

    }
}