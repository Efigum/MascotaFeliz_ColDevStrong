using System;
using System.Collections.Generic;
using System.Linq;
using Mascota_Feliz.App.Dominio;
using Mascota_Feliz.App.Persistencia;


namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
   
    public interface IRepositorio_Propietario_Mascota
    {
        // firmas de los métodos del CRUD
        Propietario_Mascota AddPropietario_Mascota(Propietario_Mascota propietario);

        Propietario_Mascota UpdatePropietario_Mascota(Propietario_Mascota propietario);

        void DeletePropietario_Mascota(int id_Propietario);

        IEnumerable<Propietario_Mascota> GetAllpropietarios();  // IEnumerable  - me permite retonar una lista de objetos

        Propietario_Mascota GetPropietario_Mascota(int id_Propietario);
        

    }
}