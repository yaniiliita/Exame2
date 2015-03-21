using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class Producto
    {
        long id;
        string cod_producto;
        string nombre;
        double precio;
        double costo;
        DateTime fecha_ingreso;

        public DateTime Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Cod_producto
        {
            get { return cod_producto; }
            set { cod_producto = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
