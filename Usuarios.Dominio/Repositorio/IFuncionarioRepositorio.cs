using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Dominio.Entidades;

namespace Usuarios.Dominio.Repositorio
{
    public interface IFuncionarioRepositorio : IRepositorioGenerico<Funcionario>
    {
        Funcionario ObterFuncionarioPorCodigo(string codigo);

        List<Funcionario> ObterFuncionariosAtivos();

        List<Funcionario> ObterFuncionariosPorNome(string nome);
    }
}