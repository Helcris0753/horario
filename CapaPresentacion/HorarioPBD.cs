using CapaPresentacion.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaPresentacion
{
    public class HorarioPBD
    {
        public string Dia { get; set; }
        public string Hora { get; set; }
        public int Profesor { get; set; }
        public int modalidad { get; set; }
        public void Comprobacion()
        {
            int ID=0;
            horario_seleccionadoTableAdapter horario = new horario_seleccionadoTableAdapter();
            diaTableAdapter dia = new diaTableAdapter();
            foreach (var item in dia.GetData().Where(c => c.nombre_dia == Dia))
            {
                ID = item.id_dia;
            }
            try
            {
                horario.Insert(Hora, Profesor, ID, modalidad);
            }
            catch (Exception e)
            {

                
            }
            
        }

    }
}