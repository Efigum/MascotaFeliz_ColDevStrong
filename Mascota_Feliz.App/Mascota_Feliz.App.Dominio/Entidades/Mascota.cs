using System;

namespace Mascota_Feliz.App.Dominio
{
    public class Mascota
    {
        public int id { get; set; }
        public string Nombre_Mascota { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set;}
        public string Color { get; set; }

        public Propietario_Mascota propietario { get; set; }
        public Medico_Veterinario medico_veterinario { get; set; }
        
        public Mascota()
        {

        }
    }
}