using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using employee_management_api.Data.Entity;

namespace employee_management_api.Data
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserDocument> UserDocuments { get; set; } = null!;
        public virtual DbSet<UserDocumentType> UserDocumentTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=constring", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.26-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("last_updated_by");

                entity.Property(e => e.LastUpdatedDate).HasColumnName("last_updated_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CurrentAddress)
                    .HasMaxLength(255)
                    .HasColumnName("current_address");

                entity.Property(e => e.CurrentCity)
                    .HasMaxLength(255)
                    .HasColumnName("current_city");

                entity.Property(e => e.CurrentState)
                    .HasColumnType("int(11)")
                    .HasColumnName("current_state");

                entity.Property(e => e.Desigination)
                    .HasColumnType("int(11)")
                    .HasColumnName("desigination");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Doj).HasColumnName("doj");

                entity.Property(e => e.Dor).HasColumnName("dor");

                entity.Property(e => e.EmailOfficial)
                    .HasMaxLength(255)
                    .HasColumnName("email_official");

                entity.Property(e => e.EmailPersonal)
                    .HasMaxLength(255)
                    .HasColumnName("email_personal");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(255)
                    .HasColumnName("father_name");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("last_updated_by");

                entity.Property(e => e.LastUpdatedDate).HasColumnName("last_updated_date");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(255)
                    .HasColumnName("mobile");

                entity.Property(e => e.MobileAlternate)
                    .HasMaxLength(255)
                    .HasColumnName("mobile_alternate");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_address");

                entity.Property(e => e.PermanentCity)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_city");

                entity.Property(e => e.PermanentState)
                    .HasColumnType("int(11)")
                    .HasColumnName("permanent_state");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(255)
                    .HasColumnName("remarks");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("status");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<UserDocument>(entity =>
            {
                entity.ToTable("user_documents");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.DocumentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("document_id");

                entity.Property(e => e.ExpiryDate).HasColumnName("expiry_date");

                entity.Property(e => e.Number).HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserDocumentType>(entity =>
            {
                entity.ToTable("user_document_types");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("last_updated_by");

                entity.Property(e => e.LastUpdatedDate).HasColumnName("last_updated_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
