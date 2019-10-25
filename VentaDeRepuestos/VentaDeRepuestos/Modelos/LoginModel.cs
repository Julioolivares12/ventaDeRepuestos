using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRepuestos.Modelos
{
    class LoginModel
    {
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string Email { get; set; }

        public string Perfil { get; set; }
        public string Cargo { get; set; }
    }
}
