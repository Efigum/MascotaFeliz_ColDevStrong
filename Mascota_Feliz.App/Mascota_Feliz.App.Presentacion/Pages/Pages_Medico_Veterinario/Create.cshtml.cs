using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mascota_Feliz.App.Persistencia;
using Mascota_Feliz.App.Dominio;
using Mascota_Feliz.App.Persistencia.App_Repositorios;

namespace Mascota_Feliz.App.Presentacion.Pages
{
    public class CreateModelMedico_Veterinario : PageModel
    {
        private readonly IRepositorio_Medico_Veterinario _Medico_Veterinario;
        
        public Medico_Veterinario medico_veterinario { get; set; }
        public CreateModelMedico_Veterinario(IRepositorio_Medico_Veterinario repoMedico_Veterinario)
        {
            this._Medico_Veterinario=repoMedico_Veterinario;
        }
        public void OnGet()
        {
            medico_veterinario = new Medico_Veterinario();
        }

        public IActionResult OnPost(Medico_Veterinario medico_veterinario)
        {
            _Medico_Veterinario.AddMedico_Veterinario(medico_veterinario);
            return RedirectToPage("List");
        }
    }
}
