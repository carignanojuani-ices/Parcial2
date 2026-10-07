namespace WinFormsApp
{
    partial class FrmAltaArtista
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnCerrar;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            //
            // lblNombre
            //
            lblNombre.Location = new Point(12, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 23);
            lblNombre.Text = "Nombre del artista:";
            //
            // txtNombre
            //
            txtNombre.Location = new Point(138, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            //
            // btnGuardar
            //
            btnGuardar.Location = new Point(138, 45);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnCerrar
            //
            btnCerrar.Location = new Point(258, 45);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            //
            // FrmAltaArtista
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 95);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(btnCerrar);
            Name = "FrmAltaArtista";
            Text = "Alta de Artista";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
