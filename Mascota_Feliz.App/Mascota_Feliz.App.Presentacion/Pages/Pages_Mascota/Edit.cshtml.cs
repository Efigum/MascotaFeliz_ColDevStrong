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
    public class EditModelMascota : PageModel
    {
        private readonly IRepositorio_Mascota repositorio_Mascota;
        private readonly IRepositorio_Propietario_Mascota _Propietario_Mascota = new Repositorio_Propietario_Mascota(new Persistencia.App_Repositorios.AppContext());
        private readonly IRepositorio_Medico_Veterinario _Medico_Veterinario= new Repositorio_Medico_Veterinario(new Persistencia.App_Repositorios.AppContext());

        public Mascota mascota {get; set; }
        public Propietario_Mascota propietario { get; set; }
        public Medico_Veterinario veterinario { get; set; }

        public IEnumerable<Propietario_Mascota> propietarios{ get; set; }
        public IEnumerable<Medico_Veterinario> veterinarios{ get; set; }   

        public EditModelMascota(IRepositorio_Mascota repoMascota)
        {
            this.repositorio_Mascota = new Repositorio_Mascota(new Mascota_Feliz.App.Persistencia.App_Repositorios.AppContext());
            this.repositorio_Mascota = repoMascota;
        }    
        public IActionResult OnGet(int IdMascota)
        {
            mascota = new Mascota();
            propietarios = _Propietario_Mascota.GetAllpropietarios();
            veterinarios = _Medico_Veterinario.GetAllMedico_Veterinario();
            mascota = repositorio_Mascota.GetMascota(IdMascota);
            return Page();
        }

        public IActionResult OnPost(Mascota mascota)
        {
            /*repositorio_Mascota.AddMascota(mascota);*/
            /*mascota = repositorio_Mascota.UpdateMascota(mascota);*/
            repositorio_Mascota.UpdateMascota(mascota);
            return RedirectToPage("Details");
        }
    }
}
