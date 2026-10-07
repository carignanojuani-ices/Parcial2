using AccesoDatos.Models;
using AccesoDatos.Repositories;

IGenericRepository<Artista> artistaRepository = new GenericRepository<Artista>();
CancionRepository cancionRepository = new CancionRepository();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("================================");
    Console.WriteLine(" SISTEMA DE MUSICA ");
    Console.WriteLine("================================");

    Console.WriteLine("1. Alta artista");
    Console.WriteLine("2. Alta canción");
    Console.WriteLine("");

    Console.WriteLine("3. Ver canciones");
    Console.WriteLine("4. Mostrar canciones más largas");
    Console.WriteLine("5. Cantidad total de canciones");
    Console.WriteLine("6. Mostrar canciones ordenadas alfabéticamente por título");
    Console.WriteLine("7. Verificar si existen canciones registradas");
    Console.WriteLine("");

    Console.WriteLine("0. Salir");

    Console.WriteLine();
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();

    Console.Clear();

    switch (opcion)
    {
        case "1":
            AltaArtista();
            break;

        case "2":
            AltaCancion();
            break;

        case "3":
            VerCanciones();
            break;

        case "4":
            MostrarCancionesMasLargas();
            break;

        case "5":
            MostrarCantidadCanciones();
            break;

        case "6":
            MostrarCancionesOrdenadas();
            break;

        case "7":
            VerificarCanciones();
            break;

        case "0":
            continuar = false;
            Console.WriteLine("Aplicación finalizada.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    Console.WriteLine();
}

void AltaArtista()
{
    Console.Write("Nombre del artista: ");

    Artista artista = new Artista
    {
        Nombre = Console.ReadLine()
    };

    artistaRepository.Agregar(artista);

    Console.WriteLine("Artista registrado correctamente.");
}

void AltaCancion()
{
    Console.Write("Título de la canción: ");
    string titulo = Console.ReadLine();

    Console.Write("Duración en segundos: ");
    int duracion = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Artistas disponibles:");

    foreach (var artista in artistaRepository.ObtenerTodos())
    {
        Console.WriteLine(
            $"{artista.Id} - {artista.Nombre}");
    }

    Console.WriteLine();
    Console.Write("Seleccione el ID del artista: ");

    int artistaId = int.Parse(Console.ReadLine());

    Cancion cancion = new Cancion
    {
        Titulo = titulo,
        DuracionSegundos = duracion,
        ArtistaId = artistaId
    };

    cancionRepository.Agregar(cancion);

    Console.WriteLine("Canción registrada correctamente.");
}

void VerCanciones()
{
    Console.WriteLine("===== CANCIONES =====");

    var canciones = cancionRepository.ObtenerTodosCon("Artista");

    foreach (var cancion in canciones)
    {
        Console.WriteLine(
            $"{cancion.Titulo} - " +
            $"{cancion.DuracionSegundos} seg - " +
            $"{cancion.Artista.Nombre}");
    }
}

void MostrarCancionesMasLargas()
{
    Console.WriteLine("===== CANCIONES MÁS LARGAS =====");

    foreach (var cancion in cancionRepository.ObtenerCancionesMasLargas())
    {
        Console.WriteLine(
            $"{cancion.Titulo} - {cancion.DuracionSegundos} seg");
    }
}

void MostrarCantidadCanciones()
{
    Console.WriteLine(
        $"Cantidad total de canciones: {cancionRepository.ObtenerCantidadCanciones()}");
}

void MostrarCancionesOrdenadas()
{
    Console.WriteLine("===== CANCIONES ORDENADAS =====");

    foreach (var cancion in cancionRepository.ObtenerCancionesOrdenadasPorTitulo())
    {
        Console.WriteLine(
            $"{cancion.Titulo} - {cancion.DuracionSegundos} seg");
    }
}

void VerificarCanciones()
{
    bool existen = cancionRepository.ExistenCanciones();

    if (existen)
    {
        Console.WriteLine("Existen canciones registradas.");
    }
    else
    {
        Console.WriteLine("No existen canciones registradas.");
    }
}