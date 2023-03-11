using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using CapaPresentacion.DataSet1TableAdapters;

namespace CapaPresentacion
{
    public class LoginBD
    {
        //Almacena el ID del profesor.
        public int Nombre { get; set; }
        //Almacena si el usuario es coordinador.
        public int Coordinador { get; set; }
        //Función que comprueba si el usuario existe validando su ID y contraseña.
        public bool comprobar(int ID, string Password)
        {
            bool r = false;
            //Llama a la tabla de la base de datos.
            profesorTableAdapter profesor = new profesorTableAdapter();
            //Validación del ID y contraseña ingresada por el usuario con la base de datos.
            foreach (var item in profesor.GetData().Where(c=> c.id_profesor == ID && c.contraseña_profesor == Password))
            {
                Nombre = item.id_profesor;
                Coordinador = item.coordinador_status;
                r = true;
            }
            return r;
        }
    }

    
    
    
    
    
}