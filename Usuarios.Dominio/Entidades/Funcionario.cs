using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Dominio.Entidades
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Setor { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataAdimissao { get; set; }
        public DateTime? DataDesligamento { get; set; }

       

       
    }

}