using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante
{
    class Usuario
    {
        public String nomUsuario { get; set; }
        public String numTelefono { get; set; }
        public String nombre { get; set; }
        public String turno { get; set; }

        public Usuario(string nomUsuario, string numTelefono, string nombre, string turno)
        {
            this.nomUsuario = nomUsuario;
            this.numTelefono = numTelefono;
            this.nombre = nombre;
            this.turno = turno;
        }
    }
}
