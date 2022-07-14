using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeJugadores.Data.EF
{
    public partial class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdEquipo { get; set; }

        public virtual Equipo IdEquipoNavigation { get; set; }
    }
}
