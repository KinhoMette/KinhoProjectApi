using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Dominio.Entidades
{
    [Table("Usuario")]
    public class UsuarioEntidade
    {
        [Key]
        public int Id { get; set; }

        [Column("CodigoUsuario")]
        public string CodigoUsuario { get; set; }

        public string NomeUsuario { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}