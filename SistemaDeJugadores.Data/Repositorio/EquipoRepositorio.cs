using Microsoft.EntityFrameworkCore;
using SistemaDeJugadores.Data.EF;
using SistemaDeJugadores.Data.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeJugadores.Data.Repositorio
{
    public class EquipoRepositorio : BaseRepo, IEquipoRepositorio
    {
        public EquipoRepositorio(Parcial2Context ctx) : base(ctx)
        {
        }

        public List<Equipo> ObtenerEquipos()
        {
            return _Contexto.Equipos.OrderBy(e => e.Nombre).ToList();
        }


    }
}
