using System;

namespace Mascota_Feliz.App.Dominio
{
    public class Visita
    {
        [key]
        public int ID_Visita { get; set; }
        
        [foreingkey ("Historia_Clinica")]
        public int ID_Historia_Clinica { get; set; }
        public DateTime Fecha_Visita { get; set; }
        public int Peso { get; set; }
        public float Temperatura { get; set; }
        public float Frecuencia_Cardiaca { get; set; }
        public float Frecuencia_Respiratoria { get; set; }
        public string Estado_de_animo { get; set; }
        public string Recomendaciones { get; set; }
        public Historia_Clinica historia_clinica { get; set; }

    }
}