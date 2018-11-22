namespace PITP.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ppaluserContext : DbContext
    {
        public ppaluserContext()
            : base("name=ppaluserContext")
        {
        }

        public virtual DbSet<formuser> formusers { get; set; }
        public virtual DbSet<ppal> ppals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<formuser>()
                .HasOptional(e => e.ppal)
                .WithRequired(e => e.formuser)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ppal>()
                .Property(e => e.sAmountPaid)
                .HasPrecision(19, 4);
        }
    }
}
