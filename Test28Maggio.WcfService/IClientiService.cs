using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Test28Maggio.Library;

namespace Test28Maggio.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IClientiService
    {
        [OperationContract]
        List<Cliente> ListaClienti();

        [OperationContract]
        Cliente OttieniClienteById(int id);

        [OperationContract]
        bool AggiungiCliente(Cliente nuovoCliente);

        [OperationContract]
        bool ModificaCliente(Cliente updatedCliente);

        [OperationContract]
        bool EliminaCliente(Cliente deletedCliente);

    }
}

