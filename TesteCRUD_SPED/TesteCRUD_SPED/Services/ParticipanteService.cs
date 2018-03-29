using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Models;
using TesteCRUD_SPED.Repositories;

namespace TesteCRUD_SPED.Services
{
    public class ParticipanteService
    {
        private ParticipanteRepository repository;

        public ParticipanteService(ParticipanteRepository repository)
        {
            this.repository = repository;
        }

        public void Add(ParticipanteModel model)
        {
            repository.Add(
                    new PARTICIPANTE
                    {
                        COD_PART = model.Cod_Part.ToString(),
                        NOME = model.Nome,
                        COD_PAIS = model.Pais.COD_PAIS,
                        CNPJ = model.CNPJ,
                        CPF = model.CPF,
                        IE = model.IE,
                        COD_MUN = model.Municipio.COD_MUNICIPIO,
                        SUFRAMA = model.SUFRAMA,
                        END = model.Endereco,
                        NUM = model.Numero.ToString(),
                        COMPL = model.Complemento,
                        BAIRRO = model.Bairro
                    });
            
        }

        public IList<PARTICIPANTE> GetAll()
        {
            return repository.GetAll();
        }

        public PARTICIPANTE FindById(string cod)
        {
            return repository.FindById(cod);
        }
    }
}