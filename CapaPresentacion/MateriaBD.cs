using CapaPresentacion.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaPresentacion
{
    public class MateriaBD
    {
        public string Nombre { get; set; }
        public bool comprobar(int ID)
        {
            bool r= false;
            profesorTableAdapter profesor = new profesorTableAdapter();
            foreach (var item in profesor.GetData().Where(C=> C.id_profesor == ID))
            {
                Nombre = item.nombre_profesor;
                r = true;
            }
            return r;
        }
        public bool insertar(int ID,string Asi, int Mod)
        {
            bool r = false;
            seccionTableAdapter seccion = new seccionTableAdapter();
            try
            {
                seccion.inserccion_seccion(ID, Asi, Mod);
                r = true;
            }
            catch (Exception e)
            {
                r = false;
            }
           
            return r;
        }
    }
}