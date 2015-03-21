using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class Almacenes
    {
        //Propiedades
        long id;
        int num_almacen;
        string cond_producto;
        double cantidad;
        double stock_nunimo;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Num_almacen
        {
            get { return num_almacen; }
            set { num_almacen = value; }
        }

        public string Cond_producto
        {
            get { return cond_producto; }
            set { cond_producto = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double Stock_nunimo
        {
            get { return stock_nunimo; }
            set { stock_nunimo = value; }
        }

    }
}
