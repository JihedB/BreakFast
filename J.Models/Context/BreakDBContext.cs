using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace J.Models.Context
{
    public partial class BreakDBContext : DbContext
    {
        public BreakDBContext() : base("name=BreakDataBase")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //  public virtual DbSet<Menu> menus { get; set; }
    }
}
