using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SD_330_W22SD_Labs.Models;

namespace SD_330_W22SD_Labs.Data
{
    public class SD_330_W22SD_LabsContext : DbContext
    {
        public SD_330_W22SD_LabsContext (DbContextOptions<SD_330_W22SD_LabsContext> options)
            : base(options)
        {
        }

        public DbSet<SD_330_W22SD_Labs.Models.Customer> Customer { get; set; } = default!;
        public DbSet<SD_330_W22SD_Labs.Models.Address> Address { get; set; } = default!;
    }
}
