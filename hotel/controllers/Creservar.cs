using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.controllers
{
    internal class Creservar
    {
        private int id;
        private int idUsuario;
        private int idQuarto;
        private int idHospede;
        private DateTime checkIn;
        private DateTime checkOut;
        private DateTime dataReserva;
        private decimal pagamentoTotal;
        private string estadoPag;

        public int Id { get => id; set => id = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdQuarto { get => idQuarto; set => idQuarto = value; }
        public int IdHospede { get => idHospede; set => idHospede = value; }
        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public DateTime DataReserva { get => dataReserva; set => dataReserva = value; }
        public decimal PagamentoTotal { get => pagamentoTotal; set => pagamentoTotal = value; }
        public string EstadoPag { get => estadoPag; set => estadoPag = value; }
    }
}
