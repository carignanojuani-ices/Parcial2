namespace WinFormsApp
{
    partial class FrmAltaCancion
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

        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblDuracion;
        private NumericUpDown numDuracion;
        private Label lblArtista;
        private ComboBox cmbArtistas;
        private Button btnGuardar;
        private Button btnCerrar;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblDuracion = new Label();
            numDuracion = new NumericUpDown();
            lblArtista = new Label();
            cmbArtistas = new ComboBox();
            btnGuardar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(12, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(130, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título de la canción:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(148, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(220, 23);
            txtTitulo.TabIndex = 1;
            // 
            // lblDuracion
            // 
            lblDuracion.Location = new Point(12, 48);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(130, 23);
            lblDuracion.TabIndex = 2;
            lblDuracion.Text = "Duración (segundos):";
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(148, 45);
            numDuracion.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(220, 23);
            numDuracion.TabIndex = 3;
            // 
            // lblArtista
            // 
            lblArtista.Location = new Point(12, 81);
            lblArtista.Name = "lblArtista";
            lblArtista.Size = new Size(130, 23);
            lblArtista.TabIndex = 4;
            lblArtista.Text = "Artista:";
            // 
            // cmbArtistas
            // 
            cmbArtistas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArtistas.Location = new Point(148, 78);
            cmbArtistas.Name = "cmbArtistas";
            cmbArtistas.Size = new Size(220, 23);
            cmbArtistas.TabIndex = 5;
            cmbArtistas.SelectedIndexChanged += cmbArtistas_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(148, 150);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(268, 150);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmAltaCancion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 212);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(lblDuracion);
            Controls.Add(numDuracion);
            Controls.Add(lblArtista);
            Controls.Add(cmbArtistas);
            Controls.Add(btnGuardar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAltaCancion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alta de Canción";
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
