using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class MyOwnProjectContext : DbContext
{
    public MyOwnProjectContext(DbContextOptions<MyOwnProjectContext> options) : base(options)
    {
    }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public 	DbSet<Ciudad> Ciudades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    // Hacer migracion WebApi Netcore Parte 6
    /*
        dotnet tool list -g -> Para ver si el paquete dotnet-ef esta instalado

        dotnet tool install --global dotnet-ef -> Para instalar el paquete dotnet-ef 

        dotnet-ef -h -> Para ver que podemos hacer con el comando dotnet ef <-

        dotnet-ef migrations -h -> Para que podemos hacer en las migraciones
    */
}