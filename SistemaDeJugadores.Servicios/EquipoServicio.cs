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
    public class EquipoServicio : IEquipoServicio
    {
        IEquipoRepositorio _equipoRepositorio;
        public EquipoServicio(IEquipoRepositorio equipoRepositorio)
        {
            _equipoRepositorio = equipoRepositorio;
        }
        public List<Equipo> ObtenerEquipos()
        {
            return _equipoRepositorio.ObtenerEquipos();
        }
    }
}
