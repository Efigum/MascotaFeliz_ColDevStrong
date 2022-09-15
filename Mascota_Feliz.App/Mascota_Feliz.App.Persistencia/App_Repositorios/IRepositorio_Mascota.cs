using System;
using Mascota_Feliz.App.Dominio ;
using Mascota_Feliz.App.Persistencia;
using System.Collections.Generic;           // colecciones de datos, para consultas DB
using System.Linq;

namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
    public interface IRepositorio_Mascota
    {
        //firma de métodos del CRUD

        Mascota AddMascota(Mascota mascota);

        void DeleteMascota(int id_Mascota);

        Mascota GetMascota(int id_Mascota);

        Mascota UpdateMascota(Mascota mascota);

        IEnumerable<Mascota> GetAllMascotas();
    }


}


