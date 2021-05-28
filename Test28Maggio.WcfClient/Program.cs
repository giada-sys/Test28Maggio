using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test28Maggio.EntityFramework;
using Test28Maggio.WcfClient.ClienteServiceReference;

namespace Test28Maggio.WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientiServiceClient service = new ClientiServiceClient();

            #region Add
            //Cliente c = new Cliente
            //{
            //    Nome = "Giada",
            //    Cognome = "Lomasti",
            //    CodiceCliente = "10000"
            //};
            //Cliente c1 = new Cliente
            //{
            //    Nome = "Giulia",
            //    Cognome = "Rossi",
            //    CodiceCliente = "20000"
            //};
            //Cliente c2 = new Cliente
            //{
            //    Nome = "Maicol",
            //    Cognome = "Solari",
            //    CodiceCliente = "30000"
            //};

            //service.AggiungiCliente(c);
            //service.AggiungiCliente(c1);
            //service.AggiungiCliente(c2);

            #endregion

            #region Lista Clienti

            //Console.WriteLine(" ----------Lista Clienti----------");

            //List<Cliente> list = service.ListaClienti();
            //foreach (var current in list)
            //    Console.WriteLine($"{current.Nome} {current.Cognome}\t{current.CodiceCliente}");
            //Console.ReadLine();

            //#endregion

            //#region Ricerca cliente per ID

            //Console.WriteLine(" ----------Cliente ID----------");

            //var cliente = service.OttieniClienteById(2);
            //Console.WriteLine($"{cliente.Nome} {cliente.Cognome}\t{cliente.CodiceCliente}");

            #endregion

            #region Update Cliente

            //Cliente clienteDaModificare = new Cliente
            //{
            //    Id = 2,
            //    Nome = "Marco",
            //    Cognome = "Solari",
            //    CodiceCliente = "3000"
            //};
            //service.ModificaCliente(clienteDaModificare);

            #endregion

            #region Ricerca cliente per ID

            //Console.WriteLine(" ----------Cliente per ID----------");

            //var clientePerID = service.OttieniClienteById(2);
            //Console.WriteLine($"{clientePerID.Nome} {clientePerID.Cognome}\t{clientePerID.CodiceCliente}");
            //Console.ReadLine();

            #endregion

            #region Cancella Cliente
            
            //Console.WriteLine(" ----------Elimina Cliente----------");
            //var clientePerID = service.OttieniClienteById(2);
            //service.EliminaCliente(clientePerID);

            //List<Cliente> list = service.ListaClienti();
            //foreach (var current in list)
            //    Console.WriteLine($"{current.Nome} {current.Cognome}\t{current.CodiceCliente}");
            //Console.ReadLine();

            #endregion
        }
    }
}
