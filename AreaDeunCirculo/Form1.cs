using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaDeunCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_radioc.Text = String.Empty;
            label4.Visible = false;
            lbl_areac.Visible = false;
            txt_radioc.Focus();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txt_radioc.Text == "")
            {
                MessageBox.Show("Necesita ingresar el radio de la circunferencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double radio, area;
                const double PI = 3.1415926535897931;
                radio = double.Parse(txt_radioc.Text);

                area = PI * Math.Pow(radio, 2);

                lbl_areac.Text = Convert.ToString(String.Format("{0:n3}", area)) + " cm";

                label4.Visible = true;
                lbl_areac.Visible = true;
            }

        }
    }
}
