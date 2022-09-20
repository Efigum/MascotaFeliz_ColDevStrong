using System;
using Mascota_Feliz.App.Persistencia;
using Mascota_Feliz.App.Dominio;
using Mascota_Feliz.App.Persistencia.App_Repositorios;

namespace Mascota_Feliz.App.Consola
{
    class Program
    {
        private static IRepositorio_Propietario_Mascota _repoPropietario_Mascota = new Repositorio_Propietario_Mascota(new Persistencia.AppContext());
        //private static IRepositorio_Mascota _repoMascota = new Repositorio_Mascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DB Mascota_Feliz!");
            //AddPropietario_Mascota();
            GetPropietario_Mascota(1);
        }

        /* private static void AddMascota()
        {
            var propietario = new Propietario_Mascota
            {
                Nombres_Propietario = "Mery",
                Apellidos_Propietario = "Hueso",
                Direccion_Propietario = "Carrera 1 N. 23-90",
                Telefono_Propietario = "3501234567",
                Correo_Electronico = "asd@gmaill.com"
            };

            var medico_veterinario = new Medico_Veterinario
            {
                Nombre_Veterinario = "Camilo",
                Apellidos_Veterinario = "Rodriguez",
                Direccion_Veterinario = "Carrera 50 N. 88-90",
                Telefono_Veterinario = "3507654321",
                Tarjeta_Profesional = "QAZ1234566"
            };


            var mascota = new Mascota
            {
                Nombre_Mascota = "Rocky",
                Especie = "Perro",
                Raza = "Schnauzer",
                Color = "Blanco",
                propietario = propietario,
                medico_veterinario = medico_veterinario

            };*/
            private static void AddPropietario_Mascota()
            {
            var propietario = new Propietario_Mascota
            {
                Nombres_Propietario = "Mery",
                Apellidos_Propietario = "Hueso",
                Direccion_Propietario = "Carrera 1 N. 23-90",
                Telefono_Propietario = "3501234567",
                Correo_Electronico = "asd@gmaill.com"
            };

            _repoPropietario_Mascota.AddPropietario_Mascota(propietario);
            }
            private static void GetPropietario_Mascota(int id)
            {
            var propietario = _repoPropietario_Mascota.GetPropietario_Mascota(id);
             Console.WriteLine(propietario.Nombres_Propietario + " " + propietario.Apellidos_Propietario);
            //_repoPropietario_Mascota.GetPropietario_Mascota(propietario);
           // _repoMascota.AddMascota(mascota);

            }
    }
}
