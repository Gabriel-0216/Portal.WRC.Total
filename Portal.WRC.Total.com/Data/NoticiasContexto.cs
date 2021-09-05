using Microsoft.EntityFrameworkCore;
using Portal.WRC.Total.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Data
{
    public class NoticiasContexto : DbContext
    {
        public NoticiasContexto(DbContextOptions<NoticiasContexto> opcoes) : base(opcoes)
        {

        }

        public DbSet<Noticia> Noticia { get; set; }
    }
}
