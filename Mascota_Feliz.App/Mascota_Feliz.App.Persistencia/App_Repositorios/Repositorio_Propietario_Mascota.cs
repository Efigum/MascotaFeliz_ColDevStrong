using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Mascota_Feliz.App.Dominio ;
using Mascota_Feliz.App.Persistencia;


namespace Mascota_Feliz.App.Persistencia.App_Repositorios
{
    public class Repositorio_Propietario_Mascota : IRepositorio_Propietario_Mascota
    {
        private readonly AppContext _appContext;

        public Repositorio_Propietario_Mascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        Propietario_Mascota IRepositorio_Propietario_Mascota.AddPropietario_Mascota(Propietario_Mascota propietario)
        {
            var propietarioAdicionado = _appContext.propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        Propietario_Mascota IRepositorio_Propietario_Mascota.UpdatePropietario_Mascota(Propietario_Mascota propietario)
        {
            var propietarioActualizar = _appContext.propietarios.SingleOrDefault(r => r.id == Propietario_Mascota.ID_Propietario)
            if (propietarioActualizar != null)
            {
                propietarioActualizar.ID_Propietario = propietario.id;
                propietarioActualizar.Nombres_Propietario = propietario.Nombres_Propietario;
                propietarioActualizar.Apellidos_Propietario = propietario.Apellidos_Propietario;
                propietarioActualizar.Direccion_Propietario = propietario.Direccion_Propietario;
                propietarioActualizar.Telefono_Propietario = propietario.Telefono_Propietario;
                propietarioActualizar.Correo_Electronico = propietario.Correo_Electronico;
                _appContext.SaveChanges();

            }
            return propietarioActualizar;
        }

        void IRepositorio_Propietario_Mascota.DeletePropietario(int ID_Propietario)
        {
            var propietarioEncontrado = _appContext.propietarios.FirstOrDefault(c => c.id == ID_Propietario);
            if (propietarioEncontrado == null)
            {
                return;
            }

            _appContext.propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Propietario_Mascota> IRepositorio_Propietario_Mascota.GetAllpropietarios()
        {
            return _appContext.propietarios;
        }

        Propietario_Mascota IRepositorio_Propietario_Mascota.GetPropietario_Mascota(int ID_Propietario)
        {
            return _appContext.propietarios.FirstOrDefault(c => c.id == ID_Propietario)
        }
    }
}