using System;
using Mascota_Feliz.App.Dominio ;
using Mascota_Feliz.App.Persistencia;
using System.Collections.Generic;           // colecciones de datos, para consultas DB
using System.Linq;

namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
    public class Repositorio_Visita : IRepositorio_Visita
    {
        // readonly = permite definir un atributo solo para lectura
        private AppContext _appContext;

        public Repositorio_Visita(AppContext appContext)
        {
            _appContext = appContext;
        }

        Visita IRepositorio_Visita.AddVisita(Visita visita)
        {
            var visitaAdicionada = _appContext.visitas.Add(visita);
            _appContext.SaveChanges();
            return visitaAdicionada.Entity;
        }
        void IRepositorio_Visita.DeleteVisita(int id_Visita)
        {
            var visitaEncontrada = _appContext.visitas.FirstOrDefault(t => t.id == id_Visita);
            if (visitaEncontrada == null)
            {
                return;
            }
            // si es null no continua con las siguientes lineas
            _appContext.visitas.Remove(visitaEncontrada);
            _appContext.SaveChanges();
        }
        Visita IRepositorio_Visita.GetVisita(int id_Visita)
        {
            return _appContext.visitas.FirstOrDefault(v => v.id == id_Visita);
        }

        Visita IRepositorio_Visita.UpdateVisita(Visita visita)
        {
            var visitaEncontrada = _appContext.visitas.FirstOrDefault(t => t.id == visita.id);
            if (visitaEncontrada != null)
            {
                visita.id = visitaEncontrada.id;
                visita.Peso = visitaEncontrada.Peso;
                visita.Temperatura = visitaEncontrada.Temperatura;
                visita.Frecuencia_Cardiaca = visitaEncontrada.Frecuencia_Cardiaca;
                visita.Frecuencia_Respiratoria = visitaEncontrada.Frecuencia_Respiratoria;
                visita.Estado_de_animo = visitaEncontrada.Estado_de_animo;
                visita.Fecha_Visita = visitaEncontrada.Fecha_Visita;
                visita.historia_clinica = visitaEncontrada.historia_clinica;
                visita.Recomendaciones = visitaEncontrada.Recomendaciones;
                visita.Medicamentos = visitaEncontrada.Medicamentos;
                _appContext.SaveChanges();

            }

            return visitaEncontrada;
        }
        IEnumerable<Visita> IRepositorio_Visita.GetAllVisita()
        {
            return _appContext.visitas;
        }
    }
        

}