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
    class DAO_cliente
    {
        //PROPIEDADES
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsCliente = null;

        string instruccionSQL;
        MySqlCommand commandoMySQL;
        MySqlDataAdapter dataAdapterMySQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
        public int agregarNuevoRegistro(object elNuevoRegistro)
        {
            cat_cliente objetoTablaCliente = (cat_cliente)elNuevoRegistro;
            commandoMySQL = new MySqlCommand();
            dsCliente = new DataSet();
            dataAdapterMySQL = new MySqlDataAdapter();
            commandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            instruccionSQL = "INSERT INTO puntoventa.cat_cliente (razon_social,rfc,calle,num_ext,num_int,referencia,colonia,codigo_postal,municipio,estado,tel,correo) " +
                "VALUES ( " + pcs(objetoTablaCliente.Razon_social) + ","
                + pcs(objetoTablaCliente.Rfc) + ","
                + pcs(objetoTablaCliente.Calle) + ","
                + pcs(objetoTablaCliente.Num_ext) + ","
                + pcs(objetoTablaCliente.Num_int) + ","
                + pcs(objetoTablaCliente.Referencia) + ","
                + pcs(objetoTablaCliente.Colonia) + ","
                + pcs(objetoTablaCliente.Codigo_postal) + ","
                + pcs(objetoTablaCliente.Municipio) + ","
                + pcs(objetoTablaCliente.Estado) + ","
                + pcs(objetoTablaCliente.Tel) + ","
                + pcs(objetoTablaCliente.Correo) + ")";

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
