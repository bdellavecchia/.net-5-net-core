using SistemaDeJugadores.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeJugadores.Servicios.Interfaces
{
    public interface IEquipoServicio
    {
        List<Equipo> ObtenerEquipos();

    }
}
