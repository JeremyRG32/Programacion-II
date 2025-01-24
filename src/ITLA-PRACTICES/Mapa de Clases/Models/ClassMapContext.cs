using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mapa_de_Clases.Models;

public partial class ClassMapContext : DbContext
{
    public ClassMapContext()
    {
    }

    public ClassMapContext(DbContextOptions<ClassMapContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrador> Administradors { get; set; }

    public virtual DbSet<Administrativo> Administrativos { get; set; }

    public virtual DbSet<Docente> Docentes { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<ExAlumno> ExAlumnos { get; set; }

    public virtual DbSet<Maestro> Maestros { get; set; }

    public virtual DbSet<MiembroDeLaComunidad> MiembroDeLaComunidads { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CULATA\\SQLEXPRESS; Database=Class_Map; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Administ__3214EC279C93A809");

            entity.ToTable("Administrador");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DocenteId).HasColumnName("DocenteID");
            entity.Property(e => e.NivelJerarquico)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Docente).WithMany(p => p.Administradors)
                .HasForeignKey(d => d.DocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Administr__Docen__59FA5E80");
        });

        modelBuilder.Entity<Administrativo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Administ__3214EC27E677201B");

            entity.ToTable("Administrativo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Administrativos)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Administr__Emple__571DF1D5");
        });

        modelBuilder.Entity<Docente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Docente__3214EC2781FA41F1");

            entity.ToTable("Docente");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Especialidad)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.Empleado).WithMany(p => p.Docentes)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Docente__Emplead__5441852A");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empleado__3214EC27005DC661");

            entity.ToTable("Empleado");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MiembroId).HasColumnName("MiembroID");
            entity.Property(e => e.Puesto)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Miembro).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.MiembroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Empleado__Miembr__4E88ABD4");
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estudian__3214EC2768018E27");

            entity.ToTable("Estudiante");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Carrera)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MiembroId).HasColumnName("MiembroID");

            entity.HasOne(d => d.Miembro).WithMany(p => p.Estudiantes)
                .HasForeignKey(d => d.MiembroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Estudiant__Miemb__4BAC3F29");
        });

        modelBuilder.Entity<ExAlumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ExAlumno__3214EC27917AB55F");

            entity.ToTable("ExAlumno");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MiembroId).HasColumnName("MiembroID");

            entity.HasOne(d => d.Miembro).WithMany(p => p.ExAlumnos)
                .HasForeignKey(d => d.MiembroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ExAlumno__Miembr__5165187F");
        });

        modelBuilder.Entity<Maestro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Maestro__3214EC27B2B64C3B");

            entity.ToTable("Maestro");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocenteId).HasColumnName("DocenteID");

            entity.HasOne(d => d.Docente).WithMany(p => p.Maestros)
                .HasForeignKey(d => d.DocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Maestro__Docente__5CD6CB2B");
        });

        modelBuilder.Entity<MiembroDeLaComunidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MiembroD__3214EC27F78474F9");

            entity.ToTable("MiembroDeLaComunidad");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
