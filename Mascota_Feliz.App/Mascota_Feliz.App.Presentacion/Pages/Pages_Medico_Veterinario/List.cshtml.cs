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
    public class ListModelMedico_Veterinario : PageModel
    {
        private readonly IRepositorio_Medico_Veterinario repositorio_Medico_Veterinario;
        public IEnumerable<Medico_Veterinario> veterinarios{ get; set; }

        public ListModelMedico_Veterinario()
        {
            this.repositorio_Medico_Veterinario = new Repositorio_Medico_Veterinario(new Mascota_Feliz.App.Persistencia.App_Repositorios.AppContext());
        }

        public void OnGet()
        {
            veterinarios = repositorio_Medico_Veterinario.GetAllMedico_Veterinario();
        }
    }
}

