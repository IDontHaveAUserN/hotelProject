using hotel.controllers;
using hotel.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;


namespace hotel.views
{
    public partial class Vusuario : Form
    {
        ToastContentBuilder toastMsg = new ToastContentBuilder();
        Musuario musuario = new Musuario();
        Cusuario cusuario = new Cusuario();
        public Vusuario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void salvar()
        {
            cusuario.Nome = txtNome.Text;
            cusuario.Apelido = txtApelido.Text;
            cusuario.Idade = int.Parse(txtIdade.Text);
            cusuario.Sexo = txtSexo.Text;
            cusuario.Password = txtPasse.Text;
            cusuario.Email = txtEmail.Text;
            cusuario.Telefone = int.Parse(txtTel.Text);
            cusuario.TipoUsuario = txtTipo.Text;

            

            if (musuario.guardar(cusuario))
            {
                MessageBox.Show("Guardado com sucesso", "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toastMsg.AddText("HELLO").Show();
            }
            else
            {
                MessageBox.Show("Falha ao guardar", "FALHA!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }
    }
}
