using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolaMundoForms.Catalogos;

namespace HolaMundoForms.GUI.Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            /*frmProductos Ventana = new frmProductos();
            Ventana.Show();
            Ventana.Dispose();*/
            frmProductos Ventana = new frmProductos();
            Ventana.Show();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            frmAlmacen Ventana = new frmAlmacen();
            Ventana.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClientes Ventana = new frmClientes();
            Ventana.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor Ventana = new frmProveedor();
            Ventana.Show();
        }

        private void btnsucursales_Click(object sender, EventArgs e)
        {
            frmSucursal Ventana = new frmSucursal();
            Ventana.Show();
            //Ventana.Dispose();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario Ventana = new frmUsuario();
            Ventana.Show();
        }
    }
}
