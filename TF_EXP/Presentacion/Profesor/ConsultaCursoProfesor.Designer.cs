﻿namespace Presentacion
{
    partial class ConsultaCursoProfesor
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 51);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cursos a los que has sido asignado";
            // 
            // dgCursos
            // 
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Location = new System.Drawing.Point(47, 200);
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgCursos.Size = new System.Drawing.Size(243, 150);
            this.dgCursos.TabIndex = 18;
            // 
            // ConsultaCursoProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaCursoProfesor";
            this.Text = "ConsultaCursoProfesor";
            this.Load += new System.EventHandler(this.ConsultaCursoProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCursos;
    }
}