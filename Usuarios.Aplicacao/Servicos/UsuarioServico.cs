using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Dominio.Dtos;
using Usuarios.Dominio.Entidades;
using Usuarios.Dominio.Repositorio;
using Usuarios.Dominio.Servicos;

namespace Usuarios.Aplicacao.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public List<UsuarioEntidade> ListarTodosUsuarios()
        {
            var usuarios = _usuarioRepositorio.ObterTodos();

            return usuarios;
        }

        public List<UsuarioEntidade> ListarUsuariosPorNome(string nome)
        {
            var usuarios = _usuarioRepositorio.ListarUsuarioPorNome(nome);

            return usuarios;
        }

        public void InserirUsuario(UsuarioDto dto)
        {
            var entidade = new UsuarioEntidade()
            {
                CodigoUsuario = dto.CodigoUsuario,
                DataAdmissao = dto.DataAdmissao,
                NomeUsuario = dto.NomeUsuario
            };

            _usuarioRepositorio.Adicionar(entidade);
            _usuarioRepositorio.SalvaAlteracoes();
        }

        public void Alterar(int id, string nome, string codigo)
        {
            var entidade = _usuarioRepositorio.ObterPorId(id);
            entidade.CodigoUsuario = codigo;
            entidade.NomeUsuario = nome;

            _usuarioRepositorio.Alterar(entidade);
            _usuarioRepositorio.SalvaAlteracoes();
        }

        public void DeletarUsuario(int id)
        {
            _usuarioRepositorio.Remover(id);
            _usuarioRepositorio.SalvaAlteracoes();
        }
    }
}