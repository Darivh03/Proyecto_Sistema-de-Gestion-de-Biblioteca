using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aplicacion_winforms
{
    class Libro
    {
        public class BibliotecaContext : DbContext
        {
            public DbSet<Libro> Libros { get; set; }
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Prestamo> Prestamos { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-7ALR3JB;Database=BibliotecaDB;Trusted_Connection=True;");
            }
        }
    }
}
