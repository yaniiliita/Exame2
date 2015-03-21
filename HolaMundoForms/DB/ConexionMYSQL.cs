using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HolaMundoForms.DB
{
    class ConexionMYSQL
    {
        public MySqlConnection miConectorNET = new MySqlConnection();

        public ADODB.Connection miConectorODBC = new ADODB.Connection();

        public string MYSQL_CONECTION_NET = "Server=localhost; user ID=vendedor; Password=vendedor; Persist Security Info=true; Database=puntoventa;";

        public string MYSQL_CONECTION_ODBC = "Driver={MySQL ODBC 5.3 ANSI Driver};Server=localhost;"+
            " User=vendedor; Password=vendedor; Database=puntoventa; Option=3;";


        //metodo constructor
        public ConexionMYSQL()
        { }

        //Metodo para conectarnos cpon la libreria MYSQL.DATA
        public void establecerConexionNET()
        {
            miConectorNET.ConnectionString = MYSQL_CONECTION_NET;
            miConectorNET.Open();
        }

        public void cerrarConexionNET()
        {
            miConectorNET.Close();
        }

        //Metodo para conectarnos con la libreria ADODB
        public void establecerConexionODBC()
        {
            miConectorODBC.ConnectionString = MYSQL_CONECTION_ODBC;
            miConectorODBC.Open(null, null, null, 0);
        }

        public void cerrarConexionODBC()
        {
            miConectorODBC.Close();
        }

        //Metodo que verifique si existe una informacion en la tabla de la base de datos
        public bool MYSQL_EXISTE_DATO(string instruccionSQL)
        {
            this.establecerConexionODBC();

            bool functionReturnValue = false;
            ADODB.Recordset rst = new ADODB.Recordset();
            rst.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            try
            {
                rst.Open(instruccionSQL, this.MYSQL_CONECTION_ODBC, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
                if (!rst.EOF)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
                rst.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            rst = null;
            this.cerrarConexionODBC();
            return functionReturnValue;
        }
    }
}