using Microsoft.EntityFrameworkCore;
using SistemaMotocicletas.Models;

namespace SistemaMotocicletas.Data
{
    public class SistemaMotocicletasDbContext: DbContext
    {
        //Este set son para las tablas
        //Tabla de talleres
        public DbSet<Taller> Talleres { get; set; }

        //Tabla de Motocicletas

        public DbSet<Motocicleta> Motocicletas { get; set; }


        public SistemaMotocicletasDbContext(DbContextOptions<SistemaMotocicletasDbContext>options): base(options)
        {


        }

        
    }
}
