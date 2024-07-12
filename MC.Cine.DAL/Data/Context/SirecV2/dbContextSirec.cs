using System;
using System.Collections.Generic;
using MC.Cine.DAL.Data.Context.SirecV2.Entities;
using Microsoft.EntityFrameworkCore;

namespace MC.Cine.DAL.Data.Context.SirecV2;

public partial class dbContextSirec : DbContext
{
    public dbContextSirec()
    {
    }

    public dbContextSirec(DbContextOptions<dbContextSirec> options)
        : base(options)
    {
    }

    public virtual DbSet<Agente> Agentes { get; set; }

    public virtual DbSet<AgentesConsejoDepartamental> AgentesConsejoDepartamentals { get; set; }

    public virtual DbSet<AgentesEtnium> AgentesEtnia { get; set; }

    public virtual DbSet<AgentesGenero> AgentesGeneros { get; set; }

    public virtual DbSet<AgentesGrupoPoblacional> AgentesGrupoPoblacionals { get; set; }

    public virtual DbSet<AgentesJuridico> AgentesJuridicos { get; set; }

    public virtual DbSet<AgentesJuridicosRepresentanteLegal> AgentesJuridicosRepresentanteLegals { get; set; }

    public virtual DbSet<AgentesJuridicosTipo> AgentesJuridicosTipos { get; set; }

    public virtual DbSet<AgentesNaturale> AgentesNaturales { get; set; }

    public virtual DbSet<AgentesProfesion> AgentesProfesions { get; set; }

    public virtual DbSet<AgentesTipo> AgentesTipos { get; set; }

    public virtual DbSet<AgentesTiposAgente> AgentesTiposAgentes { get; set; }

    public virtual DbSet<AgentesTiposAgentesPersona> AgentesTiposAgentesPersonas { get; set; }

    public virtual DbSet<Aplicacione> Aplicaciones { get; set; }

    public virtual DbSet<AplicacionesAccione> AplicacionesAcciones { get; set; }

    public virtual DbSet<AplicacionesDatosUsuariosInterno> AplicacionesDatosUsuariosInternos { get; set; }

    public virtual DbSet<AplicacionesDepartamento> AplicacionesDepartamentos { get; set; }

    public virtual DbSet<AplicacionesEstado> AplicacionesEstados { get; set; }

    public virtual DbSet<AplicacionesEtnium> AplicacionesEtnia { get; set; }

    public virtual DbSet<AplicacionesFormatoRodaje> AplicacionesFormatoRodajes { get; set; }

    public virtual DbSet<AplicacionesGenero> AplicacionesGeneros { get; set; }

    public virtual DbSet<AplicacionesGeneroObra> AplicacionesGeneroObras { get; set; }

    public virtual DbSet<AplicacionesGrupoPoblacional> AplicacionesGrupoPoblacionals { get; set; }

    public virtual DbSet<AplicacionesIdioma> AplicacionesIdiomas { get; set; }

    public virtual DbSet<AplicacionesLenguaNativa> AplicacionesLenguaNativas { get; set; }

    public virtual DbSet<AplicacionesLogin> AplicacionesLogins { get; set; }

    public virtual DbSet<AplicacionesModulo> AplicacionesModulos { get; set; }

    public virtual DbSet<AplicacionesModulosEstadosAccione> AplicacionesModulosEstadosAcciones { get; set; }

    public virtual DbSet<AplicacionesModulosPerfile> AplicacionesModulosPerfiles { get; set; }

    public virtual DbSet<AplicacionesModulosPerfilesAplicacionLogin> AplicacionesModulosPerfilesAplicacionLogins { get; set; }

    public virtual DbSet<AplicacionesMonedum> AplicacionesMoneda { get; set; }

    public virtual DbSet<AplicacionesMunicipio> AplicacionesMunicipios { get; set; }

    public virtual DbSet<AplicacionesPaise> AplicacionesPaises { get; set; }

    public virtual DbSet<AplicacionesPerfile> AplicacionesPerfiles { get; set; }

    public virtual DbSet<AplicacionesPersona> AplicacionesPersonas { get; set; }

    public virtual DbSet<AplicacionesProfesion> AplicacionesProfesions { get; set; }

    public virtual DbSet<AplicacionesSubGenero> AplicacionesSubGeneros { get; set; }

