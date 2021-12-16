using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SPMedical.Domains;

#nullable disable

namespace SPMedical.Contexts
{
    public partial class SPMedicalContext : DbContext
    {
        public SPMedicalContext()
        {
        }

        public SPMedicalContext(DbContextOptions<SPMedicalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clinica> Clinicas { get; set; }
        public virtual DbSet<Consulta> Consultas { get; set; }
        public virtual DbSet<Especialidade> Especialidades { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BR4J4LS\\SQLEXPRESS; initial catalog=SP_Medical; user Id=sa; pwd=shenna01;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Clinica>(entity =>
            {
                entity.Property(e => e.ClinicaId).HasColumnName("clinicaID");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.EnderecoClinica)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("enderecoClinica");

                entity.Property(e => e.HorarioAbertura).HasColumnName("horarioAbertura");

                entity.Property(e => e.HorarioFechamento).HasColumnName("horarioFechamento");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeFantasia");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("razaoSocial");
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.Property(e => e.ConsultaId).HasColumnName("consultaID");

                entity.Property(e => e.DataConsulta)
                    .HasColumnType("datetime")
                    .HasColumnName("dataConsulta");

                entity.Property(e => e.DescConsulta)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descConsulta");

                entity.Property(e => e.MedicoId).HasColumnName("medicoID");

                entity.Property(e => e.PacienteId).HasColumnName("pacienteID");

                entity.HasOne(d => d.Medico)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.MedicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_consultasMedico");

                entity.HasOne(d => d.Paciente)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.PacienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_consultasPaciente");
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.Property(e => e.EspecialidadeId).HasColumnName("especialidadeID");

                entity.Property(e => e.NomeEspecialidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeEspecialidade");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.ToTable("Medico");

                entity.Property(e => e.MedicoId).HasColumnName("medicoID");

                entity.Property(e => e.ClinicaId).HasColumnName("clinicaID");

                entity.Property(e => e.Crm)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("crm");

                entity.Property(e => e.EspecialidadeId).HasColumnName("especialidadeID");

                entity.Property(e => e.UsuarioId).HasColumnName("_usuarioID");

                entity.HasOne(d => d.Clinica)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.ClinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_medicoClinica");

                entity.HasOne(d => d.Especialidade)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.EspecialidadeId)
                    .HasConstraintName("FK__Medico__especial__2F10007B");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("fk_medicoUsuario");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.ToTable("Paciente");

                entity.Property(e => e.PacienteId).HasColumnName("pacienteID");

                entity.Property(e => e.Cpfpaciente)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPFPaciente");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("dataNascimento");

                entity.Property(e => e.EnderecoPaciente)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("enderecoPaciente");

                entity.Property(e => e.Rgpaciente)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RGPaciente");

                entity.Property(e => e.TelefonePaciente)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("telefonePaciente");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioID");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__Paciente__usuari__2B3F6F97");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.ToTable("TipoUsuario");

                entity.Property(e => e.TipoUsuarioId).HasColumnName("tipoUsuarioID");

                entity.Property(e => e.NomeTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeTipo");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.TipoUsuarioId).HasColumnName("tipoUsuarioID");

                entity.HasOne(d => d.TipoUsuario)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.TipoUsuarioId)
                    .HasConstraintName("FK__Usuarios__tipoUs__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
