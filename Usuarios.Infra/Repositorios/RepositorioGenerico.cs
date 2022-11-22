using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Dominio.Repositorio;
using Usuarios.Infra.Context;

namespace Usuarios.Infra.Repositorios
{
    public abstract class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        protected readonly MvcContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public RepositorioGenerico(MvcContext contexto)
        {
            Db = contexto;
            DbSet = Db.Set<TEntity>();
        }

        public void Adicionar(TEntity entidade)
        {
            DbSet.Add(entidade);
        }

        public void Alterar(TEntity entidade)
        {
            DbSet.Update(entidade);
        }

        public TEntity ObterPorId(int id)
        {
            return DbSet.Find(id);
        }

        public List<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public void Remover(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SalvaAlteracoes()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}