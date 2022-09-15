using System;

namespace Mascota_Feliz.App.Dominio
{
    public class Medico_Veterinario
    {
        [key]
        public int ID_Veterinario { get; set; }
        public string Nombre_Veterinario { get; set; }
        public string Apellidos_Veterinario { get; set; }
        public string Direccion_Veterinario { get; set; }
        public string Telefeno_Veterinario { get; set; }
        public string Tarjeta_Profesional { get; set; }
        public Medico_Veterinario medico_veterinario { get; set; }
        
    }
}