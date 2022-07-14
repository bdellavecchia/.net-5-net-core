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
    public class JugadorRepositorio : BaseRepo,IJugadorRepositorio
    {
        public JugadorRepositorio(Parcial2Context ctx) : base(ctx)
        {
        }

        public void Agregar(Jugador jugador)
        {
            _Contexto.Jugadors.Add(jugador);
            _Contexto.SaveChanges();
        }

        public List<Jugador> ObtenerJugadores()
        {
            return _Contexto.Jugadors.Include(o => o.IdEquipoNavigation).ToList();
        }

        public List<Jugador> ObtenerPorEquipo(int idEqupo)
        {
            return _Contexto.Jugadors.Include(o => o.IdEquipoNavigation).OrderBy(o => o.Nombre)
                    .Where(o => o.IdEquipo == idEqupo).ToList(); 
        }
    }
}
