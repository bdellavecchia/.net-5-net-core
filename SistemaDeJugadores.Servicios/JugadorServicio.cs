using SistemaDeJugadores.Data.EF;
using SistemaDeJugadores.Data.Repositorio.Interfaces;
using SistemaDeJugadores.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeJugadores.Servicios
{
    public class JugadorServicio : IJugadorServicio
    {
        IJugadorRepositorio _jugadorRepositorio;
        public JugadorServicio(IJugadorRepositorio jugadorRepositorio)
        {
            _jugadorRepositorio = jugadorRepositorio;
        }
        public void Agregar(Jugador jugador)
        {
            _jugadorRepositorio.Agregar(jugador);
        }

        public List<Jugador> ObtenerJugadores()
        {
            return _jugadorRepositorio.ObtenerJugadores();
        }

        public List<Jugador> ObtenerPorEquipo(int idEqupo)
        {
            return _jugadorRepositorio.ObtenerPorEquipo(idEqupo);
        }
    }
}