    public virtual DbSet<AplicacionesTipoDuracionProyeccion> AplicacionesTipoDuracionProyeccions { get; set; }

    public virtual DbSet<AplicacionesTipoFormatoRodaje> AplicacionesTipoFormatoRodajes { get; set; }

    public virtual DbSet<AplicacionesTipoIdentificacion> AplicacionesTipoIdentificacions { get; set; }

    public virtual DbSet<AplicacionesTipoPelicula> AplicacionesTipoPeliculas { get; set; }

    public virtual DbSet<AplicacionesTipoPersona> AplicacionesTipoPersonas { get; set; }

    public virtual DbSet<CineApiLog> CineApiLogs { get; set; }

    public virtual DbSet<TipoProduccionCategorium> TipoProduccionCategoria { get; set; }

    public virtual DbSet<Tramite> Tramites { get; set; }

    public virtual DbSet<TramiteTipo> TramiteTipos { get; set; }

    public virtual DbSet<TramitesClasificacion> TramitesClasificacions { get; set; }

    public virtual DbSet<TramitesClasificacionActum> TramitesClasificacionActa { get; set; }

    public virtual DbSet<TramitesClasificacionNacionalidad> TramitesClasificacionNacionalidads { get; set; }

    public virtual DbSet<TramitesClasificacionNivel> TramitesClasificacionNivels { get; set; }

    public virtual DbSet<TramitesClasificacionTipoVisualizacion> TramitesClasificacionTipoVisualizacions { get; set; }

    public virtual DbSet<TramitesEstado> TramitesEstados { get; set; }

    public virtual DbSet<TramitesPersona> TramitesPersonas { get; set; }

    public virtual DbSet<TramitesProducto> TramitesProductos { get; set; }

    public virtual DbSet<TramitesProyecto> TramitesProyectos { get; set; }

    public virtual DbSet<VwAplicacionesPermiso> VwAplicacionesPermisos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agente>(entity =>
        {
            entity.HasIndex(e => e.Identificacion, "Index_Agentes_1").IsUnique();

            entity.Property(e => e.Celular)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.HistorialJson).IsUnicode(false);
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Municipio).WithMany(p => p.Agentes)
                .HasForeignKey(d => d.MunicipioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Agentes_AplicacionesMunicipios");

            entity.HasOne(d => d.TipoIdentificacion).WithMany(p => p.Agentes)
                .HasForeignKey(d => d.TipoIdentificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Agentes_AplicacionesTipoIdentificacion");

            entity.HasOne(d => d.TipoPersona).WithMany(p => p.Agentes)
                .HasForeignKey(d => d.TipoPersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Agentes_AplicacionesTipoPersona");
        });

        modelBuilder.Entity<AgentesConsejoDepartamental>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07DA38A229");

            entity.ToTable("AgentesConsejoDepartamental");

            entity.HasIndex(e => e.MunicipioId, "fk_ConsejoDepartamental_AplicacionesMunicipios1_idx");

            entity.HasOne(d => d.Agente).WithMany(p => p.AgentesConsejoDepartamentals)
                .HasForeignKey(d => d.AgenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsejoDepartamental_Agentes");
        });

