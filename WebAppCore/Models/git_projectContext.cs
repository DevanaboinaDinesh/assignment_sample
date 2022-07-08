using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppCore.Models
{
    public partial class git_projectContext : DbContext
    {
        public git_projectContext()
        {
        }

        public git_projectContext(DbContextOptions<git_projectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Emp> Emp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=git_project;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Emp__C190176BFD7EFD21");

                entity.Property(e => e.Eid)
                    .HasColumnName("EId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Edesign)
                    .HasColumnName("EDesign")
                    .HasMaxLength(50);

                entity.Property(e => e.Edoj)
                    .HasColumnName("EDOJ")
                    .HasColumnType("date");

                entity.Property(e => e.Ename)
                    .HasColumnName("EName")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
