namespace WinFormsApp
{
    partial class FrmMenuInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private Button btnAltaArtista;
        private Button btnAltaCancion;
        private Button btnVerCanciones;
        private Button btnCancionesMasLargas;
        private Button btnCantidadCanciones;
        private Button btnCancionesOrdenadas;
        private Button btnVerificarCanciones;
        private Button btnSalir;
        private Label lblTitulo;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnAltaArtista = new Button();
            btnAltaCancion = new Button();
            btnVerCanciones = new Button();
            btnCancionesMasLargas = new Button();
            btnCantidadCanciones = new Button();
            btnCancionesOrdenadas = new Button();
            btnVerificarCanciones = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE MUSICA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAltaArtista
            // 
            btnAltaArtista.Location = new Point(12, 56);
            btnAltaArtista.Name = "btnAltaArtista";
            btnAltaArtista.Size = new Size(360, 35);
            btnAltaArtista.TabIndex = 1;
            btnAltaArtista.Text = "1. Alta artista";
            btnAltaArtista.Click += btnAltaArtista_Click;
            // 
            // btnAltaCancion
            // 
            btnAltaCancion.Location = new Point(12, 97);
            btnAltaCancion.Name = "btnAltaCancion";
            btnAltaCancion.Size = new Size(360, 35);
            btnAltaCancion.TabIndex = 2;
            btnAltaCancion.Text = "2. Alta canción";
            btnAltaCancion.Click += btnAltaCancion_Click;
            // 
            // btnVerCanciones
            // 
            btnVerCanciones.Location = new Point(12, 148);
            btnVerCanciones.Name = "btnVerCanciones";
            btnVerCanciones.Size = new Size(360, 35);
            btnVerCanciones.TabIndex = 3;
            btnVerCanciones.Text = "3. Ver canciones";
            btnVerCanciones.Click += btnVerCanciones_Click;
            // 
            // btnCancionesMasLargas
            // 
            btnCancionesMasLargas.Location = new Point(12, 189);
            btnCancionesMasLargas.Name = "btnCancionesMasLargas";
            btnCancionesMasLargas.Size = new Size(360, 35);
            btnCancionesMasLargas.TabIndex = 4;
            btnCancionesMasLargas.Text = "4. Mostrar canciones más largas";
            btnCancionesMasLargas.Click += btnCancionesMasLargas_Click;
            // 
            // btnCantidadCanciones
            // 
            btnCantidadCanciones.Location = new Point(12, 230);
            btnCantidadCanciones.Name = "btnCantidadCanciones";
            btnCantidadCanciones.Size = new Size(360, 35);
            btnCantidadCanciones.TabIndex = 5;
            btnCantidadCanciones.Text = "5. Cantidad total de canciones";
            btnCantidadCanciones.Click += btnCantidadCanciones_Click;
            // 
            // btnCancionesOrdenadas
            // 
            btnCancionesOrdenadas.Location = new Point(12, 271);
            btnCancionesOrdenadas.Name = "btnCancionesOrdenadas";
            btnCancionesOrdenadas.Size = new Size(360, 35);
            btnCancionesOrdenadas.TabIndex = 6;
            btnCancionesOrdenadas.Text = "6. Canciones ordenadas por título";
            btnCancionesOrdenadas.Click += btnCancionesOrdenadas_Click;
            // 
            // btnVerificarCanciones
            // 
            btnVerificarCanciones.Location = new Point(12, 312);
            btnVerificarCanciones.Name = "btnVerificarCanciones";
            btnVerificarCanciones.Size = new Size(360, 35);
            btnVerificarCanciones.TabIndex = 7;
            btnVerificarCanciones.Text = "7. Verificar si existen canciones";
            btnVerificarCanciones.Click += btnVerificarCanciones_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 363);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(360, 35);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "0. Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenuInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 420);
            Controls.Add(lblTitulo);
            Controls.Add(btnAltaArtista);
            Controls.Add(btnAltaCancion);
            Controls.Add(btnVerCanciones);
            Controls.Add(btnCancionesMasLargas);
            Controls.Add(btnCantidadCanciones);
            Controls.Add(btnCancionesOrdenadas);
            Controls.Add(btnVerificarCanciones);
            Controls.Add(btnSalir);
            Name = "FrmMenuInicio";
            Text = "Sistema de Musica";
            ResumeLayout(false);
        }

        #endregion
    }
}
