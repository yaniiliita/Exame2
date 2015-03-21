using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolaMundoForms.BO;
using HolaMundoForms.DAO;

namespace HolaMundoForms.Catalogos
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private bool HAY_DATOS_VACIOS_EN_TEXTBOXES()
        {
            bool HAY_TEXTBOX_VACIOS = false;
            foreach (Control ctrl in this.Controls) //PARA CADA CONTROL DENTRO DEL FORMULARIO             
            {
                if ((object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox))) & (!HAY_TEXTBOX_VACIOS))
                {
                    if (ctrl.Text.Trim() == String.Empty)
                    {
                        HAY_TEXTBOX_VACIOS = true;
                        break;
                    }
                }
            }
            return HAY_TEXTBOX_VACIOS;
        }
        public void VALIDA_CARACTERES_EN_TEXTBOXES(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\'': //COMILLA SENCILLA                     
                    e.Handled = true;
                    break;
                case '\\': // DIAGONAL INVERTIDA
                    e.Handled = true;
                    break;
                case 'à':
                    e.Handled = true;
                    break;
                case 'È':
                    e.Handled = true;
                    break;
                case '`':
                    e.Handled = true;
                    break;
                case '´':
                    e.Handled = true;
                    break;
                case '&':
                    e.Handled = true;
                    break;
                case 'û':
                    e.Handled = true;
                    break;
                case '^':
                    e.Handled = true;
                    break;
                case '|':
                    e.Handled = true;
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }
        public void ENVIAR_DATOS_NUEVO_REGISTRO()
        {
            int i = 0;
            //NUEVO OBJETO DE LA CLASE PRODUCTO de la carpeta BO (Cat_productos)
            cat_proveedor oProveedor = new cat_proveedor();
            //Nuevo OBJETO DE LA CLASE DAO_producto de la carpeta DAO
            DAO_proveedor oProveedorDAO = new DAO_proveedor();
            //LLENAR PROPIEDADES DEL OBJETO PRODUCTO, CON CADA DATO CAPTURADO EN LA PANTALLA             
            //Objeto.Propiedad = Pantalla.ComponenteVisual.Valor;  
            oProveedor.Razon_social = this.txtRazonSocial.Text.Trim();
            oProveedor.Rfc = this.txtRfc.Text.Trim();
            oProveedor.Calle = this.txtCalle.Text.Trim();
            oProveedor.Num_ext = this.txtNumExt.Text.Trim();
            oProveedor.Num_int = this.txtNumInt.Text.Trim();
            oProveedor.Referencia = this.txtReferencia.Text.Trim();
            oProveedor.Colonia = this.txtColonia.Text.Trim();
            oProveedor.Estado = this.txtEstado.Text.Trim();
            oProveedor.Codigo_postal = this.txtCodPostal.Text.Trim();
            oProveedor.Municipio = this.txtMunicipio.Text.Trim();
            oProveedor.Tel = this.txtTelefono.Text.Trim();
            oProveedor.Correo = this.txtEmail.Text.Trim();
            //LLAMAMOS AL METODO DE LA CLASE DAO QUE HACE EL INSERT, le enviamos como parametro el objeto oProducto que              
            //ya llenamos con los valores de la pantalla             
            i = oProveedorDAO.agregarNuevoRegistro(oProveedor);
            //VERIFICAMOS SI SE HA EJECUTADO CORRECTAMENTE LA ACCION SOLICITADA             
            if (i == 0)
            {
                MessageBox.Show("El proceso no se pudo realizar");
            }
            else
            {
                MessageBox.Show("El proceso se genero con éxito");
            }
            //MATAMOS A LOS OBJETOS UTILIZADOS             
            oProveedor = null;
            oProveedorDAO = null;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (HAY_DATOS_VACIOS_EN_TEXTBOXES())
            //SI FALTA POR CAPTURAR UN DATO             
            {
                MessageBox.Show("Hay datos sin capturar, favor de revisar su pantalla de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Desea continuar y agregar un nuevo registro?.", "Agregar Nuevo Registro", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        ENVIAR_DATOS_NUEVO_REGISTRO();
                        this.Close();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}
