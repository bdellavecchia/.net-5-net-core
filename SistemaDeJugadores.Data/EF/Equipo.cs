using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeJugadores.Data.EF
{
    public partial class Equipo
    {
        public Equipo()
        {
            Jugadors = new HashSet<Jugador>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Jugador> Jugadors { get; set; }
    }
}
