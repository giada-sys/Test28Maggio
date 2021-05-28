using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test28Maggio.Library;
using Test28Maggio.Library.Interfaces;

namespace Test28Maggio.EntityFramework.Repositories
{
    public class ClientiEFRepository : IClienteRepository
    {
        Context ctx = new Context();
        public bool Add(Cliente newCliente)
        {
            try
            {
                ctx.Clienti.Add(newCliente);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Cliente cliente)
        {
            try
            {
                ctx.Clienti.Remove(cliente);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Cliente> Fetch()
        {
            try
            {
                var clienti = ctx.Clienti.ToList();
                return clienti;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Cliente GetById(int id)
        {
            try
            {
                var cliente = ctx.Clienti.FirstOrDefault(c => c.Id == id);
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(Cliente item)
        {
            try
            {
                ctx.Clienti.Update(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
