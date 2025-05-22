using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_External_Configuration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_External_Configuration.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; } = null!;

        public AppDbContext(DbContextOptions option)
            : base(option)
        {

        }
    }

}
