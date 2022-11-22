using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Dominio.Entidades;

namespace Usuarios.Dominio.Repositorio
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<UsuarioEntidade>
    {
        List<UsuarioEntidade> ListarUsuarioPorNome(string nome);
    }
}