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
    public partial class cajero : Form
    {
        public cajero()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string contraseña = Properties.Settings.Default.contraseña;
            if (txtPassword.Text == contraseña)
            {
                tabControl1.SelectTab(1);
            }
            else
            {
                MessageBox.Show("Pin incorrecto, intente de nuevo", "Error");
                txtPassword.Clear();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "9";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string ultima = txtPassword.Text.Substring(0, txtPassword.Text.Length - 1);
            txtPassword.Text = ultima;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            lblBal.Text = Properties.Settings.Default.monto;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            txtPassword.Clear();
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            Retiro(2000);
        }

        private void Retiro (Double cantidad)
        {
            double balance = double.Parse(sett.Text);

            //para validar si se tiene balance suficiente
            if (balance >= cantidad)
            {
                double b = balance - cantidad;
                Properties.Settings.Default.monto = Convert.ToString(b);
                Properties.Settings.Default.Save();
                MessageBox.Show("Retire su dinero", "Retiro de efectivo");
            }
            else
            {
                MessageBox.Show("No pose dinero suficiente", "Error");
            }
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            Retiro(1000);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            Retiro(500);
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            Retiro(200);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            Retiro(100);
        }

        private void btnOtras_Click(object sender, EventArgs e)
        {
            //dentro del boton de otras
            string request = Microsoft.VisualBasic.Interaction.InputBox("Cantidad que sea retirar");
            double dinero = double.Parse(request);
            Retiro(dinero);
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            sett.Text = Properties.Settings.Default.monto;
           
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            
        }

        private void Deposito(Double cantidad)
        {
            double balance = double.Parse(dep.Text);

            //para validar si se tiene balance suficiente
           // if (balance >= cantidad)
            //{
                double b = balance + cantidad;
                Properties.Settings.Default.monto = Convert.ToString(b);
                Properties.Settings.Default.Save();
                MessageBox.Show("Deposito realizado", "Deposito de efectivo");
            //}
           /* else
            {
                MessageBox.Show("No se pudo completar la transaccion", "Error");
            }*/
        }

        private void btnAce_Click(object sender, EventArgs e)
        {
            Deposito(double.Parse(txtDep.Text));
            dep.Text = Properties.Settings.Default.monto;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            lblBal.Text = Properties.Settings.Default.monto;
        }

        private void lblBal_Click(object sender, EventArgs e)
        {

        }
    }
    }
