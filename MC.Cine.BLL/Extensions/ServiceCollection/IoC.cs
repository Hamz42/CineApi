using MC.Cine.BLL.Interfaces.Common.Base;
using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Repository.Base;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Base;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.BLL.Persistence.Repository.Base;
using MC.Cine.BLL.Persistence.Services;
using MC.Cine.Utils.EmailManager;
using MC.Cine.Utils.EmailManager.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace MC.Cine.BLL.Extensions.ServiceCollection
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services, IConfiguration configuration)
        {

            //Unit Of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Repositorios genericos
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            //Repositorios
            services.AddTransient<IAutenticacionRepository, AutenticacionRepository>();
            //services.AddTransient<IPerfilRepository, PerfilRepository>();
            //services.AddTransient<IEtniaRepository, EtniaRepository>();
            //services.AddTransient<IGeneroRepository, GeneroRepository>();
            //services.AddTransient<IGrupoPoblacionalRepository, GrupoPoblacionalRepository>();
            //services.AddTransient<ITipoDocumentoRepository, TipoDocumentoRepository>();
            //services.AddTransient<ITipoEmpresaRepository, TipoEmpresaRepository>();
            //services.AddTransient<ITipoProduccionRepository, TipoProduccionRepository>();
            //services.AddTransient<ITipoProductorRepository, TipoProductorRepository>();
            //services.AddTransient<IRegionRepository, RegionRepository>();
            //services.AddTransient<IProyectoRepository, ProyectoRepository>();
            services.AddTransient<IClasificacionRepository, ClasificacionRepository>();
            services.AddTransient<IPaisRepository, PaisRepository>();
            services.AddTransient<IIdentificacionRepository, IdentificacionRepository>(); 
            services.AddTransient<IGenerosRepository, GenerosRepository>();
            services.AddTransient<IPersonaRepository, PersonaRepository>();
            services.AddTransient<IGeneroObraRepository, GeneroObraRepository>();
            services.AddTransient<IMonedaRepository, MonedaRepository>();
            services.AddTransient<ITipoDuracionProyeccionRepository, TipoDuracionProyeccionRepository>();
            services.AddTransient<ITramitesClasificacionNivelRepository, TramitesClasificacionNivelRepository>();
            services.AddTransient<IEtniasRepository, EtniaRepository>();
            services.AddTransient<IGrupoPoblacionalRepository, GrupoPoblacionalRepository>();
            services.AddTransient<IJuridicoTipoRepository, JuridicoTipoRepository>();
            services.AddTransient<IDepartamentoRepository, DepartamentoRepository>();
            services.AddTransient<IMunicipioRepository, MunicipioRepository>();
            services.AddTransient<IAgentesRepository, AgentesRepository>();
            services.AddTransient<ITipoPeliculaRepository, TipoPeliculaRepository>();

            services.AddTransient<IEstadoRepository, EstadosRepository>();
            services.AddTransient<ISeguridadRepository, SeguridadRepository>();
            services.AddTransient<ITipoProduccionCategoriaRepository, TipoProduccionCategoriaRepository>();


            //Servicios
            services.AddTransient<IAutenticacionServices, AutenticacionServices>();
            //services.AddTransient<IEtniaServices, EtniaServices>();
            //services.AddTransient<IGeneroServices, GeneroServices>();
            //services.AddTransient<IGrupoPoblacionalServices, GrupoPoblacionalServices>();
            //services.AddTransient<ITipoDocumentoServices, TipoDocumentoServices>();
            //services.AddTransient<ITipoEmpresaServices, TipoEmpresaServices>();
            //services.AddTransient<ITipoProduccionServices, TipoProduccionServices>();
            //services.AddTransient<ITipoProductorServices, TipoProductorServices>();
            //services.AddTransient<IRegionServices, RegionServices>();
            //services.AddTransient<IProyectoServices, ProyectoServices>();
            services.AddTransient<IClasificacionServices, ClasificacionServices>();
            services.AddTransient<IPaisesServices, PaisServices>();
            services.AddTransient<IIdentificacionServices, IdentificacionServices>();
            services.AddTransient<IGenerosServices, GenerosServices>();
            services.AddTransient<IPersonaServices, PersonaServices>();
            services.AddTransient<IGeneroObraServices, GeneroObraServices>();
            services.AddTransient<IMonedaServices, MonedaServices>();
            services.AddTransient<ITipoDuracionProyeccionServices, TipoDuracionProyeccionServices>();
            services.AddTransient<ITramitesClasificacionNivelServices, TramitesClasificacionNivelServices>();
            services.AddTransient<IEtniasServices, EtniaServices>();
            services.AddTransient<IGrupoPoblacionalServices, GrupoPoblacionalServices>();
            services.AddTransient<IJuridicoTipoServices, JuridicoTipoServices>();
            services.AddTransient<IDepartamentoServices, DepartamentoServices>();
            services.AddTransient<IMunicipioServices, MunicipioServices>();
            services.AddTransient<IAgentesServices, AgentesServices>();
            services.AddTransient<ITipoPeliculaServices, TipoPeliculaServices>();
            

            services.AddTransient<IEstadosServices, EstadosServices>();
            services.AddTransient<ISeguridadServices, SeguridadServices>();
            services.AddTransient<ITipoProduccionCategoriaServices, TipoProduccionCategoriaServices>();

            //Servicio de Email
            services.Configure<EmailOptions>(configuration.GetSection("Email"));
            services.AddSingleton<EmailSender>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowMyOrigin",
                    builder => builder.WithOrigins("http://localhost:4200")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod());
            });

            return services;
        }
    }
}
