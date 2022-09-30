using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mascota_Feliz.App.Dominio;
using Mascota_Feliz.App.Persistencia;
using Mascota_Feliz.App.Persistencia.App_Repositorios;

namespace Mascota_Feliz.App.Presentacion.Pages
{
    public class SearchModelMascota : PageModel
    {
        private readonly IRepositorio_Mascota repositorio_Mascota;

        /*public Mascota mascota{ get; set; }*/

        public IEnumerable<Mascota> mascotas{ get; set; }

        public SearchModelMascota()
        {
            this.repositorio_Mascota = new Repositorio_Mascota(new Mascota_Feliz.App.Persistencia.App_Repositorios.AppContext());
        }

/*
        public SearchModelMascota(IRepositorio_Mascota repositorio_Mascota)
        {
            this.repositorio_Mascota = repositorio_Mascota;
        }
*/
        public void OnGet(string Nombre_Mascota)
        {
            Console.WriteLine(Nombre_Mascota);
            mascotas = repositorio_Mascota.GetMascotaporNombre(Nombre_Mascota);

           /* if (mascota == null)
            {
                return RedirectToPage ("./NotFound");
            }
            else
            return Page();*/
        }


    }
}
