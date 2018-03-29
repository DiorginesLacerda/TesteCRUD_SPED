﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Models;
using TesteCRUD_SPED.Repositories;
using TesteCRUD_SPED.Services;

namespace TesteCRUD_SPED.Controllers
{
    public class ParticipanteController : Controller
    {
        private PaisService paisService;
        private EstadoService estadoService;
        private MunicipioService municipioService;
        private ParticipanteService participanteService;

        public ParticipanteController(PaisService paisService, EstadoService estadoService,
            MunicipioService municipioService, ParticipanteService participanteService)
        {
            this.paisService = paisService;
            this.estadoService = estadoService;
            this.municipioService = municipioService;
            this.participanteService = participanteService;
        }

        public ActionResult Form()
        {
            SetViewBags();
            return View();
        }

        public ActionResult Add(ParticipanteModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    participanteService.Add(model);
                    return RedirectToAction("Index");
                }
                catch(Exception e)
                {
                    
                    SetViewBags();
                    ModelState.AddModelError("model.Invalida", e);
                    return View("Form", model);
                }
                
            }
            else
            {
                SetViewBags();
                return View("Form", model);
            }
            //verificar onchange no JavaScript
        }

        public ActionResult Index()
        {
            return View(this.participanteService.GetAll());
        }

        private void SetViewBags()
        {
            ViewBag.Paises = paisService.GetAll().OrderBy(p => p.NOME_PAIS);
            ViewBag.Estados = estadoService.GetAll().OrderBy(e => e.SIGLA_ESTADO);
            ViewBag.Municipios = municipioService.GetAll().OrderBy(m => m.NOME_MUNICIPIO);
        }
    }
}