using APIProductos.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace APIProductos.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext( 
            DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        
        }

        public DbSet<Producto> Producto {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                
                new Producto
                {
                    IdProducto = 1,
                    Nombre="Producto1",
                    Descripcion="Descripcion Producto1",
                    cantidad=12,
                    urlImage = "https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png"
                }
                
                );
        }


    }
}
