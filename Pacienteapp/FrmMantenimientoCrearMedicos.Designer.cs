
namespace Pacienteapp
{
    partial class FrmMantenimientoCrearMedicos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvMedicosListado = new System.Windows.Forms.DataGridView();
            this.BtnCrearNuevoMed = new System.Windows.Forms.Button();
            this.BtnEditarMedicos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarM = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PbFotoDePerfil = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosListado)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFotoDePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.DgvMedicosListado, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCrearNuevoMed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEditarMedicos, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminarM, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.58696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.41304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 432);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // DgvMedicosListado
            // 
            this.DgvMedicosListado.AllowUserToAddRows = false;
            this.DgvMedicosListado.AllowUserToDeleteRows = false;
            this.DgvMedicosListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DgvMedicosListado, 4);
            this.DgvMedicosListado.Location = new System.Drawing.Point(3, 44);
            this.DgvMedicosListado.Name = "DgvMedicosListado";
            this.DgvMedicosListado.ReadOnly = true;
            this.DgvMedicosListado.RowTemplate.Height = 25;
            this.DgvMedicosListado.Size = new System.Drawing.Size(781, 257);
            this.DgvMedicosListado.TabIndex = 2;
            this.DgvMedicosListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicosListado_CellClick);
            // 
            // BtnCrearNuevoMed
            // 
            this.BtnCrearNuevoMed.Location = new System.Drawing.Point(513, 3);
            this.BtnCrearNuevoMed.Name = "BtnCrearNuevoMed";
            this.BtnCrearNuevoMed.Size = new System.Drawing.Size(271, 35);
            this.BtnCrearNuevoMed.TabIndex = 7;
            this.BtnCrearNuevoMed.Text = "Crear Nuevo Medico Aqui";
            this.BtnCrearNuevoMed.UseVisualStyleBackColor = true;
            this.BtnCrearNuevoMed.Click += new System.EventHandler(this.BtnCrearNuevoMed_Click);
            // 
            // BtnEditarMedicos
            // 
            this.BtnEditarMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEditarMedicos.Location = new System.Drawing.Point(513, 307);
            this.BtnEditarMedicos.Name = "BtnEditarMedicos";
            this.BtnEditarMedicos.Size = new System.Drawing.Size(271, 122);
            this.BtnEditarMedicos.TabIndex = 6;
            this.BtnEditarMedicos.Text = "Editar Medicos";
            this.BtnEditarMedicos.UseVisualStyleBackColor = true;
            this.BtnEditarMedicos.Click += new System.EventHandler(this.BtnEditarMedicos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // BtnEliminarM
            // 
            this.BtnEliminarM.Location = new System.Drawing.Point(3, 3);
            this.BtnEliminarM.Name = "BtnEliminarM";
            this.BtnEliminarM.Size = new System.Drawing.Size(249, 35);
            this.BtnEliminarM.TabIndex = 4;
            this.BtnEliminarM.Text = "Eliminar Medicos";
            this.BtnEliminarM.UseVisualStyleBackColor = true;
            this.BtnEliminarM.Click += new System.EventHandler(this.BtnEliminarM_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PbFotoDePerfil, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(258, 307);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(249, 122);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // PbFotoDePerfil
            // 
            this.PbFotoDePerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbFotoDePerfil.Location = new System.Drawing.Point(3, 3);
            this.PbFotoDePerfil.Name = "PbFotoDePerfil";
            this.PbFotoDePerfil.Size = new System.Drawing.Size(243, 116);
            this.PbFotoDePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFotoDePerfil.TabIndex = 0;
            this.PbFotoDePerfil.TabStop = false;
            this.PbFotoDePerfil.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMantenimientoCrearMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMantenimientoCrearMedicos";
            this.Text = "Listado de Medicos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosListado)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbFotoDePerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvMedicosListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarM;
        private System.Windows.Forms.Button BtnEditarMedicos;
        private System.Windows.Forms.Button BtnCrearNuevoMed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox PbFotoDePerfil;
    }
}