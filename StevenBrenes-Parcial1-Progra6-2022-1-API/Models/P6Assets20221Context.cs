﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StevenBrenes_Parcial1_Progra6_2022_1_API.Models
{
    public partial class P6Assets20221Context : DbContext
    {
        public P6Assets20221Context()
        {
        }

        public P6Assets20221Context(DbContextOptions<P6Assets20221Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Activo> Activos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("SERVER=192.168.1.111; DATABASE=P6Assets20221; User Id=sa; Password=HacHxnZ6");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activo>(entity =>
            {
                entity.HasKey(e => e.Idactivo)
                    .HasName("PK__Activo__4D26804413838435");

                entity.ToTable("Activo");

                entity.Property(e => e.Idactivo).HasColumnName("IDActivo");

                entity.Property(e => e.CostoActivo).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoActivo)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreActivo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
