using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoForms
{
    public partial class frmPrincipal : Form
    {
        //PROPIEDADES DE LA CLASE
        public double numero1, numero2, suma;


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            numero1 = (double)nudNumero1.Value;
            numero2 = Convert.ToDouble(nudNumero2.Value);


            switch (cmbOperaciones.SelectedIndex)
            {
                case 0:
                    suma = numero1 + numero2;
                    break;
                case 1:
                    suma = numero1 - numero2;
                    break;
                case 2:
                    suma = numero1 * numero2;
                    break;
                case 3:

                    suma = numero1 / numero2;
                    break;
            }



            MessageBox.Show("El resultado es: " + suma);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbOperaciones.SelectedIndex = 0;
        }

        private void cmbOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperaciones.SelectedIndex == 3)
            {
                if(nudNumero2.Value == 0){
                    btnSumar.Enabled = false;
                }
            }
        }

        private void nudNumero2_ValueChanged(object sender, EventArgs e)
        {
            if (cmbOperaciones.SelectedIndex == 3)
            {
                if (nudNumero2.Value == 0)
                {
                    btnSumar.Enabled = false;
                }
                else
                {
                    btnSumar.Enabled = true;
                }
            }
        }

        private void nudNumero1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
