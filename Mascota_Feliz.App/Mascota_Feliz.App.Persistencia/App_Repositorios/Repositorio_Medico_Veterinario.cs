using System;
using Mascota_Feliz.App.Dominio ;
using Mascota_Feliz.App.Persistencia;
using System.Collections.Generic;           // colecciones de datos, para consultas DB
using System.Linq;

namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
    public class Repositorio_Medico_Veterinario : IRepositorio_Medico_Veterinario
    {
        // readonly = permite definir un atributo solo para lectura
        private AppContext _appContext;

        public Repositorio_Medico_Veterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        Medico_Veterinario IRepositorio_Medico_Veterinario.AddMedico_Veterinario(Medico_Veterinario medico_veterinario)
        {
            var medico_veterinarioAdicionado = _appContext.veterinarios.Add(medico_veterinario);
            _appContext.SaveChanges();
            return medico_veterinarioAdicionado.Entity;
        }
        void IRepositorio_Medico_Veterinario.DeleteMedico_Veterinario(int id_Medico_Veterinario)
        {
            var medico_veterinarioEncontrado = _appContext.veterinarios.FirstOrDefault(v => v.id == id_Medico_Veterinario);
            if (medico_veterinarioEncontrado == null)
            {
                return;
            }
            // si es null no continua con las siguientes lineas
            _appContext.veterinarios.Remove(medico_veterinarioEncontrado);
            _appContext.SaveChanges();
        }
        Medico_Veterinario IRepositorio_Medico_Veterinario.GetMedico_Veterinario(int id__Medico_Veterinario)
        {
            return _appContext.veterinarios.FirstOrDefault(v => v.id == id__Medico_Veterinario);
        }

        Medico_Veterinario IRepositorio_Medico_Veterinario.UpdateMedico_Veterinario(Medico_Veterinario medico_veterinario)
        {
            var medico_veterinarioEncontrado = _appContext.veterinarios.FirstOrDefault(v => v.id == medico_veterinario.id);
            if (medico_veterinarioEncontrado != null)
            {
                medico_veterinario.id = medico_veterinarioEncontrado.id;
                medico_veterinario.Nombre_Veterinario = medico_veterinarioEncontrado.Nombre_Veterinario;
                medico_veterinario.Apellidos_Veterinario = medico_veterinarioEncontrado.Apellidos_Veterinario;
                medico_veterinario.Direccion_Veterinario = medico_veterinarioEncontrado.Direccion_Veterinario;
                medico_veterinario.Telefono_Veterinario = medico_veterinarioEncontrado.Telefono_Veterinario;
                medico_veterinario.Tarjeta_Profesional = medico_veterinarioEncontrado.Tarjeta_Profesional;
                _appContext.SaveChanges();

            }

            return medico_veterinario;
        }
        IEnumerable<Medico_Veterinario> IRepositorio_Medico_Veterinario.GetAllMedico_Veterinario()
        {
            return _appContext.veterinarios;
        }
    }
        

}