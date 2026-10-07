using AccesoDatos.Models;
using AccesoDatos.Repositories;

namespace WinFormsApp
{
    public partial class FrmAltaCancion : Form
    {
        private readonly IGenericRepository<Artista> artistaRepository = new GenericRepository<Artista>();
        private readonly CancionRepository cancionRepository = new CancionRepository();

        public FrmAltaCancion()
        {
            InitializeComponent();
            CargarArtistas();
        }

        private void CargarArtistas()
        {
            cmbArtistas.DisplayMember = "Nombre";
            cmbArtistas.ValueMember = "Id";
            cmbArtistas.DataSource = artistaRepository.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Debe ingresar el título de la canción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbArtistas.SelectedValue is not int artistaId)
            {
                MessageBox.Show("Debe seleccionar un artista. Registre un artista primero si no hay ninguno.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cancion = new Cancion
            {
                Titulo = titulo,
                DuracionSegundos = (int)numDuracion.Value,
                ArtistaId = artistaId
            };

            cancionRepository.Agregar(cancion);

            MessageBox.Show("Canción registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitulo.Clear();
            numDuracion.Value = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
