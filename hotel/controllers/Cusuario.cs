using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.controllers
{
    internal class Cusuario
    {
        private int id;
        private string nome;
        private string apelido;
        private int idade;
        private string sexo;
        private string password;
        private string email;
        private int telefone;
        private string tipoUsuario;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Apelido { get => apelido; set => apelido = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
    }
}
