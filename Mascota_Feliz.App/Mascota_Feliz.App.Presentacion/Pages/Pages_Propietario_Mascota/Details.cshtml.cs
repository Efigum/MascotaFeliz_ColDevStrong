using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mascota_Feliz.App.Persistencia;
using Mascota_Feliz.App.Dominio;
using Mascota_Feliz.App.Persistencia.App_Repositorios;

namespace Mascota_Feliz.App.Presentacion.Pages
{
    public class DetailsModelPropietario_Mascota : PageModel
    {
        private readonly IRepositorio_Propietario_Mascota _Propietario_Mascota;
        
        public Propietario_Mascota propietario { get; set; }
        public DetailsModelPropietario_Mascota(IRepositorio_Propietario_Mascota repoPropietario_Mascota)
        {
            this._Propietario_Mascota=repoPropietario_Mascota;
        }
        public void OnGet()
        {
            propietario = new Propietario_Mascota();
        }

        public IActionResult OnPost(Propietario_Mascota propietario)
        {
            _Propietario_Mascota.AddPropietario_Mascota(propietario);
            return RedirectToPage("List");
        }
    }
}
