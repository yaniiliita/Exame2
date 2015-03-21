using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolaMundoForms.DB;
using HolaMundoForms.GUI.Menu;

namespace HolaMundoForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Cambio

        }

        //Revisar si el usuario esta registrado
        public void revisa_usuario_registrado()
        {

        }

        public bool verifica_usuario_password()
        {
            bool validar_usuario = true;

            ConexionMYSQL objetoODBC = new ConexionMYSQL();

            //CREAMOS LA SENTENCIA SQL QUE ME DEVUELVE LOS DATOS QUE CONCUERDAN CON LA CONDICION "WHERE"
            string SentenciaSQL;
            SentenciaSQL = "select usuario from sysusuario where usuario= '" + txtUsuario.Text + "' and contrasenia = '" + txtPassword.Text + "'";
            //VALIDAR QUE LA COMBINACION DE USUARIO Y CONTRASEÑA EXISTA
            if (!objetoODBC.MYSQL_EXISTE_DATO(SentenciaSQL))
            {
                //SI NO EXISTE ESA COMBINACION, LOS DATOS SON INCORRECTOS
                MessageBox.Show("DATOS DE ACCESO INCORRECTOS!", "ERROR");
                validar_usuario = false;
                return validar_usuario;
            }

            return validar_usuario;
            //validar que el usuario no este en blanco
            
            /*if (string.IsNullOrEmpty(this.txtUsuario.Text.Trim()))
            {
                MessageBox.Show("Ingrese un nombre de usuario");
                validar_usuario = false;
                return validar_usuario;
            }

            //validar que el usuario no este en blanco
            if (string.IsNullOrEmpty(this.txtPassword.Text.Trim()))
            {
                MessageBox.Show("Ingrese una contraseña");
                validar_usuario = false;
                return validar_usuario;
            }
            
            //validar que el usuario no este en blanco
            if (this.txtUsuario.Text.Trim() != "ADMIN")
            {
                MessageBox.Show("Datos invalidos");
                validar_usuario = false;
                return validar_usuario;
            }

            //validar que el usuario no este en blanco
            if (this.txtPassword.Text.Trim() != "2015")
            {
                MessageBox.Show("Datos invalidos");
                validar_usuario = false;
                return validar_usuario;
            }
            return validar_usuario;*/
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.verifica_usuario_password())
            {
                this.Hide();

                MessageBox.Show("Felicidades ya vaz a ir al menu principal");

                FrmMenu Ventana = new FrmMenu();

                Ventana.Show();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == 13)
            {

            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

            }*/

            if(e.KeyChar == (char)Keys.Space){
                e.Handled = true;
            }
        }

        private void bntOtroUsuario_Click(object sender, EventArgs e)
        {
            frmRegistro Ventana = new frmRegistro();
            Ventana.ShowDialog();
            Ventana.Dispose();
        }
    }
}
