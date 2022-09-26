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
    public class ListModel : PageModel
    {
        private readonly IRepositorio_Propietario_Mascota repositorio_Propietario_Mascota;
        public IEnumerable<Propietario_Mascota> propietarios{ get; set; }

        public ListModel()
        {
            this.repositorio_Propietario_Mascota = new Repositorio_Propietario_Mascota(new Mascota_Feliz.App.Persistencia.App_Repositorios.AppContext());
        }

        public void OnGet()
        {
            propietarios = repositorio_Propietario_Mascota.GetAllpropietarios();
        }
    }
}
