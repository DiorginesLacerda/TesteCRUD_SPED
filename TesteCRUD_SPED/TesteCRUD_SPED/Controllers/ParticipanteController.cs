using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Repositories;

namespace TesteCRUD_SPED.Controllers
{
    public class ParticipanteController : Controller
    {
        private PaisRepository paisRepository;
        private EstadoRepository estadoRepository;
        private MunicipioRepository municipioRepository;
        private ParticipanteRepository participanteRepository;

        public ParticipanteController(PaisRepository paisRepository, EstadoRepository estadoRepository,
            MunicipioRepository municipioRepository, ParticipanteRepository participanteRepository)
        {
            this.paisRepository = paisRepository;
            this.estadoRepository = estadoRepository;
            this.municipioRepository = municipioRepository;
            this.participanteRepository = participanteRepository;
        }

        public ActionResult Form()
        {
            ViewBag.Paises = paisRepository.getAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}