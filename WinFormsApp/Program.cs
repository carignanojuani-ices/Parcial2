using AccesoDatos.Models;
using AccesoDatos.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Registrar dependencias
            var services = new ServiceCollection();

            // Repositorys
            services.AddTransient<IGenericRepository<Artista>, GenericRepository<Artista>>();
            services.AddTransient<IGenericRepository<Cancion>, GenericRepository<Cancion>>();
            services.AddTransient<CancionRepository>();

            // Registrar el / los formularios.
            services.AddTransient<FrmMenuInicio>();
            services.AddTransient<FrmAltaArtista>();
            services.AddTransient<FrmAltaCancion>();

            // Construir y ejecutar
            var provider = services.BuildServiceProvider();
            Application.Run(provider.GetRequiredService<FrmMenuInicio>());
        }
    }
}

