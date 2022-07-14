using SistemaDeJugadores.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeJugadores.Data.Repositorio.Interfaces
{
    public interface IJugadorRepositorio
    {
        void Agregar(Jugador jugador);
        List<Jugador> ObtenerJugadores();
        List<Jugador> ObtenerPorEquipo(int idEqupo);
        void SaveChanges();
    }
}
