using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAuto
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.nombre = txtNombre.Text;
                Properties.Settings.Default.apellido = txtApellido.Text;
                Properties.Settings.Default.contraseña = txtPin.Text;
                Properties.Settings.Default.monto = txtMonto.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Ingresado con exito");
                txtNombre.Text = "";
                txtApellido.Clear();
                txtPin.Clear();
                txtMonto.Clear();
            }
            catch {

            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Properties.Settings.Default.nombre;
            txtApellido.Text = Properties.Settings.Default.apellido;
            txtPin.Text = Properties.Settings.Default.contraseña;
            txtMonto.Text = Properties.Settings.Default.monto;
        }
    }
}
