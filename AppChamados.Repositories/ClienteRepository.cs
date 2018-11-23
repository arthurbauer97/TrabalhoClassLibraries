using System.Collections.Generic;
using System.Linq;
using AppChamados.Domain;
using AppChamados.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppChamados.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private DataContext context;

        public ClienteRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Clientes.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Cliente> GetAll()
        {
            return context.Clientes.ToList();
        }

        public Cliente GetById(int id)
        {
            return context.Clientes.SingleOrDefault(x => x.id == id);
        }

        public void Update(Cliente cliente)
        {
            context.Entry(cliente).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}