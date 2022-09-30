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
    public class DeleteModelMascota : PageModel
    {
        private readonly IRepositorio_Mascota repositorio_Mascota;

        public Mascota mascota {get; set; }

        public DeleteModelMascota()
        {
            this.repositorio_Mascota = new Repositorio_Mascota(new Mascota_Feliz.App.Persistencia.App_Repositorios.AppContext());
        }
        public IActionResult OnGet(int IdMascota)
        {
            mascota = repositorio_Mascota.GetMascota(IdMascota);
            return Page();
        }

        public IActionResult OnPost(Mascota mascota)
        {
            repositorio_Mascota.DeleteMascota(mascota);
            return RedirectToPage("List");
        }
       
    }
}
