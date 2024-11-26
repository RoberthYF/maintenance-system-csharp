namespace ProyectoGrupo1
{
    partial class MantenimientoPreventivo
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
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbMantenimientoPreventivo = new System.Windows.Forms.GroupBox();
            this.txtMantenimientoPreventivoID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeshabilitarMantenimiento = new System.Windows.Forms.Button();
            this.btnAgregarMantenimiento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxResponsables = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            this.cbxTipoActivo = new System.Windows.Forms.ComboBox();
            this.dtgMantenimientoPreventivo = new System.Windows.Forms.DataGridView();
            this.gbMantenimientoPreventivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMantenimientoPreventivo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(696, 59);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(167, 28);
            this.btnDeshabilitar.TabIndex = 13;
            this.btnDeshabilitar.Text = "Salir";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(696, 23);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(167, 28);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbMantenimientoPreventivo
            // 
            this.gbMantenimientoPreventivo.Controls.Add(this.txtMantenimientoPreventivoID);
            this.gbMantenimientoPreventivo.Controls.Add(this.label6);
            this.gbMantenimientoPreventivo.Controls.Add(this.btnDeshabilitarMantenimiento);
            this.gbMantenimientoPreventivo.Controls.Add(this.btnAgregarMantenimiento);
            this.gbMantenimientoPreventivo.Controls.Add(this.label5);
            this.gbMantenimientoPreventivo.Controls.Add(this.label4);
            this.gbMantenimientoPreventivo.Controls.Add(this.label3);
            this.gbMantenimientoPreventivo.Controls.Add(this.label2);
            this.gbMantenimientoPreventivo.Controls.Add(this.label1);
            this.gbMantenimientoPreventivo.Controls.Add(this.txtDescripcion);
            this.gbMantenimientoPreventivo.Controls.Add(this.cbxResponsables);
            this.gbMantenimientoPreventivo.Controls.Add(this.dtpFecha);
            this.gbMantenimientoPreventivo.Controls.Add(this.cbxCodigo);
            this.gbMantenimientoPreventivo.Controls.Add(this.cbxTipoActivo);
            this.gbMantenimientoPreventivo.Location = new System.Drawing.Point(12, 13);
            this.gbMantenimientoPreventivo.Name = "gbMantenimientoPreventivo";
            this.gbMantenimientoPreventivo.Size = new System.Drawing.Size(666, 355);
            this.gbMantenimientoPreventivo.TabIndex = 11;
            this.gbMantenimientoPreventivo.TabStop = false;
            this.gbMantenimientoPreventivo.Text = "Datos Mantenimiento Preventivo";
            this.gbMantenimientoPreventivo.Enter += new System.EventHandler(this.gbMantenimientoPreventivo_Enter);
            // 
            // txtMantenimientoPreventivoID
            // 
            this.txtMantenimientoPreventivoID.Location = new System.Drawing.Point(247, 42);
            this.txtMantenimientoPreventivoID.Name = "txtMantenimientoPreventivoID";
            this.txtMantenimientoPreventivoID.Size = new System.Drawing.Size(239, 22);
            this.txtMantenimientoPreventivoID.TabIndex = 15;
            this.txtMantenimientoPreventivoID.TextChanged += new System.EventHandler(this.txtMantenimientoPreventivoID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mantenimiento Preventivo ID";
            // 
            // btnDeshabilitarMantenimiento
            // 
            this.btnDeshabilitarMantenimiento.Location = new System.Drawing.Point(517, 82);
            this.btnDeshabilitarMantenimiento.Name = "btnDeshabilitarMantenimiento";
            this.btnDeshabilitarMantenimiento.Size = new System.Drawing.Size(123, 37);
            this.btnDeshabilitarMantenimiento.TabIndex = 3;
            this.btnDeshabilitarMantenimiento.Text = "DESHABILITAR";
            this.btnDeshabilitarMantenimiento.UseVisualStyleBackColor = true;
            this.btnDeshabilitarMantenimiento.Click += new System.EventHandler(this.btnDeshabilitarMantenimiento_Click);
            // 
            // btnAgregarMantenimiento
            // 
            this.btnAgregarMantenimiento.Location = new System.Drawing.Point(517, 42);
            this.btnAgregarMantenimiento.Name = "btnAgregarMantenimiento";
            this.btnAgregarMantenimiento.Size = new System.Drawing.Size(123, 28);
            this.btnAgregarMantenimiento.TabIndex = 2;
            this.btnAgregarMantenimiento.Text = "AGREGAR";
            this.btnAgregarMantenimiento.UseVisualStyleBackColor = true;
            this.btnAgregarMantenimiento.Click += new System.EventHandler(this.btnAgregarMantenimiento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Responsables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Activo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(247, 240);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(239, 64);
            this.txtDescripcion.TabIndex = 4;
            // 
            // cbxResponsables
            // 
            this.cbxResponsables.FormattingEnabled = true;
            this.cbxResponsables.Location = new System.Drawing.Point(247, 198);
            this.cbxResponsables.Name = "cbxResponsables";
            this.cbxResponsables.Size = new System.Drawing.Size(239, 24);
            this.cbxResponsables.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(247, 160);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(239, 22);
            this.dtpFecha.TabIndex = 2;
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(247, 119);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(239, 24);
            this.cbxCodigo.TabIndex = 1;
            // 
            // cbxTipoActivo
            // 
            this.cbxTipoActivo.FormattingEnabled = true;
            this.cbxTipoActivo.Location = new System.Drawing.Point(247, 79);
            this.cbxTipoActivo.Name = "cbxTipoActivo";
            this.cbxTipoActivo.Size = new System.Drawing.Size(239, 24);
            this.cbxTipoActivo.TabIndex = 0;
            // 
            // dtgMantenimientoPreventivo
            // 
            this.dtgMantenimientoPreventivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMantenimientoPreventivo.Location = new System.Drawing.Point(12, 393);
            this.dtgMantenimientoPreventivo.Name = "dtgMantenimientoPreventivo";
            this.dtgMantenimientoPreventivo.RowHeadersWidth = 51;
            this.dtgMantenimientoPreventivo.RowTemplate.Height = 24;
            this.dtgMantenimientoPreventivo.Size = new System.Drawing.Size(851, 256);
            this.dtgMantenimientoPreventivo.TabIndex = 10;
            this.dtgMantenimientoPreventivo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMantenimientoPreventivo_CellContentClick);
            // 
            // MantenimientoPreventivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 661);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbMantenimientoPreventivo);
            this.Controls.Add(this.dtgMantenimientoPreventivo);
            this.Name = "MantenimientoPreventivo";
            this.Text = "MantenimientoPreventivo";
            this.Load += new System.EventHandler(this.MantenimientoPreventivo_Load);
            this.gbMantenimientoPreventivo.ResumeLayout(false);
            this.gbMantenimientoPreventivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMantenimientoPreventivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbMantenimientoPreventivo;
        private System.Windows.Forms.Button btnDeshabilitarMantenimiento;
        private System.Windows.Forms.Button btnAgregarMantenimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxResponsables;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxCodigo;
        private System.Windows.Forms.ComboBox cbxTipoActivo;
        private System.Windows.Forms.DataGridView dtgMantenimientoPreventivo;
        private System.Windows.Forms.TextBox txtMantenimientoPreventivoID;
        private System.Windows.Forms.Label label6;
    }
}