        modelBuilder.Entity<AgentesEtnium>(entity =>
        {
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");

            entity.HasOne(d => d.Agente).WithMany(p => p.AgentesEtnia)
                .HasForeignKey(d => d.AgenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesEtnia_Agentes");

            entity.HasOne(d => d.Etnia).WithMany(p => p.AgentesEtnia)
                .HasForeignKey(d => d.EtniaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesEtnia_AplicacionesEtnia");
        });

        modelBuilder.Entity<AgentesGenero>(entity =>
        {
            entity.ToTable("AgentesGenero");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");

            entity.HasOne(d => d.Agente).WithMany(p => p.AgentesGeneros)
                .HasForeignKey(d => d.AgenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesGenero_Agentes");

            entity.HasOne(d => d.Genero).WithMany(p => p.AgentesGeneros)
                .HasForeignKey(d => d.GeneroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesGenero_AplicacionesGenero");
        });

        modelBuilder.Entity<AgentesGrupoPoblacional>(entity =>
        {
            entity.ToTable("AgentesGrupoPoblacional");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");

            entity.HasOne(d => d.Agente).WithMany(p => p.AgentesGrupoPoblacionals)
                .HasForeignKey(d => d.AgenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesGrupoPoblacional_Agentes");

            entity.HasOne(d => d.GrupoPoblacional).WithMany(p => p.AgentesGrupoPoblacionals)
                .HasForeignKey(d => d.GrupoPoblacionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesGrupoPoblacional_AplicacionesGrupoPoblacional");
        });

        modelBuilder.Entity<AgentesJuridico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AgentesJ__3214EC0752B466C4");

            entity.Property(e => e.DigitoVerificacion)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UrlPaginaWeb)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Agente).WithMany(p => p.AgentesJuridicos)
                .HasForeignKey(d => d.AgenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesJuridicos_Agentes");

            entity.HasOne(d => d.JuridicoTipo).WithMany(p => p.AgentesJuridicos)
                .HasForeignKey(d => d.JuridicoTipoId)
                .HasConstraintName("FK_AgentesJuridicos_AgentesJuridicosTipos");
        });

        modelBuilder.Entity<AgentesJuridicosRepresentanteLegal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_JuridicoRepresentanteLegal");

            entity.ToTable("AgentesJuridicosRepresentanteLegal");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Juridico).WithMany(p => p.AgentesJuridicosRepresentanteLegals)
                .HasForeignKey(d => d.JuridicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesJuridicosRepresentanteLegal_AgentesJuridicos");

            entity.HasOne(d => d.TipoIdentificacion).WithMany(p => p.AgentesJuridicosRepresentanteLegals)
                .HasForeignKey(d => d.TipoIdentificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JuridicoRepresentanteLegal_AplicacionesTipoIdentificacion");
        });

        modelBuilder.Entity<AgentesJuridicosTipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_JuridicoTipo");

            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentesNaturale>(entity =>
        {
            entity.Property(e => e.Apellidos)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.Nombres)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.Agente).WithMany(p => p.AgentesNaturales)
                .HasForeignKey(d => d.AgenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesNaturales_Agentes");
        });

        modelBuilder.Entity<AgentesProfesion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AplicacionesPersonasProfesion");

            entity.ToTable("AgentesProfesion");

            entity.HasIndex(e => e.AgenteId, "fk_AplicacionesPersonas_has_AplicacionesProfesion_AplicacionesPer_idx");

            entity.HasIndex(e => e.ProfesionId, "fk_AplicacionesPersonas_has_AplicacionesProfesion_AplicacionesPro_idx");

            entity.HasOne(d => d.Agente).WithMany(p => p.AgentesProfesions)
                .HasForeignKey(d => d.AgenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesProfesion_Agentes");

            entity.HasOne(d => d.Profesion).WithMany(p => p.AgentesProfesions)
                .HasForeignKey(d => d.ProfesionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesPersonasProfesion_AplicacionesProfesion");
        });

        modelBuilder.Entity<AgentesTipo>(entity =>
        {
            entity.Property(e => e.AgenteTipo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentesTiposAgente>(entity =>
        {
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");

            entity.HasOne(d => d.Agente).WithMany(p => p.AgentesTiposAgentes)
                .HasForeignKey(d => d.AgenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesTiposAgentes_Agentes");

            entity.HasOne(d => d.AgenteTipo).WithMany(p => p.AgentesTiposAgentes)
                .HasForeignKey(d => d.AgenteTipoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesTiposAgentes_AgentesTipos");
        });

        modelBuilder.Entity<AgentesTiposAgentesPersona>(entity =>
        {
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");

            entity.HasOne(d => d.AgentesTipoAgente).WithMany(p => p.AgentesTiposAgentesPersonas)
                .HasForeignKey(d => d.AgentesTipoAgenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesTiposAgentesPersonas_AgentesTiposAgentes");

            entity.HasOne(d => d.Persona).WithMany(p => p.AgentesTiposAgentesPersonas)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentesTiposAgentesPersonas_AplicacionesPersonas");
        });

        modelBuilder.Entity<Aplicacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC07C4DBFC67");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesAccione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC076CDD9CE5");

            entity.Property(e => e.Accion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesDatosUsuariosInterno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC0792EA9291");

            entity.HasIndex(e => e.AplicacionPersonasId, "fk_AplicacionesDatosUsuariosInternos_AplicacionesUsuarios1_idx");

            entity.Property(e => e.Cargo)
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.HasOne(d => d.AplicacionPersonas).WithMany(p => p.AplicacionesDatosUsuariosInternos)
                .HasForeignKey(d => d.AplicacionPersonasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesDatosUsuariosInternos_AplicacionesPersonas");
        });

        modelBuilder.Entity<AplicacionesDepartamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC07AE8038BD");

            entity.HasIndex(e => e.Codigo, "Codigo_UNIQUE").IsUnique();

            entity.HasIndex(e => e.PaisId, "fk_Departamento_Pais1_idx");

            entity.Property(e => e.Departamento)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Pais).WithMany(p => p.AplicacionesDepartamentos)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesDepartamentos_AplicacionesPaises");
        });

        modelBuilder.Entity<AplicacionesEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC0796FE1387");

            entity.Property(e => e.Estado)
                .HasMaxLength(75)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesEtnium>(entity =>
        {
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.GrupoEtnico)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesFormatoRodaje>(entity =>
        {
            entity.ToTable("AplicacionesFormatoRodaje");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FormatoRodaje).HasMaxLength(100);

            entity.HasOne(d => d.TipoFormato).WithMany(p => p.AplicacionesFormatoRodajes)
                .HasForeignKey(d => d.TipoFormatoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesFormatoRodaje_AplicacionesTipoFormatoRodaje");
        });

        modelBuilder.Entity<AplicacionesGenero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC0713E5C360");

            entity.ToTable("AplicacionesGenero");

            entity.Property(e => e.Genero)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesGeneroObra>(entity =>
        {
            entity.ToTable("AplicacionesGeneroObra");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesGrupoPoblacional>(entity =>
        {
            entity.ToTable("AplicacionesGrupoPoblacional");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.GrupoPoblacional)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesIdioma>(entity =>
        {
            entity.ToTable("AplicacionesIdioma");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Idioma)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesLenguaNativa>(entity =>
        {
            entity.ToTable("AplicacionesLenguaNativa");

            entity.Property(e => e.LenguaNativa)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC073F5AA2E3");

            entity.ToTable("AplicacionesLogin");

            entity.HasIndex(e => e.AplicacionPersonaId, "fk_AplicacionesLogin_AplicacionesUsuario_idx");

            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.AplicacionPersona).WithMany(p => p.AplicacionesLogins)
                .HasForeignKey(d => d.AplicacionPersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesLogin_AplicacionesPersonas");
        });

        modelBuilder.Entity<AplicacionesModulo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC07C4D9AA20");

            entity.Property(e => e.Modulo)
                .HasMaxLength(75)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesModulosEstadosAccione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC07430FC383");

            entity.HasIndex(e => e.AplicacionesAccionId, "fk_AplicacionesModulosEstadosAcciones_AplicacionesAccione_idx");

            entity.HasIndex(e => e.AplicacionesEstadoId, "fk_AplicacionesModulosEstadosAcciones_AplicacionesEstados1_idx");

            entity.HasIndex(e => e.AplicacionesModulosPerfilId, "fk_AplicacionesModulosEstadosAcciones_AplicacionesModulos_idx");

            entity.HasOne(d => d.AplicacionesAccion).WithMany(p => p.AplicacionesModulosEstadosAcciones)
                .HasForeignKey(d => d.AplicacionesAccionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesModulosEstadosAcciones_AplicacionesAcciones");

            entity.HasOne(d => d.AplicacionesEstado).WithMany(p => p.AplicacionesModulosEstadosAcciones)
                .HasForeignKey(d => d.AplicacionesEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesModulosEstadosAcciones_AplicacionesEstados");

            entity.HasOne(d => d.AplicacionesModulosPerfil).WithMany(p => p.AplicacionesModulosEstadosAcciones)
                .HasForeignKey(d => d.AplicacionesModulosPerfilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesModulosEstadosAcciones_AplicacionesModulosPerfiles");
        });

        modelBuilder.Entity<AplicacionesModulosPerfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC07073E2479");

            entity.HasIndex(e => e.AplicacionId, "fk_AplicacionesModulosPerfiles_Aplicaciones1_idx");

            entity.HasIndex(e => e.AplicacionesModuloId, "fk_AplicacionesModulosPerfiles_AplicacionesModulos1_idx");

            entity.HasIndex(e => e.AplicacionesPerfilId, "fk_AplicacionesModulosPerfiles_AplicacionesPerfiles1_idx");

            entity.HasOne(d => d.Aplicacion).WithMany(p => p.AplicacionesModulosPerfiles)
                .HasForeignKey(d => d.AplicacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesModulosPerfiles_Aplicaciones");

            entity.HasOne(d => d.AplicacionesModulo).WithMany(p => p.AplicacionesModulosPerfiles)
                .HasForeignKey(d => d.AplicacionesModuloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesModulosPerfiles_AplicacionesModulos");

            entity.HasOne(d => d.AplicacionesPerfil).WithMany(p => p.AplicacionesModulosPerfiles)
                .HasForeignKey(d => d.AplicacionesPerfilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesModulosPerfiles_AplicacionesPerfiles");
        });

        modelBuilder.Entity<AplicacionesModulosPerfilesAplicacionLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC07FA681B24");

            entity.ToTable("AplicacionesModulosPerfilesAplicacionLogin");

            entity.HasIndex(e => e.AplicacionLoginId, "fk_AplicacionesModulosPerfiles_has_AplicacionLogin_Aplicac_idx");

            entity.HasIndex(e => e.AplicacionesModulosPerfilId, "fk_AplicacionesModulosPerfiles_has_AplicacionLogin_Aplicia_idx");

            entity.HasOne(d => d.AplicacionLogin).WithMany(p => p.AplicacionesModulosPerfilesAplicacionLogins)
                .HasForeignKey(d => d.AplicacionLoginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesModulosPerfilesAplicacionLogin_AplicacionesLogin");

            entity.HasOne(d => d.AplicacionesModulosPerfil).WithMany(p => p.AplicacionesModulosPerfilesAplicacionLogins)
                .HasForeignKey(d => d.AplicacionesModulosPerfilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesModulosPerfilesAplicacionLogin_AplicacionesModulosPerfiles");
        });

        modelBuilder.Entity<AplicacionesMonedum>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesMunicipio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC070AC4058D");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Departamento).WithMany(p => p.AplicacionesMunicipios)
                .HasForeignKey(d => d.DepartamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesMunicipios_AplicacionesDepartamentos");
        });

        modelBuilder.Entity<AplicacionesPaise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0757658D97");

            entity.HasIndex(e => e.CodigoIso, "CodigoISO_UNIQUE").IsUnique();

            entity.HasIndex(e => e.Pais, "Pais_UNIQUE").IsUnique();

            entity.Property(e => e.CodigoIso)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CodigoISO");
            entity.Property(e => e.CodigoTelefonico)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaisEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PaisEN");
        });

        modelBuilder.Entity<AplicacionesPerfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC0778AFC216");

            entity.Property(e => e.Perfil)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesPersona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC07E940D5E8");

            entity.HasIndex(e => e.Identificacion, "Identificacion_UNIQUE").IsUnique();

            entity.HasIndex(e => e.AplicacionTipoIdentificacionId, "fk_AplicacionesUsuario_AplicacionesTipoIdentificacion1_idx");

            entity.HasIndex(e => e.AplicacionGeneroId, "fk_AplicacionesUsuarios_AplicacionesGenero1_idx");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.HistorialJson).HasColumnName("HistorialJSON");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.AplicacionGenero).WithMany(p => p.AplicacionesPersonas)
                .HasForeignKey(d => d.AplicacionGeneroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesPersonas_AplicacionesGenero");

            entity.HasOne(d => d.AplicacionMunicipio).WithMany(p => p.AplicacionesPersonas)
                .HasForeignKey(d => d.AplicacionMunicipioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesPersonas_AplicacionesMunicipios");

            entity.HasOne(d => d.AplicacionTipoIdentificacion).WithMany(p => p.AplicacionesPersonas)
                .HasForeignKey(d => d.AplicacionTipoIdentificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesPersonas_AplicacionesTipoIdentificacion");
        });

        modelBuilder.Entity<AplicacionesProfesion>(entity =>
        {
            entity.ToTable("AplicacionesProfesion");

            entity.HasIndex(e => e.Profesion, "Profesion_UNIQUE").IsUnique();

            entity.Property(e => e.Profesion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesSubGenero>(entity =>
        {
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.SubGenero)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.GeneroObra).WithMany(p => p.AplicacionesSubGeneros)
                .HasForeignKey(d => d.GeneroObraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionesSubGeneros_AplicacionesGeneroObra");
        });

        modelBuilder.Entity<AplicacionesTipoDuracionProyeccion>(entity =>
        {
            entity.ToTable("AplicacionesTipoDuracionProyeccion");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
        });

        modelBuilder.Entity<AplicacionesTipoFormatoRodaje>(entity =>
        {
            entity.ToTable("AplicacionesTipoFormatoRodaje");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.TipoFormato)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesTipoIdentificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC07838D5F5E");

            entity.ToTable("AplicacionesTipoIdentificacion");

            entity.Property(e => e.TipoIdentificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesTipoPelicula>(entity =>
        {
            entity.ToTable("AplicacionesTipoPelicula");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.TipoPelicula)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionesTipoPersona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC07713EE971");

            entity.ToTable("AplicacionesTipoPersona");

            entity.Property(e => e.TipoPersona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CineApiLog>(entity =>
        {
            entity.ToTable("CineApiLog");

            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoProduccionCategorium>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TipoCategoria)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tramite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07D39DE941");

            entity.HasIndex(e => e.LoginId, "fk_Tramites_AplicacionesLogin1_idx");

            entity.HasIndex(e => e.TramiteTipoId, "fk_Tramites_TipoTramite1_idx");

            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");

            entity.HasOne(d => d.AgentesTipoAgente).WithMany(p => p.Tramites)
                .HasForeignKey(d => d.AgentesTipoAgenteId)
                .HasConstraintName("FK_Tramites_AgentesTiposAgentes");

            entity.HasOne(d => d.Login).WithMany(p => p.Tramites)
                .HasForeignKey(d => d.LoginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tramites_AplicacionesLogin");

            entity.HasOne(d => d.TramiteTipo).WithMany(p => p.Tramites)
                .HasForeignKey(d => d.TramiteTipoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tramites_TramiteTipo");
        });

        modelBuilder.Entity<TramiteTipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TramiteT__3214EC0776AF49CF");

            entity.ToTable("TramiteTipo");

            entity.HasIndex(e => e.Tipo, "Tipo_UNIQUE").IsUnique();

            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TramitesClasificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0735EBC062");

            entity.ToTable("TramitesClasificacion");

            entity.HasIndex(e => e.TramiteId, "fk_Clasificacion_Tramites1_idx");

            entity.HasIndex(e => e.ProductoId, "fk_TramitesClasificacion_TramitesProducto1_idx");

            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.FichaTecnica).IsUnicode(false);
            entity.Property(e => e.MontoCancelado).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.Sinopsis).IsUnicode(false);
            entity.Property(e => e.TieneKdm).HasColumnName("TieneKDM");
            entity.Property(e => e.TituloEspañol)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TituloOriginal)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.FormatoRodaje).WithMany(p => p.TramitesClasificacions)
                .HasForeignKey(d => d.FormatoRodajeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacion_AplicacionesFormatoRodaje");

            entity.HasOne(d => d.GeneroObra).WithMany(p => p.TramitesClasificacions)
                .HasForeignKey(d => d.GeneroObraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacion_AplicacionesGeneroObra");

            entity.HasOne(d => d.Moneda).WithMany(p => p.TramitesClasificacions)
                .HasForeignKey(d => d.MonedaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacion_AplicacionesMoneda");

            entity.HasOne(d => d.Producto).WithMany(p => p.TramitesClasificacions)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_TramitesClasificacion_TramitesProducto");

            entity.HasOne(d => d.TipoDuracionProyeccion).WithMany(p => p.TramitesClasificacions)
                .HasForeignKey(d => d.TipoDuracionProyeccionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacion_AplicacionesTipoDuracionProyeccion");

            entity.HasOne(d => d.TipoPelicula).WithMany(p => p.TramitesClasificacions)
                .HasForeignKey(d => d.TipoPeliculaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacion_AplicacionesTipoPelicula");

            entity.HasOne(d => d.TipoVisualizacion).WithMany(p => p.TramitesClasificacions)
                .HasForeignKey(d => d.TipoVisualizacionId)
                .HasConstraintName("FK_TramitesClasificacion_TramitesClasificacionTipoVisualizacion");

            entity.HasOne(d => d.Tramite).WithMany(p => p.TramitesClasificacions)
                .HasForeignKey(d => d.TramiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacion_Tramites");
        });

        modelBuilder.Entity<TramitesClasificacionActum>(entity =>
        {
            entity.Property(e => e.FechaClasificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEstreno).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.Clasificacion).WithMany(p => p.TramitesClasificacionActa)
                .HasForeignKey(d => d.ClasificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacionActa_TramitesClasificacion");

            entity.HasOne(d => d.Nivel).WithMany(p => p.TramitesClasificacionActa)
                .HasForeignKey(d => d.NivelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacionActa_TramitesClasificacionNivel");
        });

        modelBuilder.Entity<TramitesClasificacionNacionalidad>(entity =>
        {
            entity.ToTable("TramitesClasificacionNacionalidad");

            entity.HasOne(d => d.Pais).WithMany(p => p.TramitesClasificacionNacionalidads)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacionNacionalidad_AplicacionesPaises");

            entity.HasOne(d => d.TramiteClasificacion).WithMany(p => p.TramitesClasificacionNacionalidads)
                .HasForeignKey(d => d.TramiteClasificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesClasificacionNacionalidad_TramitesClasificacion");
        });

        modelBuilder.Entity<TramitesClasificacionNivel>(entity =>
        {
            entity.ToTable("TramitesClasificacionNivel");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.Nivel)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TramitesClasificacionTipoVisualizacion>(entity =>
        {
            entity.ToTable("TramitesClasificacionTipoVisualizacion");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.TipoVisualizacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TramitesEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tramites__3214EC074AD7C854");

            entity.HasIndex(e => e.TramiteId, "fk_TramitesEstados_Tramites1_idx");

            entity.HasOne(d => d.Tramite).WithMany(p => p.TramitesEstados)
                .HasForeignKey(d => d.TramiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesEstados_Tramites");
        });

        modelBuilder.Entity<TramitesPersona>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.AgentesProfesion).WithMany(p => p.TramitesPersonas)
                .HasForeignKey(d => d.AgentesProfesionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesPersonas_AplicacionesPersonasProfesion");

            entity.HasOne(d => d.Tramites).WithMany(p => p.TramitesPersonas)
                .HasForeignKey(d => d.TramitesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesPersonas_Tramites");
        });

        modelBuilder.Entity<TramitesProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tramites__3214EC070CB19A08");

            entity.ToTable("TramitesProducto");

            entity.HasIndex(e => e.TramiteId, "fk_Producto_Tramites1_idx");

            entity.HasIndex(e => e.ProyectoId, "fk_TramitesProducto_TramitesProyecto1_idx");

            entity.Property(e => e.ComentariosAdicionalesProduccion).IsUnicode(false);
            entity.Property(e => e.CostoTotalDesarrolloProduccion).HasColumnType("money");
            entity.Property(e => e.CostoTotalPosProduccion).HasColumnType("money");
            entity.Property(e => e.CostoTotalPreProduccion).HasColumnType("money");
            entity.Property(e => e.CostoTotalProduccion).HasColumnType("money");
            entity.Property(e => e.CostoTotalPromocionProduccion).HasColumnType("money");
            entity.Property(e => e.NombreProduccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesFechaFilmacion).IsUnicode(false);
            entity.Property(e => e.Sinopsis).IsUnicode(false);

            entity.HasOne(d => d.Proyecto).WithMany(p => p.TramitesProductos)
                .HasForeignKey(d => d.ProyectoId)
                .HasConstraintName("FK_TramitesProducto_TramitesProyecto");

            entity.HasOne(d => d.TipoProduccionCategoria).WithMany(p => p.TramitesProductos)
                .HasForeignKey(d => d.TipoProduccionCategoriaId)
                .HasConstraintName("FK_TramitesProducto_TipoProduccionCategoria");

            entity.HasOne(d => d.Tramite).WithMany(p => p.TramitesProductos)
                .HasForeignKey(d => d.TramiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesProducto_Tramites");
        });

        modelBuilder.Entity<TramitesProyecto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tramites__3214EC07EB6C491A");

            entity.ToTable("TramitesProyecto");

            entity.HasIndex(e => e.TramiteId, "fk_table1_Tramites1_idx");

            entity.HasOne(d => d.Tramite).WithMany(p => p.TramitesProyectos)
                .HasForeignKey(d => d.TramiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TramitesProyecto_Tramites");
        });

        modelBuilder.Entity<VwAplicacionesPermiso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_AplicacionesPermisos");

            entity.Property(e => e.Accion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Aplicacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Modulo)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Perfil)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
