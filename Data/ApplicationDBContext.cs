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

        DbSet<Producto> Producto {  get; set; }
    }
}
