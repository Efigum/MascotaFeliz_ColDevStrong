using Microsoft.EntityFrameworkCore;
using Mascota_Feliz.App.Dominio;

namespace Mascota_Feliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Propietario_Mascota> propietarios { get; set; }
        public DbSet<Medico_Veterinario> veterinarios { get; set; }
        public DbSet<Mascota> mascotas { get; set; }
        public DbSet<Historia_Clinica> historias_clinica { get; set; }
        public DbSet<Visita> visitas { get; set; }

        // implementar todas las clases

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Mascota_feliz.Data");
                
            }
        }

    }
    
}