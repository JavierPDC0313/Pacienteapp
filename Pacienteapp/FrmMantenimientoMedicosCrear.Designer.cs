
namespace Mantenimentos
{
    partial class FrmMantenimientoMedicosCrear
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
            this.components = new System.ComponentModel.Container();
            this.LblBuscarM = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblTotalR = new System.Windows.Forms.Label();
            this.TtMensajes = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // LblBuscarM
            // 
            this.LblBuscarM.AutoSize = true;
            this.LblBuscarM.Location = new System.Drawing.Point(43, 23);
            this.LblBuscarM.Name = "LblBuscarM";
            this.LblBuscarM.Size = new System.Drawing.Size(90, 15);
            this.LblBuscarM.TabIndex = 0;
            this.LblBuscarM.Text = "Buscar Medicos";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(155, 20);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(335, 23);
            this.TxtBuscar.TabIndex = 1;
            this.TtMensajes.SetToolTip(this.TxtBuscar, "Busque un Medico.");
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // DataListado
            // 
            this.DataListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListado.Location = new System.Drawing.Point(12, 76);
            this.DataListado.Name = "DataListado";
            this.DataListado.RowTemplate.Height = 25;
            this.DataListado.Size = new System.Drawing.Size(511, 293);
            this.DataListado.TabIndex = 2;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.ForeColor = System.Drawing.Color.Blue;
            this.BtnAgregar.Location = new System.Drawing.Point(603, 101);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 35);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar Nuevo Medico";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(603, 167);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(100, 35);
            this.BtnEditar.TabIndex = 5;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.ForeColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(603, 238);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 35);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // LblTotalR
            // 
            this.LblTotalR.AutoSize = true;
            this.LblTotalR.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblTotalR.Location = new System.Drawing.Point(529, 349);
            this.LblTotalR.Name = "LblTotalR";
            this.LblTotalR.Size = new System.Drawing.Size(184, 20);
            this.LblTotalR.TabIndex = 7;
            this.LblTotalR.Text = "Total Registro De Medicos";
            this.LblTotalR.Click += new System.EventHandler(this.LblTotalR_Click);
            // 
            // FrmMantenimientoMedicosCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.LblTotalR);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DataListado);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBuscarM);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmMantenimientoMedicosCrear";
            this.Text = "Agregar Medicos";
            this.Load += new System.EventHandler(this.FrmMantenimientoMedicosCrear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBuscarM;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DataListado;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ToolTip TtMensajes;
        private System.Windows.Forms.Label LblTotalR;
    }
}

