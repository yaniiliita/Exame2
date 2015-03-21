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
    class DAO_proveedor
    {
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsProveedor = null;

        string instruccionSQL;
        MySqlCommand commandoMySQL;
        MySqlDataAdapter dataAdapterMySQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
        public int agregarNuevoRegistro(object elNuevoRegistro)
        {
            cat_proveedor objetoTablaProveedor = (cat_proveedor)elNuevoRegistro;
            commandoMySQL = new MySqlCommand();
            dsProveedor = new DataSet();
            dataAdapterMySQL = new MySqlDataAdapter();
            commandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            instruccionSQL = "INSERT INTO puntoventa.cat_cliente (razon_social,rfc,calle,num_ext,num_int,referencia,colonia,codigo_postal,municipio,estado,tel,correo) " +
                "VALUES ( " + pcs(objetoTablaProveedor.Razon_social) + ","
                + pcs(objetoTablaProveedor.Rfc) + ","
                + pcs(objetoTablaProveedor.Calle) + ","
                + pcs(objetoTablaProveedor.Num_ext) + ","
                + pcs(objetoTablaProveedor.Num_int) + ","
                + pcs(objetoTablaProveedor.Referencia) + ","
                + pcs(objetoTablaProveedor.Colonia) + ","
                + pcs(objetoTablaProveedor.Codigo_postal) + ","
                + pcs(objetoTablaProveedor.Municipio) + ","
                + pcs(objetoTablaProveedor.Estado) + ","
                + pcs(objetoTablaProveedor.Tel) + ","
                + pcs(objetoTablaProveedor.Correo) + ")";

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
