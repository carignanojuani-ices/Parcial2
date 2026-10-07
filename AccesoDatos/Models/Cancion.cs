using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Models
{
    public class Cancion
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int DuracionSegundos { get; set; }

        // Foreign Key
        public int ArtistaId { get; set; }

        // Propiedad de navegación
        public Artista Artista { get; set; }
    }
}
