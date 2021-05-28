using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test28Maggio.Library.Interfaces;

namespace Test28Maggio.Library
{
    public class MainBL
    {
        private readonly IClienteRepository clienteRepo;
        private readonly IOrdiniRepository ordineRepo;

        public MainBL(IClienteRepository clienteRepo)
        {
            this.clienteRepo = clienteRepo;
        }
        public MainBL(IOrdiniRepository ordineRepo)
        {
            this.ordineRepo = ordineRepo;
        }
        #region Cliente

        public bool CreaCliente(Cliente newCliente)
        {
            return clienteRepo.Add(newCliente);
        }
        public bool ModificaCliente(Cliente ClienteToBeUpdated)
        {
            return clienteRepo.Update(ClienteToBeUpdated);
        }
        public bool CancellaCliente(Cliente ClienteToBeDeleted)
        {
            return clienteRepo.Delete(ClienteToBeDeleted);
        }

        public List<Cliente> RecuperaTuttiClienti()
        {
            return clienteRepo.Fetch();
        }

        public Cliente RecuperaClienteById(int id)
        {
            return clienteRepo.Fetch().FirstOrDefault(c => c.Id == id);
        }

        #endregion

        #region Ordini

        public bool CreaOrdine(Ordine ordine)
        {
            return ordineRepo.Add(ordine);
        }

        public Ordine RecuperaOrdine(int id)
        {
            return ordineRepo.Fetch().FirstOrDefault(o => o.Id == id);
        }
        public bool ModificaOrdine(Ordine ordineToBeUpdated)
        {
            return ordineRepo.Update(ordineToBeUpdated);
        }
        public bool CancellaOrdine(Ordine ordineToBeDeleted)
        {
            return ordineRepo.Delete(ordineToBeDeleted);
        }

        public List<Ordine> RecuperaTuttiOrdini()
        {
            return ordineRepo.Fetch();
        }
        #endregion
    }
}
