using System;
using System.Collections.Generic;

namespace Test28Maggio.Library.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> Fetch();
        Cliente GetById(int id);
        bool Add(Cliente item);
        bool Update(Cliente item);
        bool Delete(Cliente item);
    }
}
