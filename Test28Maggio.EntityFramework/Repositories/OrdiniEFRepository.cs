using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test28Maggio.Library;
using Test28Maggio.Library.Interfaces;

namespace Test28Maggio.EntityFramework.Repositories
{
    public class OrdiniEFRepository : IOrdiniRepository
    {
        Context ctx = new Context();
        public bool Add(Ordine newOrdine)
        {
            try
            {
                ctx.Ordini.Add(newOrdine);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Ordine ordine)
        {
            try
            {
                ctx.Ordini.Remove(ordine);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Ordine> Fetch()
        {
            try
            {
                var ordini = ctx.Ordini.ToList();
                return ordini;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Ordine GetById(int id)
        {
            try
            {
                var ordine = ctx.Ordini.FirstOrDefault(c => c.Id == id);
                return ordine;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(Ordine item)
        {
            try
            {
                ctx.Ordini.Update(item);
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
