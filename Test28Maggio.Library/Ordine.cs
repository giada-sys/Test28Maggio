using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test28Maggio.Library
{
    public class Ordine
    {
        public int Id { get; set; }
        public DateTime DataOrdine { get; set; }
        public string CodiceOrdine { get; set; }
        public string CodiceProdotto { get; set; }
        public decimal Importo { get; set; }
        public Cliente Cliente { get; set; }    // -> FK
        public int ClientiId { get; set; }
    }
}
