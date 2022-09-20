using System;

namespace Mascota_Feliz.App.Dominio
{
    public class Visita
    {
        //[key]
        public int id { get; set; }
        
        //[foreingkey ("Historia_Clinica")]
        //public int ID_Historia_Clinica { get; set; }
        public string Fecha_Visita { get; set; }
        public double Peso { get; set; }
        public double Temperatura { get; set; }
        public double Frecuencia_Cardiaca { get; set; }
        public double Frecuencia_Respiratoria { get; set; }
        public string Estado_de_animo { get; set; }
        public string Recomendaciones { get; set; }
        public Historia_Clinica historia_clinica { get; set; }

        public string Medicamentos { get; set;}

        public Visita()
        {

        }

    }
}