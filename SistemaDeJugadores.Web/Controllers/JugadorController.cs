using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaDeJugadores.Data.EF;
using SistemaDeJugadores.Servicios.Interfaces;
using SistemaDeJugadores.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeJugadores.Web.Controllers
{
    public class JugadorController : Controller
    {
        IJugadorServicio _jugadorServicio;
        IEquipoServicio _equipoServicio;

        public JugadorController(IJugadorServicio jugadorServicio, IEquipoServicio equipoServicio)
        {
            _jugadorServicio=jugadorServicio;
            _equipoServicio=equipoServicio;
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            List<Equipo> equipos = _equipoServicio.ObtenerEquipos();
            ViewBag.Equipo = equipos;
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(Jugador jugador)
        {
            if (!ModelState.IsValid)
            {
                List<Equipo> equipos = _equipoServicio.ObtenerEquipos();
                ViewBag.Equipo = equipos;
                return View(jugador);
            }

            _jugadorServicio.Agregar(jugador);
            return RedirectToAction("Lista");
        }

        [HttpGet]
        public ActionResult Lista()
        {
            List<Jugador> jugadores = _jugadorServicio.ObtenerJugadores();
            List<Equipo> equipos = _equipoServicio.ObtenerEquipos();
            ViewBag.Equipo = equipos;
            return View(jugadores);
        }

        [HttpPost]
        public ActionResult Lista(int? IdEquipo)
        {
            if (IdEquipo.HasValue)
            {
                List<Jugador> jugadoresPorEquipo = _jugadorServicio.ObtenerPorEquipo(IdEquipo.Value);
                List<Equipo> equiposs = _equipoServicio.ObtenerEquipos();
                ViewBag.Equipo = equiposs;
                return View(jugadoresPorEquipo);
            }

            List<Jugador> jugadores = _jugadorServicio.ObtenerJugadores();
            List<Equipo> equipos = _equipoServicio.ObtenerEquipos();
            ViewBag.Equipo = equipos;
            return View(jugadores);
        }
    }
}
