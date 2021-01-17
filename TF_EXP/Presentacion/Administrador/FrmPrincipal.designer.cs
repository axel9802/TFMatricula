namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.lblCODIGO = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblNOMBRE = new System.Windows.Forms.Label();
            this.lblTIPO = new System.Windows.Forms.Label();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAsignaAlumno = new System.Windows.Forms.Button();
            this.btnAsignaProfe = new System.Windows.Forms.Button();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPrincipal.Controls.Add(this.BarraTitulo);
            this.panelPrincipal.Controls.Add(this.PanelContenedor);
            this.panelPrincipal.Controls.Add(this.MenuVertical);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(950, 542);
            this.panelPrincipal.TabIndex = 1;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BarraTitulo.Controls.Add(this.lbltitulo);
            this.BarraTitulo.Controls.Add(this.iconMinimizar);
            this.BarraTitulo.Controls.Add(this.iconCerrar);
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(950, 45);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(9, 6);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(99, 31);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "TÍTULO";
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Presentacion.Properties.Resources.icon_minimizar;
            this.iconMinimizar.Location = new System.Drawing.Point(880, 10);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMinimizar.TabIndex = 1;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = global::Presentacion.Properties.Resources.icon_cerrar2;
            this.iconCerrar.Location = new System.Drawing.Point(913, 10);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(215, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(735, 542);
            this.PanelContenedor.TabIndex = 2;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.MenuVertical.Controls.Add(this.btnHome);
            this.MenuVertical.Controls.Add(this.btnCrearCurso);
            this.MenuVertical.Controls.Add(this.btnAlumnos);
            this.MenuVertical.Controls.Add(this.btnDatos);
            this.MenuVertical.Controls.Add(this.lblCODIGO);
            this.MenuVertical.Controls.Add(this.btnLogOut);
            this.MenuVertical.Controls.Add(this.lblNOMBRE);
            this.MenuVertical.Controls.Add(this.lblTIPO);
            this.MenuVertical.Controls.Add(this.btnSlide);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.btnAsignaAlumno);
            this.MenuVertical.Controls.Add(this.btnAsignaProfe);
            this.MenuVertical.Controls.Add(this.btnProfesor);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(215, 542);
            this.MenuVertical.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Presentacion.Properties.Resources.Mobile_Menu_Icon;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::Presentacion.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(173, 54);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(35, 35);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 10;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.FlatAppearance.BorderSize = 0;
            this.btnCrearCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCurso.ForeColor = System.Drawing.Color.White;
            this.btnCrearCurso.Location = new System.Drawing.Point(3, 329);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnCrearCurso.Size = new System.Drawing.Size(212, 38);
            this.btnCrearCurso.TabIndex = 11;
            this.btnCrearCurso.Text = "Cursos";
            this.btnCrearCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.Location = new System.Drawing.Point(3, 288);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnAlumnos.Size = new System.Drawing.Size(212, 38);
            this.btnAlumnos.TabIndex = 10;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.FlatAppearance.BorderSize = 0;
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.ForeColor = System.Drawing.Color.White;
            this.btnDatos.Location = new System.Drawing.Point(3, 452);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnDatos.Size = new System.Drawing.Size(212, 38);
            this.btnDatos.TabIndex = 9;
            this.btnDatos.Text = "Datos";
            this.btnDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // lblCODIGO
            // 
            this.lblCODIGO.AutoSize = true;
            this.lblCODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCODIGO.ForeColor = System.Drawing.Color.White;
            this.lblCODIGO.Location = new System.Drawing.Point(41, 204);
            this.lblCODIGO.Name = "lblCODIGO";
            this.lblCODIGO.Size = new System.Drawing.Size(46, 15);
            this.lblCODIGO.TabIndex = 8;
            this.lblCODIGO.Text = "Codigo";
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(61, 497);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(93, 33);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Salir";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblNOMBRE
            // 
            this.lblNOMBRE.AutoSize = true;
            this.lblNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOMBRE.ForeColor = System.Drawing.Color.White;
            this.lblNOMBRE.Location = new System.Drawing.Point(41, 176);
            this.lblNOMBRE.Name = "lblNOMBRE";
            this.lblNOMBRE.Size = new System.Drawing.Size(58, 17);
            this.lblNOMBRE.TabIndex = 6;
            this.lblNOMBRE.Text = "Nombre";
            // 
            // lblTIPO
            // 
            this.lblTIPO.AutoSize = true;
            this.lblTIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIPO.ForeColor = System.Drawing.Color.White;
            this.lblTIPO.Location = new System.Drawing.Point(41, 227);
            this.lblTIPO.Name = "lblTIPO";
            this.lblTIPO.Size = new System.Drawing.Size(31, 15);
            this.lblTIPO.TabIndex = 1;
            this.lblTIPO.Text = "Tipo";
            // 
            // btnSlide
            // 
            this.btnSlide.BackgroundImage = global::Presentacion.Properties.Resources.Mobile_Menu_Icon;
            this.btnSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::Presentacion.Properties.Resources.Menu_Icon_Blanco;
            this.btnSlide.Location = new System.Drawing.Point(7, 54);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Perfil;
            this.pictureBox1.Location = new System.Drawing.Point(70, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnAsignaAlumno
            // 
            this.btnAsignaAlumno.FlatAppearance.BorderSize = 0;
            this.btnAsignaAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAsignaAlumno.Location = new System.Drawing.Point(3, 411);
            this.btnAsignaAlumno.Name = "btnAsignaAlumno";
            this.btnAsignaAlumno.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnAsignaAlumno.Size = new System.Drawing.Size(212, 38);
            this.btnAsignaAlumno.TabIndex = 4;
            this.btnAsignaAlumno.Text = "Asignar Alumno";
            this.btnAsignaAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignaAlumno.UseVisualStyleBackColor = true;
            this.btnAsignaAlumno.Click += new System.EventHandler(this.btnAsignaAlumno_Click);
            // 
            // btnAsignaProfe
            // 
            this.btnAsignaProfe.FlatAppearance.BorderSize = 0;
            this.btnAsignaProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaProfe.ForeColor = System.Drawing.Color.White;
            this.btnAsignaProfe.Location = new System.Drawing.Point(3, 370);
            this.btnAsignaProfe.Name = "btnAsignaProfe";
            this.btnAsignaProfe.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnAsignaProfe.Size = new System.Drawing.Size(212, 38);
            this.btnAsignaProfe.TabIndex = 3;
            this.btnAsignaProfe.Text = "Asignar Profesor";
            this.btnAsignaProfe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignaProfe.UseVisualStyleBackColor = true;
            this.btnAsignaProfe.Click += new System.EventHandler(this.btnAsignaProfe_Click);
            // 
            // btnProfesor
            // 
            this.btnProfesor.FlatAppearance.BorderSize = 0;
            this.btnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesor.ForeColor = System.Drawing.Color.White;
            this.btnProfesor.Location = new System.Drawing.Point(3, 247);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnProfesor.Size = new System.Drawing.Size(212, 38);
            this.btnProfesor.TabIndex = 1;
            this.btnProfesor.Text = "Profesores";
            this.btnProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 542);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Button btnAsignaAlumno;
        private System.Windows.Forms.Button btnAsignaProfe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNOMBRE;
        private System.Windows.Forms.Label lblTIPO;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblCODIGO;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.PictureBox btnHome;
    }
}