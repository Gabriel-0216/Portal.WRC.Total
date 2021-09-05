using Microsoft.EntityFrameworkCore;
using Portal.WRC.Total.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Data
{
    public class EquipesContexto : DbContext
    {
        public EquipesContexto(DbContextOptions<EquipesContexto> opcoes) : base(opcoes)
        {

        }

        public DbSet<Equipes> Equipes { get; set; }
    }
}
