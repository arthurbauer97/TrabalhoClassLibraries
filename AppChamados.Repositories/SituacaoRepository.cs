using System.Collections.Generic;
using System.Linq;
using AppChamados.Domain;
using AppChamados.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppChamados.Repositories
{
    public class SituacaoRepository : ISituacaoRepository
    {
        private DataContext context;

        public SituacaoRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Situacao situacao)
        {
            context.Situacoes.Add(situacao);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Situacoes.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Situacao> GetAll()
        {
            
            return context.Situacoes.ToList();
        }

        public Situacao GetById(int id)
        {
            return context.Situacoes.SingleOrDefault(x => x.id == id);
        }

        public void Update(Situacao situacao)
        {
            context.Entry(situacao).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}