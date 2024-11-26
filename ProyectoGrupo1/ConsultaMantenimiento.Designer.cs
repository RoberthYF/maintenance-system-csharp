namespace ProyectoGrupo1
{
    partial class ConsultaMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMantenimiento));
            this.cbxOperario = new System.Windows.Forms.ComboBox();
            this.dgvOperario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperario)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxOperario
            // 
            this.cbxOperario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbxOperario.FormattingEnabled = true;
            this.cbxOperario.Location = new System.Drawing.Point(177, 47);
            this.cbxOperario.Name = "cbxOperario";
            this.cbxOperario.Size = new System.Drawing.Size(233, 27);
            this.cbxOperario.TabIndex = 0;
            // 
            // dgvOperario
            // 
            this.dgvOperario.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperario.Location = new System.Drawing.Point(48, 92);
            this.dgvOperario.Name = "dgvOperario";
            this.dgvOperario.RowHeadersWidth = 51;
            this.dgvOperario.RowTemplate.Height = 24;
            this.dgvOperario.Size = new System.Drawing.Size(574, 260);
            this.dgvOperario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "OPERARIO";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(496, 47);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(126, 27);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "BUSCAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // ConsultaMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(134)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(676, 388);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOperario);
            this.Controls.Add(this.cbxOperario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaMantenimiento";
            this.Text = "ConsultaMantenimiento";
            this.Load += new System.EventHandler(this.ConsultaMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxOperario;
        private System.Windows.Forms.DataGridView dgvOperario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
    }
}