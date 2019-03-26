using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhoenixCharts.Shared.Models;

namespace PhoenixCharts.Server.Data
{
    public class PracticeContext : DbContext
    {

        public PracticeContext()
        {

        }

        //public PracticeContext(DbContextOptions<PracticeContext> options) : base(options)
        //{
        //}

        public DbSet<Consumer> Consumer { get; set; }
        public DbSet<Document> Document { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=WOODPC;Initial Catalog=Phoenix;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

    }
}
