using System;

namespace Mascota_Feliz.App.Dominio
{
    public class Propietario_Mascota
    {
        //[key]
        public int id { get; set; }
        public string Nombres_Propietario { get; set; }
        public string Apellidos_Propietario { get; set; }
        public string Direccion_Propietario { get; set; }
        public string Telefono_Propietario { get; set; }
        public string Correo_Electronico { get; set; }
        
        
    }
}