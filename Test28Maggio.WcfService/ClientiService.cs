using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Test28Maggio.EntityFramework.Repositories;
using Test28Maggio.Library;
using Test28Maggio.Library.Interfaces;

namespace Test28Maggio.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ClientiService : IClientiService
    {
        //Mi collego al mio BusinessLayer -> che si collega EFClienteRepository 

        MainBL businessLayer = new MainBL(new ClientiEFRepository());

        public bool AggiungiCliente(Cliente nuovoCliente)
        {
            return businessLayer.CreaCliente(nuovoCliente);
        }

        public bool EliminaCliente(Cliente deletedCliente)
        {
            return businessLayer.CancellaCliente(deletedCliente);
        }

        public List<Cliente> ListaClienti()
        {
            return businessLayer.RecuperaTuttiClienti();
        }

        public bool ModificaCliente(Cliente updatedCliente)
        {
            return businessLayer.ModificaCliente(updatedCliente);
        }

        public Cliente OttieniClienteById(int id)
        {
            return businessLayer.RecuperaClienteById(id);
        }
    }
}
