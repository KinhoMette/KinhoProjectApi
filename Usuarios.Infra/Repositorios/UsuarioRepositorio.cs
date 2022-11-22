using Microsoft.EntityFrameworkCore;
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
    public class UsuarioRepositorio : RepositorioGenerico<UsuarioEntidade>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(MvcContext contexto) : base(contexto)
        {
        }

        public UsuarioEntidade ObterPorNome(string nome)
        {
            return DbSet.Where(entidade => entidade.NomeUsuario == nome).FirstOrDefault();
        }

        public string ObterNomePorNome(string nome)
        {
            var resultado = (from usuario in DbSet
                             where usuario.NomeUsuario == nome
                             select usuario.NomeUsuario)
                             .FirstOrDefault();

            return resultado;
        }

        public List<UsuarioEntidade> ListarUsuarioPorNome(string nome)
        {
            return DbSet.Where(x => x.NomeUsuario.StartsWith(nome)).ToList();
        }
    }
}