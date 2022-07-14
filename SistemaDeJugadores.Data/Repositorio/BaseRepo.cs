using SistemaDeJugadores.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeJugadores.Data.Repositorio
{
    public abstract class BaseRepo
    {
        protected Parcial2Context _Contexto { get; set; }

        public BaseRepo(Parcial2Context ctx)
        {
            _Contexto = ctx;
        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }
    }
}
