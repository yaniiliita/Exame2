using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class SysUsuario
    {
        //PROPIEDADES
        long id;
        string usuario;
        string contrasenia;
        string nombre_completo;
        string tipo_usuario;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre_completo
        {
            get { return nombre_completo; }
            set { nombre_completo = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string TUsuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }
    }
}
