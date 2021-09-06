using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroFilme.Models;

namespace CadastroFilme.Data
{
    public class CadastroFilmeContext : DbContext
    {
        public CadastroFilmeContext (DbContextOptions<CadastroFilmeContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroFilme.Models.Studio> Studio { get; set; }
    }
}
