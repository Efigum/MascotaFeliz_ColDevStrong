using System;
using Mascota_Feliz.App.Dominio ;
using Mascota_Feliz.App.Persistencia;
using System.Collections.Generic;           // colecciones de datos, para consultas DB
using System.Linq;

namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
    public class Repositorio_Mascota : IRepositorio_Mascota
    {
        // readonly = permite definir un atributo solo para lectura
        private AppContext _appContext;
        
        public Repositorio_Mascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        Mascota IRepositorio_Mascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionada = _appContext.mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }
        void IRepositorio_Mascota.DeleteMascota(int ID_Mascota)
        {
            var mascotaEncontrada = _appContext.mascotas.FirstOrDefault(m => m.id == mascota.ID_Mascota;
            if (mascotaEncontrada == null)
            {
                return;
            }
            // si es null no continua con las siguientes lineas
            _appContext.mascotas.Remove(mascotaEncontrada);
            _appContext.SaveChanges();
        }
        Mascota IRepositorio_Mascota.GetMascota(int ID_Mascota)
        {
            return _appContext.mascotas.FirstOrDefault(m => m.id == mascota.ID_Mascota);
        }

        Mascota IRepositorio_Mascota.UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrada = _appContext.mascotas.FirstOrDefault(m => m.id == mascota.ID_Mascota);
            if (mascotaEncontrada != null)
            {
                mascota.ID_Mascota = mascotaEncontrada.id;
                mascota.Nombre_Mascota = mascotaEncontrada.Nombre_Mascota;
                mascota.Especie = mascotaEncontrada.Especie;
                mascota.Raza = mascotaEncontrada.Raza;
                mascota.Color = mascotaEncontrada.Color;
                mascota.ID_Propietario = mascotaEncontrada.ID_Propietario;
                mascota.ID_Veterinario = mascotaEncontrada.ID_Veterinario;
                _appContext.SaveChanges();

            }
        }
        IEnumerable<Mascota> IRepositorio_Mascota.GetAllMascotas()
        {
            return _appContext.mascotas;
        }
    }
        

}