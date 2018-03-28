using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Controllers
{
    public class ParticipanteController : Controller
    {
        private Pais pais;
        private Estado estado;
        private Municipio municipio;

        public ParticipanteController(Pais pais,Estado estado, Municipio municipio)
        {
            this.pais = pais;
            this.estado = estado;
            this.municipio = municipio;
        }

        public ActionResult Form()
        {
           // ViewBag.Paises
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