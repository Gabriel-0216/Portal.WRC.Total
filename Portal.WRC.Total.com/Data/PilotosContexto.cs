using Microsoft.EntityFrameworkCore;
using Portal.WRC.Total.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Data
{
    public class PilotosContexto : DbContext
    {
        public PilotosContexto(DbContextOptions<PilotosContexto> opcoes) : base(opcoes)
        {

        }

        public DbSet<Piloto> Piloto { get; set; }
    }
}
