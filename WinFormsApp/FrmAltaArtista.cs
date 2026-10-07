using AccesoDatos.Models;
using AccesoDatos.Repositories;

namespace WinFormsApp
{
    public partial class FrmAltaArtista : Form
    {
        private readonly IGenericRepository<Artista> artistaRepository = new GenericRepository<Artista>();

        public FrmAltaArtista()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar el nombre del artista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var artista = new Artista
            {
                Nombre = nombre
            };

            artistaRepository.Agregar(artista);

            MessageBox.Show("Artista registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
