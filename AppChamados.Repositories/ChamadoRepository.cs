using System.Collections.Generic;
using System.Linq;
using AppChamados.Domain;
using AppChamados.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppChamados.Repositories
{
    public class ChamadoRepository : IChamadoRepository
    {
        private DataContext context;

        public ChamadoRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Chamado chamado)
        {
            chamado.situacao = context.Situacoes.Find(chamado.situacao.id);
            chamado.cliente = context.Clientes.Find(chamado.cliente.id);
            context.Chamados.Add(chamado);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Chamados.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Chamado> GetAll()
        {

            return context.Chamados.Include(s => s.situacao).Include(c => c.cliente).ToList();
        }

        public Chamado GetById(int id)
        {
            return context.Chamados.Include(s => s.situacao).Include(c => c.cliente).SingleOrDefault(x => x.id == id);
        }

        public void Update(Chamado chamado)
        {
            chamado.duracaoChamado = chamado.horaFim - chamado.horaInicio;
            chamado.situacao = context.Situacoes.Find(chamado.situacao.id);
            context.Entry(chamado).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}