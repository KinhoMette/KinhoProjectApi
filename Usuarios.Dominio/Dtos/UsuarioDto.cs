using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Dominio.Dtos
{
    public class UsuarioDto
    {
        public string CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}