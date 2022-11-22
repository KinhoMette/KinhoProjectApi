using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Dominio.Entidades;

namespace Usuarios.Infra.Context
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options)
        {
        }

        public DbSet<UsuarioEntidade> Usuario { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
    }
}