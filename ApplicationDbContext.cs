using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Candy_Stores.Data;

namespace Candy_Stores.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Candy_Stores.Data.Candy> Candy { get; set; }
        public DbSet<Candy_Stores.Data.Candy_Store> Candy_Store { get; set; }
    }
}
