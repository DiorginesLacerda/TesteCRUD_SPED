using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Models;
using TesteCRUD_SPED.Services;

namespace TesteCRUD_SPED.Controllers
{
    public class MunicipioController : ApiController
    {
        private MunicipioService municipioService;

        public MunicipioController(MunicipioService municipioService)
        {
            this.municipioService = municipioService;
        }

        public List<MunicipioModel> GetMunicipios(int cod_estado)
        {
            return municipioService.GetMunicipiosByEstado(cod_estado);
        }
    }
}
