using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using hotel.controllers;
using System.Windows.Forms;

namespace hotel.models
{
    internal class Musuario
    {
        SqlCommand cmd = new SqlCommand();
        Sql con = new Sql();
        
        public bool guardar(Cusuario cusuario)
        {
            try
            {
                cmd.Connection = con.abrirConexao();
                cmd.CommandText = "INSERT INTO tb_usuario (nome_usu, apelido_usu, idade, sexo_usu, " +
                    "palavra_passe, email_usu, telefone_usu, tipo_usuario)" +
                    "VALUES(@nome, @apelido, @idade, @sexo, @password, @email, @tel, @tipo)";
                ///
                cmd.Parameters.AddWithValue("@nome", cusuario.Nome);
                cmd.Parameters.AddWithValue("@apelido", cusuario.Apelido);
                cmd.Parameters.AddWithValue("@idade", cusuario.Idade);
                cmd.Parameters.AddWithValue("@sexo", cusuario.Sexo);
                cmd.Parameters.AddWithValue("@password", cusuario.Password);
                cmd.Parameters.AddWithValue("@email", cusuario.Email);
                cmd.Parameters.AddWithValue("@tel", cusuario.Telefone);
                cmd.Parameters.AddWithValue("@tipo", cusuario.TipoUsuario);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
