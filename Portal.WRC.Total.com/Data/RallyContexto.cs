using Microsoft.EntityFrameworkCore;
using Portal.WRC.Total.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Data
{
    public class RallyContexto : DbContext
    {
        public RallyContexto(DbContextOptions<RallyContexto> options) : base(options)
        {

        }
        public DbSet<Rally> Rally { get; set; }
    }
}
