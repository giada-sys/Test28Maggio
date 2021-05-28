using System;
using System.Collections.Generic;
using System.Text;

namespace Test28Maggio.Library.Interfaces
{
    public interface IOrdiniRepository
    {
        List<Ordine> Fetch();
        Ordine GetById(int id);
        bool Add(Ordine item);
        bool Update(Ordine item);
        bool Delete(Ordine item);
    }
}
