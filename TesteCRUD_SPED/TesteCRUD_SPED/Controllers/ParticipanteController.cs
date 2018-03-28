using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Models;
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
            ViewBag.Paises = paisRepository.GetAll().OrderBy(p=>p.NOME_PAIS);
            ViewBag.Estados = estadoRepository.GetAll().OrderBy(e => e.SIGLA_ESTADO);
            ViewBag.Municipios = municipioRepository.GetAll().OrderBy(m => m.NOME_MUNICIPIO);
            return View();
        }

        public ActionResult Add(ParticipanteModel model)
        {
            if (ModelState.IsValid)
            {
                participanteRepository.Add(
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
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Paises = paisRepository.GetAll().OrderBy(p => p.NOME_PAIS);
                ViewBag.Estados = estadoRepository.GetAll().OrderBy(e => e.SIGLA_ESTADO);
                ViewBag.Municipios = municipioRepository.GetAll().OrderBy(m => m.NOME_MUNICIPIO);
                return View("Form", model);
            }
            
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}