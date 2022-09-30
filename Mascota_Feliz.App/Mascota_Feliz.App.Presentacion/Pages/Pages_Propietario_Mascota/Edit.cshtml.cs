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
    public class EditModelPropietario_Mascota : PageModel
    {
        private readonly IRepositorio_Propietario_Mascota repositorio_Propietario_Mascota;

        public Propietario_Mascota propietario_mascota {get; set; }

        public EditModelPropietario_Mascota()
        {
            this.repositorio_Propietario_Mascota = new Repositorio_Propietario_Mascota(new Mascota_Feliz.App.Persistencia.App_Repositorios.AppContext());
        }
        public IActionResult OnGet(int IdPropietario_Mascota)
        {
            propietario_mascota = repositorio_Propietario_Mascota.GetPropietario_Mascota(IdPropietario_Mascota);
            return Page();
        }

        public IActionResult OnPost(Propietario_Mascota propietario_mascota)
        {
            propietario_mascota = repositorio_Propietario_Mascota.UpdatePropietario_Mascota(propietario_mascota);
           return RedirectToPage("List");
        }
    }
}
