using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Dominio.Dtos;
using Usuarios.Dominio.Servicos;

namespace Usuario.Api.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet]
        [Route("ListarUsuarios")]
        public ActionResult ListarUsuarios()
        {
            try
            {
                var usuarios = _usuarioServico.ListarTodosUsuarios();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro não tratado: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("ListarUsuariosPorNome")]
        public ActionResult ListarUsuarios(string nome)
        {
            try
            {
                var usuarios = _usuarioServico.ListarUsuariosPorNome(nome);
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro não tratado: " + ex.Message);
            }
        }

        [HttpDelete("Delete")]
        public ActionResult Deletar(int id)
        {
            try
            {
                if (id > 1000000)
                    return BadRequest("Id fora do alcance");

                _usuarioServico.DeletarUsuario(id);
                return Ok("Sucesso foi deletado");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro na operação:" + ex.Message);
            }
        }

        [HttpPut("Alterar")]
        public ActionResult Altera(int id, string nome, string codigo)
        {
            try
            {
                if (id > 1000000)
                    return BadRequest("Id fora do alcance");

                _usuarioServico.Alterar(id, nome, codigo);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro na operação:" + ex.Message);
            }
        }

        [HttpPost]
        [Route("Criar")]
        public ActionResult Criar(UsuarioDto dto)
        {
            try
            {
                _usuarioServico.InserirUsuario(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro na operação:" + ex.Message);
            }
        }
    }
}