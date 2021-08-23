
namespace Pacienteapp
{
    partial class FrmMantenimientoUsuarios
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
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.DgvUsuarios, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnEditar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnAgregar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33533F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeColumns = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DgvUsuarios, 3);
            this.DgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUsuarios.Location = new System.Drawing.Point(3, 119);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowTemplate.Height = 25;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(590, 261);
            this.DgvUsuarios.TabIndex = 0;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.AutoSize = true;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(3, 408);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(192, 67);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Editar Usuario";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Visible = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.Location = new System.Drawing.Point(399, 409);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(194, 65);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar Usuario";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.AutoSize = true;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.Location = new System.Drawing.Point(201, 23);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(192, 69);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar Usuario";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmMantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMantenimientoUsuarios";
            this.Text = "Usuarios";
            this.Activated += new System.EventHandler(this.FrmMantenimientoUsuarios_Activated);
            this.Deactivate += new System.EventHandler(this.FrmMantenimientoUsuarios_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMantenimientoUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.FrmMantenimientoUsuarios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}

