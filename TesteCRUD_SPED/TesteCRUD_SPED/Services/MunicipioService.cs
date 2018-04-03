using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Models;
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

        public List<MunicipioModel> GetAll()
        {
            List<MunicipioModel> municipios = 
                new List<MunicipioModel>();
            foreach(var m in this.repository.GetAll())
            {
                municipios.Add(new MunicipioModel
                {
                    CodMunicipio = m.COD_MUNICIPIO,
                    NomeMunicipio = m.NOME_MUNICIPIO,
                    CodEstado = m.COD_ESTADO
                });
            }
            return municipios;
        }

        public List<MunicipioModel> GetMunicipiosByEstado(int idEstado)
        {
            List<MunicipioModel> municipios =
                new List<MunicipioModel>();
            foreach (var m in this.repository.GetMunicipiosByEstado(idEstado))
            {
                municipios.Add(new MunicipioModel
                {
                    CodMunicipio = m.COD_MUNICIPIO,
                    NomeMunicipio = m.NOME_MUNICIPIO,
                    CodEstado = m.COD_ESTADO
                });
            }
            return municipios;
        }
    }
}