using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Dominio.Entidades;
using Usuarios.Dominio.Repositorio;
using Usuarios.Infra.Context;

namespace Usuarios.Infra.Repositorios
{
    public class FuncionarioRepositorio : RepositorioGenerico<Funcionario>, IFuncionarioRepositorio
    {
        public FuncionarioRepositorio(MvcContext contexto) : base(contexto)
        {
        }

        public Funcionario ObterFuncionarioPorCodigo(string codigo)
        {
            return DbSet.Where(x => x.Codigo == codigo).FirstOrDefault();
        }

        public List<Funcionario> ObterFuncionariosAtivos()
        {
            return DbSet.Where(x => x.Situacao == true).ToList();
        }

        public List<Funcionario> ObterFuncionariosPorNome(string nome)
        {
            return DbSet.Where(x => x.Nome.Contains(nome)).ToList();
        }
    }
}