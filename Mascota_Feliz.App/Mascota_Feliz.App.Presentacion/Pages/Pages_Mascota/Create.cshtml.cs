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
    public class CreateModelMascota : PageModel
    {
        private readonly IRepositorio_Mascota _Mascota;
        private readonly IRepositorio_Propietario_Mascota _Propietario_Mascota = new Repositorio_Propietario_Mascota(new Persistencia.App_Repositorios.AppContext());
        private readonly IRepositorio_Medico_Veterinario _Medico_Veterinario= new Repositorio_Medico_Veterinario(new Persistencia.App_Repositorios.AppContext());
        
        public Mascota mascota { get; set; }
        public Propietario_Mascota propietario { get; set; }
        public Medico_Veterinario veterinario { get; set; }

        public IEnumerable<Propietario_Mascota> propietarios{ get; set; }
        public IEnumerable<Medico_Veterinario> veterinarios{ get; set; }    

        public CreateModelMascota(IRepositorio_Mascota repoMascota)
        {
            this._Mascota=repoMascota;
        }
        public void OnGet()
        {
            mascota = new Mascota();
            propietarios = _Propietario_Mascota.GetAllpropietarios();
            veterinarios = _Medico_Veterinario.GetAllMedico_Veterinario();
        }

        public IActionResult OnPost(Mascota mascota)
        {
            _Mascota.AddMascota(mascota);
            return RedirectToPage("Details");
        }
    }

}
