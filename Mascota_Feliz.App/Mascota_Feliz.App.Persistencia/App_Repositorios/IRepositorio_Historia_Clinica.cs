using System;
using Mascota_Feliz.App.Dominio ;
using Mascota_Feliz.App.Persistencia;
using System.Collections.Generic;           // colecciones de datos, para consultas DB
using System.Linq;

namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
    public interface IRepositorio_Historia_Clinica
    {
        //firma de métodos del CRUD

        Historia_Clinica AddHistoria_Clinica(Historia_Clinica historia_clinica);

        void DeleteHistoria_Clinica(int ID_Historia_Clinica);

        Historia_Clinica GetHistoria_Clinica(int ID_Historia_Clinica);

        Historia_Clinica UpdateHistoria_Clinica(Historia_Clinica historia_clinica);

        IEnumerable<Historia_Clinica> GetAllHistoria_Clinica();
    }


}
