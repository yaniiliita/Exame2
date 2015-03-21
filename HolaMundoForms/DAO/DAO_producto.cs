using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using HolaMundoForms.DB;
using System.Data;
using HolaMundoForms.BO;

namespace HolaMundoForms.DAO
{
    class DAO_producto
    {
        //PROPIEDADES
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsProductos = null;

        string instruccionSQL;
        MySqlCommand commandoMySQL;
        MySqlDataAdapter dataAdapterMySQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
        public int agregarNuevoRegistro(object elNuevoRegistro)
        {
            Producto objetoTablaProducto = (Producto)elNuevoRegistro;
            commandoMySQL = new MySqlCommand();
            dsProductos = new DataSet();
            dataAdapterMySQL = new MySqlDataAdapter();
            commandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            instruccionSQL = "INSERT INTO puntoventa.producto (cod_producto,nombre,precio,costo,fecha_ingreso) " +
                "VALUES ( " + pcs(objetoTablaProducto.Cod_producto) + ","
                + pcs(objetoTablaProducto.Nombre) + ","
                + objetoTablaProducto.Precio.ToString() + ","
                + objetoTablaProducto.Costo.ToString() + ",CURDATE() )";

            commandoMySQL.CommandText = instruccionSQL;
            int resultadodelComando = commandoMySQL.ExecuteNonQuery();
            if (resultadodelComando <= 0)             
            {                 
                return 0; //HAY UN ERROR
            }  
            return 1; 
        }

        public String pcs(string Valor)
        {
            return "'" + Valor + "'";
        }
    }
}
