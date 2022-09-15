using System;

namespace Mascota_Feliz.App.Dominio
{
    public class Historia_Clinica
    {
        //[key]
        public int id { get; set; }
        
        //[foreingkey ("Mascota")]
        
        public Mascota mascota { get; set; }
        public string Fecha_Apertura_HC { get; set; }
        
        
    }
}