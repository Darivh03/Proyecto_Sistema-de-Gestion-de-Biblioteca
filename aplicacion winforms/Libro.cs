using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace aplicacion_winforms
{

        public class Libro
        {
            [Key]  // Define la clave primaria
            public int Id_Libro { get; set; }

            [Required] // Campo obligatorio
            public string Titulo { get; set; }

            [Required]
            public string Autor { get; set; }

            public string Categoria { get; set; }

            public bool Disponible { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-7ALR3JB;Database=BibliotecaDB;User Id=sa;Password=Rivera.03;");

            }
        }
    
}
