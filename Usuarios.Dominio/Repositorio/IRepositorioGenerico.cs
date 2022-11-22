using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Dominio.Repositorio
{
    public interface IRepositorioGenerico<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entidade);

        TEntity ObterPorId(int id);

        List<TEntity> ObterTodos();

        void Alterar(TEntity entidade);

        void Remover(int id);

        int SalvaAlteracoes();
    }
}