using hotel.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class Vmain : Form
    {
        public Vmain()
        {
            InitializeComponent();
            //testar();
        }

        /*private void testar()
        {
            try
            {
                Sql sqltest = new Sql();
                sqltest.abrirConexao();
            } catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
             
        }*/

        private void quartosMenuItem_Click(object sender, EventArgs e)
        {
            Vquarto vquarto = new Vquarto();
            vquarto.ShowDialog();
        }

        private void reservaMenuItem_Click(object sender, EventArgs e)
        {
            Vreservar reservacao = new Vreservar();
            reservacao.ShowDialog();
        }

        private void hosMenuItem_Click(object sender, EventArgs e)
        {
            Vhospede vhospede = new Vhospede();
            vhospede.ShowDialog();
        }

        private void Vmain_Load(object sender, EventArgs e)
        {

        }

        private void hosMenuUsuario_Click(object sender, EventArgs e)
        {
            Vusuario vusuario = new Vusuario();
            vusuario.ShowDialog();
        }
    }
}
