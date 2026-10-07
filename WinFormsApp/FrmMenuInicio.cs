using AccesoDatos.Repositories;

namespace WinFormsApp
{
    public partial class FrmMenuInicio : Form
    {
        private readonly CancionRepository cancionRepository = new CancionRepository();

        public FrmMenuInicio()
        {
            InitializeComponent();
        }

        private void btnAltaArtista_Click(object sender, EventArgs e)
        {
            using var frm = new FrmAltaArtista();
            frm.ShowDialog(this);
        }

        private void btnAltaCancion_Click(object sender, EventArgs e)
        {
            using var frm = new FrmAltaCancion();
            frm.ShowDialog(this);
        }

        private void btnVerCanciones_Click(object sender, EventArgs e)
        {
            using var frm = new FrmListaCanciones("CANCIONES", () => cancionRepository.ObtenerTodosCon("Artista"));
            frm.ShowDialog(this);
        }

        private void btnCancionesMasLargas_Click(object sender, EventArgs e)
        {
            using var frm = new FrmListaCanciones("CANCIONES MÁS LARGAS", () => cancionRepository.ObtenerCancionesMasLargas());
            frm.ShowDialog(this);
        }

        private void btnCantidadCanciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Cantidad total de canciones: {cancionRepository.ObtenerCantidadCanciones()}",
                "Cantidad total de canciones",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCancionesOrdenadas_Click(object sender, EventArgs e)
        {
            using var frm = new FrmListaCanciones("CANCIONES ORDENADAS POR TÍTULO", () => cancionRepository.ObtenerCancionesOrdenadasPorTitulo());
            frm.ShowDialog(this);
        }

        private void btnVerificarCanciones_Click(object sender, EventArgs e)
        {
            bool existen = cancionRepository.ExistenCanciones();

            MessageBox.Show(
                existen ? "Existen canciones registradas." : "No existen canciones registradas.",
                "Verificar canciones",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
