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
    class DAO_usuario
    {
        //PROPIEDADES
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsUsuario = null;

        string instruccionSQL;
        MySqlCommand commandoMySQL;
        MySqlDataAdapter dataAdapterMySQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
        public int agregarNuevoRegistro(object elNuevoRegistro)
        {
            SysUsuario objetoTablaUsuario = (SysUsuario)elNuevoRegistro;
            commandoMySQL = new MySqlCommand();
            dsUsuario = new DataSet();
            dataAdapterMySQL = new MySqlDataAdapter();
            commandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            instruccionSQL = "INSERT INTO puntoventa.sysusuario (usuario,contrasenia,nombre_completo,tipo_usuario) " +
                "VALUES ( " + pcs(objetoTablaUsuario.Usuario) + ","
                + pcs(objetoTablaUsuario.Contrasenia) + ","
                + pcs(objetoTablaUsuario.Nombre_completo) + ","
                + pcs(objetoTablaUsuario.TUsuario) + " )";

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
