using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbTest.DataModels;
using SQLite.CodeFirst;

namespace DbTest.Databases
{
    public class TestCardsDbContext : DbContext
    {
        public DbSet<Card> Cards { set; get; }
        public DbSet<Winding> Windings { set; get; }
        public DbSet<WindDetail> WindDetails { set; get; }
        public DbSet<Cycle> Cycles { set; get; }

        public TestCardsDbContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var model = modelBuilder.Build(Database.Connection);
            ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
            string sql = sqlGenerator.Generate(model.StoreModel);
        }

        //public static bool UseTmpFile = false;

        //public TestCardsDbContext()
        //{
        //    Database.EnsureCreated();
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(UseTmpFile ? "Filename=TestCards_tmp.db" : "Filename=TestCards.db");
        //}
    }
}
