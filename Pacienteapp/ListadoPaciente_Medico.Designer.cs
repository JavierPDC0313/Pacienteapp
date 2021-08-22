
namespace Pacienteapp
{
    partial class ListadoPaciente_Medico
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
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.LblSelecciona = new System.Windows.Forms.Label();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtBuscarCedula = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgvListado, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblSelecciona, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSiguiente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancelar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33533F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgvListado
            // 
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DgvListado, 2);
            this.DgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListado.Location = new System.Drawing.Point(3, 107);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.RowTemplate.Height = 25;
            this.DgvListado.Size = new System.Drawing.Size(794, 234);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellClick);
            // 
            // LblSelecciona
            // 
            this.LblSelecciona.AutoSize = true;
            this.LblSelecciona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSelecciona.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSelecciona.Location = new System.Drawing.Point(3, 0);
            this.LblSelecciona.Name = "LblSelecciona";
            this.LblSelecciona.Size = new System.Drawing.Size(394, 104);
            this.LblSelecciona.TabIndex = 1;
            this.LblSelecciona.Text = "Selecciona un paciente:";
            this.LblSelecciona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSiguiente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSiguiente.Location = new System.Drawing.Point(475, 359);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(249, 76);
            this.BtnSiguiente.TabIndex = 2;
            this.BtnSiguiente.Text = "Siguiente -->";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Visible = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(72, 360);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(256, 74);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.TxtBuscarCedula, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 98);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // TxtBuscarCedula
            // 
            this.TxtBuscarCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarCedula.Location = new System.Drawing.Point(121, 37);
            this.TxtBuscarCedula.Name = "TxtBuscarCedula";
            this.TxtBuscarCedula.Size = new System.Drawing.Size(270, 23);
            this.TxtBuscarCedula.TabIndex = 1;
            this.TxtBuscarCedula.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.BtnBuscar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(112, 92);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.Location = new System.Drawing.Point(3, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(106, 40);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Visible = false;
            // 
            // ListadoPaciente_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListadoPaciente_Medico";
            this.Text = "ListadoParaCitas";
            this.Load += new System.EventHandler(this.ListadoPacientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Label LblSelecciona;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtBuscarCedula;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnBuscar;
    }
}