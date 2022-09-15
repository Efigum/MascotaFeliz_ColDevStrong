using System;

namespace Mascota_Feliz.App.Dominio
{
    public class Historia_Clinica
    {
        [key]
        public int ID_Historia_Clinica { get; set; }
        
        [foreingkey ("Mascota")]
        public int ID_Mascota { get; set; }

        public string Nombre_Mascota { get; set; }
        public DateTime Fecha_Apertura_HC { get; set; }
        
        
    }
}