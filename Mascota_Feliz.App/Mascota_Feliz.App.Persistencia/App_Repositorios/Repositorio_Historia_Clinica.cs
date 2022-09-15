using System;
using Mascota_Feliz.App.Dominio ;
using Mascota_Feliz.App.Persistencia;
using System.Collections.Generic;           // colecciones de datos, para consultas DB
using System.Linq;

namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
    public class Repositorio_Historia_Clinica: IRepositorio_Historia_Clinica
    {
        // readonly = permite definir un atributo solo para lectura
        private AppContext _appContext;
        
        public Repositorio_Historia_Clinica(AppContext appContext)
        {
            _appContext = appContext;
        }

        Historia_Clinica IRepositorio_Historia_Clinica.AddHistoria_Clinica(Historia_Clinica historia_clinica)
        {
            var historia_clinicaAdicionada = _appContext.historias_clinica.Add(historia_clinica);
            _appContext.SaveChanges();
            return historia_clinicaAdicionada.Entity;
        }
        void IRepositorio_Historia_Clinica.DeleteHistoria_Clinica(int id_Historia_Clinica)
        {
            var historia_clinicaEncontrada = _appContext.historias_clinica.FirstOrDefault(h => h.id == id_Historia_Clinica);
            if (historia_clinicaEncontrada == null)
            {
                return;
            }
            // si es null no continua con las siguientes lineas
            _appContext.historias_clinica.Remove(historia_clinicaEncontrada);
            _appContext.SaveChanges();
        }
        Historia_Clinica IRepositorio_Historia_Clinica.GetHistoria_Clinica(int id_Historia_Clinica)
        {
            return _appContext.historias_clinica.FirstOrDefault(h => h.id == id_Historia_Clinica);
        }

        Historia_Clinica IRepositorio_Historia_Clinica.UpdateHistoria_Clinica(Historia_Clinica historia_clinica)
        {
            var historia_clinicaEncontrada = _appContext.historias_clinica.FirstOrDefault(h => h.id == historia_clinica.id);
            if (historia_clinicaEncontrada != null)
            {
                historia_clinica.id = historia_clinicaEncontrada.id;
                historia_clinica.Fecha_Apertura_HC = historia_clinicaEncontrada.Fecha_Apertura_HC;
                historia_clinica.mascota = historia_clinicaEncontrada.mascota;
                _appContext.SaveChanges();

            }

            return historia_clinica;
        }
        IEnumerable<Historia_Clinica> IRepositorio_Historia_Clinica.GetAllHistoria_Clinica()
        {
            return _appContext.historias_clinica;
        }
    }
        

}