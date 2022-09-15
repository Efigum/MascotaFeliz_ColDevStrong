using System;
using Mascota_Feliz.App.Dominio ;
using Mascota_Feliz.App.Persistencia;
using System.Collections.Generic;           // colecciones de datos, para consultas DB
using System.Linq;

namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
    public interface IRepositorio_Medico_Veterinario
    {
        //firma de métodos del CRUD

        Medico_Veterinario AddMedico_Veterinario(Medico_Veterinario medico_veterinario);

        void DeleteMedico_Veterinario(int ID_Veterinario);

        Medico_Veterinario GetMedico_Veterinario(int ID_Veterinario);

        Medico_Veterinario UpdateMedico_Veterinario(Medico_Veterinario medico_veterinario);

        IEnumerable<Medico_Veterinario> GetAllMedico_Veterinario();
    }


}
