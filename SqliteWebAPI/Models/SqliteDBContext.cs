using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace SqliteWebAPI.Models
{
    public class SqliteDBContext : DbContext
    {
        public SqliteDBContext(DbContextOptions<SqliteDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
