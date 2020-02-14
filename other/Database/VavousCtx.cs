using System;
using Microsoft.EntityFrameworkCore;
using Vavous.API.Database.Entities;

namespace Vavous.API.Database
{
    public class VavousCtx : DbContext
    {
        public VavousCtx(DbContextOptions<VavousCtx> options) : base(options)
        {

        }

        public DbSet<Company> Company { get; set; }
        public DbSet<User> User { get; set; }
    }
}
