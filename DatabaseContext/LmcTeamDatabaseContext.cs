using Auth0MVCApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth0MVCApp.DatabaseContext
{
    public class LmcTeamDatabaseContext : DbContext
    {
        public LmcTeamDatabaseContext(DbContextOptions<LmcTeamDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Image> Images { get; set; }
        public DbSet<User> User { get; set; }


    }
}
