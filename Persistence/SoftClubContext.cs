using System;
using Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Persistence
{
    public class SoftClubContext:DbContext
    {
        public SoftClubContext(DbContextOptions<SoftClubContext> options):base(options)
        {
        }

        public  DbSet<Product> Products { get; set; } // table
    }
}