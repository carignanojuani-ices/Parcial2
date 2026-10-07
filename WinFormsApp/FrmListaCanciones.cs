using AccesoDatos.Models;

namespace WinFormsApp
{
    public partial class FrmListaCanciones : Form
    {
        private readonly Func<List<Cancion>> obtenerCanciones;

        public FrmListaCanciones(string titulo, Func<List<Cancion>> obtenerCanciones)
        {
            InitializeComponent();
            this.obtenerCanciones = obtenerCanciones;
            Text = titulo;
            lblTitulo.Text = titulo;
            CargarDatos();
        }

        private void CargarDatos()
        {
            var canciones = obtenerCanciones();

            dgvCanciones.DataSource = canciones
                .Select(c => new
                {
                    c.Titulo,
                    Duracion = c.DuracionSegundos,
                    Artista = c.Artista != null ? c.Artista.Nombre : string.Empty
                })
                .ToList();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCanciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
