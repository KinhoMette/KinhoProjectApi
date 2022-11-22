using System;
using System.Collections.Generic;
using Usuarios.Dominio.Dtos;
using Usuarios.Dominio.Entidades;
using Usuarios.Dominio.Repositorio;

namespace Usuarios.Aplicacao.Servicos
{
    public class FuncionarioAplicacao
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioAplicacao(IFuncionarioRepositorio funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        public List<Funcionario> ObterTodosFuncionarios()
        {
            return _funcionarioRepositorio.ObterTodos();
        }

        public List<Funcionario> ObterFuncionariosPorNome(string nome)
        {
            return _funcionarioRepositorio.ObterFuncionariosPorNome(nome);
        }

        public List<Funcionario> ObterFuncionariosAtivos()
        {
            return _funcionarioRepositorio.ObterFuncionariosAtivos();
        }

        public Funcionario ObterFuncionarioPorCodigo(string codigo)
        {
            return _funcionarioRepositorio.ObterFuncionarioPorCodigo(codigo);
        }

        public void CadastrarFuncionario(FuncionarioDto dto)
        {
            var entidade = new Funcionario()
            {
                Cargo = dto.Cargo,
                Codigo = dto.Codigo,
                DataAdimissao = DateTime.Now,
                DataDesligamento = dto.DataDesligamento,
                Nome = dto.Nome,
                Salario = dto.Salario,
                Setor = dto.Setor,
                Situacao = dto.Situacao
            };

            _funcionarioRepositorio.Adicionar(entidade);
            _funcionarioRepositorio.SalvaAlteracoes();
        }

        public void AlterarFuncionario(FuncionarioDto dto)
        {
            var entidade = _funcionarioRepositorio.ObterPorId(dto.Id);

            entidade.Cargo = dto.Cargo;
            entidade.Codigo = dto.Codigo;
            entidade.DataAdimissao = dto.DataAdimissao;
            entidade.DataDesligamento = dto.DataDesligamento;
            entidade.Nome = dto.Nome;
            entidade.Salario = dto.Salario;
            entidade.Setor = dto.Setor;
            entidade.Situacao = dto.Situacao;

            _funcionarioRepositorio.Alterar(entidade);
            _funcionarioRepositorio.SalvaAlteracoes();
        }

        public void DemitirFuncionario(int id)
        {
            var entidade = _funcionarioRepositorio.ObterPorId(id);

            entidade.DataDesligamento = DateTime.Now;
            entidade.Situacao = false;

            _funcionarioRepositorio.Alterar(entidade);
            _funcionarioRepositorio.SalvaAlteracoes();
        }
    }
}