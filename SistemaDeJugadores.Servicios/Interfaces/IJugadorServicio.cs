using SistemaDeJugadores.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeJugadores.Servicios.Interfaces
{
    public interface IJugadorServicio
    {
        void Agregar(Jugador jugador);
        List<Jugador> ObtenerJugadores();
        List<Jugador> ObtenerPorEquipo(int idEqupo);

    }
}
