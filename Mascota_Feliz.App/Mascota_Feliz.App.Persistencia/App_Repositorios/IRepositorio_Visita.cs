using System;
using Mascota_Feliz.App.Dominio ;
using Mascota_Feliz.App.Persistencia;
using System.Collections.Generic;           // colecciones de datos, para consultas DB
using System.Linq;

namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
    public interface IRepositorio_Visita
    {
        //firma de métodos del CRUD

        Visita AddVisita(Visita visita);

        void DeleteVisita(int ID_Visita);

        Visita GetVisita(int ID_Visita);

        Visita UpdateVisita(Visita visita);

        IEnumerable<HVisita> GetAllVisita();
    }


}
