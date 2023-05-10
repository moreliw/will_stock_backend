using Microsoft.EntityFrameworkCore;

namespace will_stock_backend
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
        //    services.AddDbContext<MeuProjetoContext>(options =>
        //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        //    services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configuração da pipeline de requisição da aplicação
        }
    }
}
