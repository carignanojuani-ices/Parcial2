namespace WinFormsApp
{
    partial class FrmListaCanciones
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
        private DataGridView dgvCanciones;
        private Button btnCerrar;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            dgvCanciones = new DataGridView();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCanciones).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(560, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCanciones
            // 
            dgvCanciones.AllowUserToAddRows = false;
            dgvCanciones.AllowUserToDeleteRows = false;
            dgvCanciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCanciones.Dock = DockStyle.Fill;
            dgvCanciones.Location = new Point(0, 32);
            dgvCanciones.Name = "dgvCanciones";
            dgvCanciones.ReadOnly = true;
            dgvCanciones.Size = new Size(560, 333);
            dgvCanciones.TabIndex = 0;
            dgvCanciones.CellContentClick += dgvCanciones_CellContentClick;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Bottom;
            btnCerrar.Location = new Point(0, 365);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(560, 35);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmListaCanciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 400);
            Controls.Add(dgvCanciones);
            Controls.Add(btnCerrar);
            Controls.Add(lblTitulo);
            Name = "FrmListaCanciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Canciones";
            ((System.ComponentModel.ISupportInitialize)dgvCanciones).EndInit();
            ResumeLayout(false);
        }
    }
}
