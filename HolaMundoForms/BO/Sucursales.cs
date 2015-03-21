using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class Sucursales
    {
        long id;
        string codigo;
        string nombre_sucursal;
        string direccion;
        string responsable;

        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Nombre_sucursal
        {
            get { return nombre_sucursal; }
            set { nombre_sucursal = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
