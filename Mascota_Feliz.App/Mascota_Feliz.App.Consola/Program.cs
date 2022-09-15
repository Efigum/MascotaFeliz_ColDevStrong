using System;

namespace Mascota_Feliz.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void AddMascota()
        {
            var mascota = new Mascota_Feliz{
                Nombre_Mascota = "Rocky",
                Especie = "Perro",
                Raza = "Schnauzer",
                Color = "Blanco",
                


            }
        }
    }
}
