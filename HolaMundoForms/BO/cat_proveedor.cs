using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class cat_proveedor
    {
        long id;
        string razon_social;
        string rfc;
        string calle;
        string num_ext;
        string num_int;
        string referencia;
        string colonia;
        string codigo_postal;
        string municipio;
        string estado;
        string tel;
        string correo;


        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Razon_social
        {
            get { return razon_social; }
            set { razon_social = value; }
        }

        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public string Num_ext
        {
            get { return num_ext; }
            set { num_ext = value; }
        }

        public string Num_int
        {
            get { return num_int; }
            set { num_int = value; }
        }

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        public string Colonia
        {
            get { return colonia; }
            set { colonia = value; }
        }

        public string Codigo_postal
        {
            get { return codigo_postal; }
            set { codigo_postal = value; }
        }

        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
    }
}
