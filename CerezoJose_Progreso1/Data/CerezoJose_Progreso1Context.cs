using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CerezoJose_Progreso1.Models;

namespace CerezoJose_Progreso1.Data
{
    public class CerezoJose_Progreso1Context : DbContext
    {
        public CerezoJose_Progreso1Context (DbContextOptions<CerezoJose_Progreso1Context> options)
            : base(options)
        {
        }

        public DbSet<CerezoJose_Progreso1.Models.JoseCerezo> JoseCerezo { get; set; } = default!;
        public DbSet<CerezoJose_Progreso1.Models.Telefono> Telefono { get; set; } = default!;
    }
}
