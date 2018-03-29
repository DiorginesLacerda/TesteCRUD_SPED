using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Repositories
{
    public class ParticipanteRepository
    {
        private dbContext context;

        public ParticipanteRepository(dbContext context)
        {
            this.context = context;
        }

        public void Add(PARTICIPANTE participante)
        {
            context.Participantes.Add(participante);
            context.SaveChanges();
        }

        public IList<PARTICIPANTE> GetAll()
        {
            return context.Participantes.ToList(); ;
        }

        public PARTICIPANTE FindById(string cod)
        {
            return context.Participantes.Where(p => p.COD_PART.Equals(cod)).First();
        }

        public void Update(string cod)
        {

        }

    }
}