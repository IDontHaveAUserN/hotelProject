using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.controllers
{
    internal class Cpagamento
    {
        private int id;
        private int idReserva;
        private int montante;
        private string metodoPagamento;
        private int idTransacao;
        private DateTime dataPagemento;

        public int Id { get => id; set => id = value; }
        public int IdReserva { get => idReserva; set => idReserva = value; }
        public int Montante { get => montante; set => montante = value; }
        public string MetodoPagamento { get => metodoPagamento; set => metodoPagamento = value; }
        public int IdTransacao { get => idTransacao; set => idTransacao = value; }
        public DateTime DataPagemento { get => dataPagemento; set => dataPagemento = value; }
    }
}
