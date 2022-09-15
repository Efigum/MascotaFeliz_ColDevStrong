using System;

namespace Mascota_Feliz.App.Dominio
{
    public class Mascota
    {
        [key]
        public int ID_Mascota { get; set; }
        public string Nombre_Mascota { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set;}
        public string Color { get; set; }

        [foreingkey ("Propietario_Mascota")]
        public int ID_Propietario { get; set; }

        [foreingkey ("Medico_Veterinario")]
        public int ID_Veterinario { get; set; }
        public Propietario_Mascota propietario;
        public Veterinario veterinario { get; set;}
        
    }
}