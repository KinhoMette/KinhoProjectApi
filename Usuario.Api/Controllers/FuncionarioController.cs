using Microsoft.AspNetCore.Mvc;
using System;
using Usuarios.Aplicacao.Servicos;
using Usuarios.Dominio.Dtos;

namespace Usuario.Api.Controllers
{
    [Route("[Controller]")]
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioAplicacao _funcionarioAplicacao;

        public FuncionarioController(FuncionarioAplicacao funcionarioAplicacao)
        {
            _funcionarioAplicacao = funcionarioAplicacao;
        }

        [HttpGet]
        [Route("ObterTodos")]
        public ActionResult ObterTodos()
        {
            try
            {
                var funcionarios = _funcionarioAplicacao.ObterTodosFuncionarios();
                return Ok(funcionarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro não tratado: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("ObterTodosPorNome/{nome}")]
        public ActionResult ObterTodosPorNome(string nome)
        {
            try
            {
                var funcionarios = _funcionarioAplicacao.ObterFuncionariosPorNome(nome);
                return Ok(funcionarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro não tratado: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("ObterFuncionarioPorCodigo/{codigo}")]
        public ActionResult ObterFuncionarioPorCodigo(string codigo)
        {
            try
            {
                var funcionarios = _funcionarioAplicacao.ObterFuncionarioPorCodigo(codigo);
                return Ok(funcionarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro não tratado: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("ObterFuncionariosAtivos")]
        public ActionResult ObterFuncionariosAtivos()
        {
            try
            {
                var funcionarios = _funcionarioAplicacao.ObterFuncionariosAtivos();
                return Ok(funcionarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro não tratado: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("CadastrarFuncionario")]
        public ActionResult CadastrarFuncionario([FromBody] FuncionarioDto dto)
        {
            try
            {
                _funcionarioAplicacao.CadastrarFuncionario(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro não tratado: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("AlterarFuncionario")]
        public ActionResult AlterarFuncionario(FuncionarioDto dto)
        {
            try
            {
                _funcionarioAplicacao.AlterarFuncionario(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro não tratado: " + ex.Message);
            }
        }

        [HttpPatch("DemitirFuncionario/{id}")]
        public ActionResult DemitirFuncionario(int id)
        {
            try
            {
                _funcionarioAplicacao.DemitirFuncionario(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro não tratado: " + ex.Message);
            }
        }
    }
}