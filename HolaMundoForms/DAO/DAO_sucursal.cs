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
    class DAO_sucursal
    {
        //PROPIEDADES
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsSucursales = null;

        string instruccionSQL;
        MySqlCommand commandoMySQL;
        MySqlDataAdapter dataAdapterMySQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
        public int agregarNuevoRegistro(object elNuevoRegistro)
        {
            Sucursales objetoTablaSucursale = (Sucursales)elNuevoRegistro;
            commandoMySQL = new MySqlCommand();
            dsSucursales = new DataSet();
            dataAdapterMySQL = new MySqlDataAdapter();
            commandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            instruccionSQL = "INSERT INTO puntoventa.sucursales (codigo,nombre_sucursal,direccion,responsable) " +
                "VALUES ( " + pcs(objetoTablaSucursale.Codigo) + ","
                + pcs(objetoTablaSucursale.Nombre_sucursal) + ","
                + pcs(objetoTablaSucursale.Direccion) + ","
                + pcs(objetoTablaSucursale.Responsable) + ")";

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
