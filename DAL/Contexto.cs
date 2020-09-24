using Microsoft.EntityFrameworkCore;
using Ejercicio1AplicadaII.Models;
public class Contexto : DbContext{
    public DbSet<Estudiantes> Estudiante { get; set; }
    public DbSet<Nacionalidades> Nacionalidad {get; set;}

    //public Contexto(DbContextOptions options) : base(options){}

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source= Data\Estudiante.db");
    }

    
}

