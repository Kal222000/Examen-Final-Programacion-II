using System;
using System.Collections.Generic;
using BACKEND.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Datos.SQL;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<PrestamosExitoso> PrestamosExitosos { get; set; }

    public virtual DbSet<ReservaDetalle> ReservaDetalles { get; set; }

    public virtual DbSet<SolicitudReserva> SolicitudReservas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=S1\\SQLEXPRESS;Database=BaseFinal3;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Login__2B3DE798C7B46499");

            entity.ToTable("Login");

            entity.Property(e => e.UsuarioId)
                .ValueGeneratedNever()
                .HasColumnName("UsuarioID");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Usuario).WithOne(p => p.Login)
                .HasForeignKey<Login>(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Login__UsuarioID__4CA06362");
        });

        modelBuilder.Entity<PrestamosExitoso>(entity =>
        {
            entity.HasKey(e => e.ReservaDetalleId).HasName("PK__Prestamo__7B1C03FAEA8234F6");

            entity.Property(e => e.ReservaDetalleId)
                .ValueGeneratedNever()
                .HasColumnName("ReservaDetalleID");
            entity.Property(e => e.FechaDevolucionReal).HasColumnType("datetime");
            entity.Property(e => e.FechaRecogida).HasColumnType("datetime");

            entity.HasOne(d => d.ReservaDetalle).WithOne(p => p.PrestamosExitoso)
                .HasForeignKey<PrestamosExitoso>(d => d.ReservaDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Prestamos__Reser__571DF1D5");

            entity.ToTable("PrestamosExitosos");
        });

        modelBuilder.Entity<ReservaDetalle>(entity =>
        {
            entity.HasKey(e => e.ReservaId).HasName("PK__ReservaD__C3993703F4B14A9A");

            entity.ToTable("ReservaDetalle");

            entity.Property(e => e.ReservaId).HasColumnName("ReservaID");
            entity.Property(e => e.EstadoDetalle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("pendiente");
            entity.Property(e => e.LibroId)
                .HasMaxLength(24)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LibroID");
            entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

            entity.HasOne(d => d.Solicitud).WithMany(p => p.ReservaDetalles)
                .HasForeignKey(d => d.SolicitudId)
                .HasConstraintName("FK__ReservaDe__Solic__534D60F1");
        });

        modelBuilder.Entity<SolicitudReserva>(entity =>
        {
            entity.HasKey(e => e.SolicitudId).HasName("PK__Solicitu__85E95DA7A112E941");

            entity.ToTable("SolicitudReserva");

            entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");
            entity.Property(e => e.EstadoSolicitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("pendiente");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.SolicitudReservas)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__Solicitud__Usuar__4F7CD00D");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuarios");
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE798467AF510");

            entity.HasIndex(e => e.Carnet, "UQ__Usuarios__5E387B4DCD70CA3E").IsUnique();

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
