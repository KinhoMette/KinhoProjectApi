using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Dominio.Dtos;
using Usuarios.Dominio.Entidades;

namespace Usuarios.Dominio.Servicos
{
    public interface IUsuarioServico
    {
        void InserirUsuario(UsuarioDto dto);

        void Alterar(int id, string nome, string codigo);

        void DeletarUsuario(int id);

        List<UsuarioEntidade> ListarUsuariosPorNome(string nome);

        List<UsuarioEntidade> ListarTodosUsuarios();
    }
}