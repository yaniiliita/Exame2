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
    class DAO_almacen
    {
        //PROPIEDADES
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsAlmacen = null;

        string instruccionSQL;
        MySqlCommand commandoMySQL;
        MySqlDataAdapter dataAdapterMySQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
        public int agregarNuevoRegistro(object elNuevoRegistro)
        {
            Almacenes objetoTablaAlmacen = (Almacenes)elNuevoRegistro;
            commandoMySQL = new MySqlCommand();
            dsAlmacen = new DataSet();
            dataAdapterMySQL = new MySqlDataAdapter();
            commandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            instruccionSQL = "INSERT INTO puntoventa.almacen (num_almacen,cod_producto,cantidad,stock_minimo) " +
                "VALUES ( " + objetoTablaAlmacen.Num_almacen.ToString() + ","
                + pcs(objetoTablaAlmacen.Cond_producto) + ","
                + objetoTablaAlmacen.Cantidad.ToString() + ","
                + objetoTablaAlmacen.Stock_nunimo.ToString() + " )";

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
