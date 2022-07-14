using SistemaDeJugadores.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeJugadores.Data.Repositorio.Interfaces
{
    public interface IEquipoRepositorio
    {
        List<Equipo> ObtenerEquipos();

        void SaveChanges();
    }
}
