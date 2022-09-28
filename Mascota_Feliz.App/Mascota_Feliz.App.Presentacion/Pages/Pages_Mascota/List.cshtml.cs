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
    public class ListModelMascota : PageModel
    {
        private readonly IRepositorio_Mascota repositorio_Mascota;
        public IEnumerable<Mascota> mascotas{ get; set; }

        public ListModelMascota()
        {
            this.repositorio_Mascota = new Repositorio_Mascota(new Mascota_Feliz.App.Persistencia.App_Repositorios.AppContext());
        }

        public void OnGet()
        {
            mascotas = repositorio_Mascota.GetAllMascotas();
        }
    }
}
