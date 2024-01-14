using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.controllers
{
    internal class Chospede
    {
        private int id;
        private string nome;
        private string apelido;
        private string sexo;
        private string email;
        private int telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Apelido { get => apelido; set => apelido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Email { get => email; set => email = value; }
        public int Telefone { get => telefone; set => telefone = value; }
    }
}
