using AccesoDatos.Repositories;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;

public class CancionRepository : GenericRepository<Cancion>
{
    public List<Cancion> ObtenerCancionesMasLargas()
    {
        return _context.Cancion
                       .OrderByDescending(c => c.DuracionSegundos)
                       .Include(c => c.Artista)
                       .ToList();
    }

    public int ObtenerCantidadCanciones()
    {
        return _context.Cancion
                       .Count();
    }

    public List<Cancion> ObtenerCancionesOrdenadasPorTitulo()
    {
        return _context.Cancion
                       .OrderBy(c => c.Titulo)
                       .ToList();
    }

    public bool ExistenCanciones()
    {
        return _context.Cancion
                       .Any();
    }
}