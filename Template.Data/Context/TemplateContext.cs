using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Data.Extensions;
using Template.Data.Mappings;
using Template.Domain.Entities;

namespace Template.Data.Context
{
    public class TemplateContext: DbContext
    {
        public TemplateContext(DbContextOptions<TemplateContext> option)
            : base(option) { }

        #region "DBSets"

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.ApplyGlobalConfigurations();
            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
