using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.controllers
{
    internal class Cquarto
    {
        private int id;
        private int numQuarto;
        private string tipoQuarto;
        private decimal precoPorNoite;
        private string descri;
        private string availabilidade;

        public int Id { get => id; set => id = value; }
        public int NumQuarto { get => numQuarto; set => numQuarto = value; }
        public string TipoQuarto { get => tipoQuarto; set => tipoQuarto = value; }
        public decimal PrecoPorNoite { get => precoPorNoite; set => precoPorNoite = value; }
        public string Descri { get => descri; set => descri = value; }
        public string Availabilidade { get => availabilidade; set => availabilidade = value; }
    }
}
