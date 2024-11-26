namespace ProyectoGrupo1
{
    partial class Mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento));
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.cbxTipoMantenimiento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarMantenimiento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxOperario = new System.Windows.Forms.ComboBox();
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            this.cbxTipoActivo = new System.Windows.Forms.ComboBox();
            this.dataGridViewMantenimientos = new System.Windows.Forms.DataGridView();
            this.gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.Location = new System.Drawing.Point(727, 87);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(167, 28);
            this.btnDeshabilitar.TabIndex = 17;
            this.btnDeshabilitar.Text = "Salir";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(727, 32);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(167, 28);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.cbxTipoMantenimiento);
            this.gbMantenimiento.Controls.Add(this.label6);
            this.gbMantenimiento.Controls.Add(this.btnAgregarMantenimiento);
            this.gbMantenimiento.Controls.Add(this.label5);
            this.gbMantenimiento.Controls.Add(this.label4);
            this.gbMantenimiento.Controls.Add(this.lblCodigo);
            this.gbMantenimiento.Controls.Add(this.label1);
            this.gbMantenimiento.Controls.Add(this.txtDescripcion);
            this.gbMantenimiento.Controls.Add(this.cbxOperario);
            this.gbMantenimiento.Controls.Add(this.cbxCodigo);
            this.gbMantenimiento.Controls.Add(this.cbxTipoActivo);
            this.gbMantenimiento.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.gbMantenimiento.ForeColor = System.Drawing.Color.White;
            this.gbMantenimiento.Location = new System.Drawing.Point(25, 20);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(666, 374);
            this.gbMantenimiento.TabIndex = 15;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Datos Mantenimiento ";
            // 
            // cbxTipoMantenimiento
            // 
            this.cbxTipoMantenimiento.FormattingEnabled = true;
            this.cbxTipoMantenimiento.Location = new System.Drawing.Point(247, 42);
            this.cbxTipoMantenimiento.Name = "cbxTipoMantenimiento";
            this.cbxTipoMantenimiento.Size = new System.Drawing.Size(239, 27);
            this.cbxTipoMantenimiento.TabIndex = 15;
            this.cbxTipoMantenimiento.SelectedIndexChanged += new System.EventHandler(this.cbxTipoMantenimiento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo Mantenimiento";
            // 
            // btnAgregarMantenimiento
            // 
            this.btnAgregarMantenimiento.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAgregarMantenimiento.Location = new System.Drawing.Point(524, 324);
            this.btnAgregarMantenimiento.Name = "btnAgregarMantenimiento";
            this.btnAgregarMantenimiento.Size = new System.Drawing.Size(123, 28);
            this.btnAgregarMantenimiento.TabIndex = 2;
            this.btnAgregarMantenimiento.Text = "AGREGAR";
            this.btnAgregarMantenimiento.UseVisualStyleBackColor = false;
            this.btnAgregarMantenimiento.Click += new System.EventHandler(this.btnAgregarMantenimiento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operario";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(54, 122);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 19);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Activo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(247, 221);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(239, 131);
            this.txtDescripcion.TabIndex = 4;
            // 
            // cbxOperario
            // 
            this.cbxOperario.FormattingEnabled = true;
            this.cbxOperario.Location = new System.Drawing.Point(247, 169);
            this.cbxOperario.Name = "cbxOperario";
            this.cbxOperario.Size = new System.Drawing.Size(239, 27);
            this.cbxOperario.TabIndex = 3;
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(247, 119);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(239, 27);
            this.cbxCodigo.TabIndex = 1;
            // 
            // cbxTipoActivo
            // 
            this.cbxTipoActivo.FormattingEnabled = true;
            this.cbxTipoActivo.Location = new System.Drawing.Point(247, 79);
            this.cbxTipoActivo.Name = "cbxTipoActivo";
            this.cbxTipoActivo.Size = new System.Drawing.Size(239, 27);
            this.cbxTipoActivo.TabIndex = 0;
            this.cbxTipoActivo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoActivo_SelectedIndexChanged);
            // 
            // dataGridViewMantenimientos
            // 
            this.dataGridViewMantenimientos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMantenimientos.Location = new System.Drawing.Point(25, 400);
            this.dataGridViewMantenimientos.Name = "dataGridViewMantenimientos";
            this.dataGridViewMantenimientos.RowHeadersWidth = 51;
            this.dataGridViewMantenimientos.RowTemplate.Height = 24;
            this.dataGridViewMantenimientos.Size = new System.Drawing.Size(869, 288);
            this.dataGridViewMantenimientos.TabIndex = 14;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(134)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(906, 698);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.dataGridViewMantenimientos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.gbMantenimiento.ResumeLayout(false);
            this.gbMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.ComboBox cbxTipoMantenimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarMantenimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxOperario;
        private System.Windows.Forms.ComboBox cbxCodigo;
        private System.Windows.Forms.ComboBox cbxTipoActivo;
        private System.Windows.Forms.DataGridView dataGridViewMantenimientos;
    }
}