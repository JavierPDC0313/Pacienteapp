
namespace Pacienteapp
{
    partial class FrmHomeDisplay
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
            this.btnMatenimiento_Usuario_Paciente = new System.Windows.Forms.Button();
            this.btnMatenimiento_Medico_Citas = new System.Windows.Forms.Button();
            this.btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnMatenimiento_Usuario_Paciente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMatenimiento_Medico_Citas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(144, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 253);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnMatenimiento_Usuario_Paciente
            // 
            this.btnMatenimiento_Usuario_Paciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMatenimiento_Usuario_Paciente.Location = new System.Drawing.Point(134, 21);
            this.btnMatenimiento_Usuario_Paciente.Name = "btnMatenimiento_Usuario_Paciente";
            this.btnMatenimiento_Usuario_Paciente.Size = new System.Drawing.Size(234, 42);
            this.btnMatenimiento_Usuario_Paciente.TabIndex = 0;
            this.btnMatenimiento_Usuario_Paciente.Text = "button";
            this.btnMatenimiento_Usuario_Paciente.UseVisualStyleBackColor = true;
            // 
            // btnMatenimiento_Medico_Citas
            // 
            this.btnMatenimiento_Medico_Citas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMatenimiento_Medico_Citas.Location = new System.Drawing.Point(134, 105);
            this.btnMatenimiento_Medico_Citas.Name = "btnMatenimiento_Medico_Citas";
            this.btnMatenimiento_Medico_Citas.Size = new System.Drawing.Size(234, 42);
            this.btnMatenimiento_Medico_Citas.TabIndex = 0;
            this.btnMatenimiento_Medico_Citas.Text = "button";
            this.btnMatenimiento_Medico_Citas.UseVisualStyleBackColor = true;
            // 
            // btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio
            // 
            this.btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Location = new System.Drawing.Point(134, 189);
            this.btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Name = "btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio";
            this.btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Size = new System.Drawing.Size(234, 42);
            this.btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.TabIndex = 0;
            this.btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.Text = "button";
            this.btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio.UseVisualStyleBackColor = true;
            // 
            // FrmHomeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 423);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmHomeDisplay";
            this.Text = "FrmHomeDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHomeDisplay_FormClosed);
            this.Load += new System.EventHandler(this.FrmHomeDisplay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMatenimiento_Usuario_Paciente;
        private System.Windows.Forms.Button btnMatenimiento_Medico_Citas;
        private System.Windows.Forms.Button btnMatenimiento_PruebaLaboratorio_ResultadoLaboratorio;
    }
}