namespace ProyectoGrupo1
{
    partial class MantenedorUnidadTransporte
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
            this.dgvMantenedorUndTransp = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbDatosUndTransporte = new System.Windows.Forms.GroupBox();
            this.cbkEstadoUT = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtMarcaUT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlacaUT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreUT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidUT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorUndTransp)).BeginInit();
            this.gbDatosUndTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMantenedorUndTransp
            // 
            this.dgvMantenedorUndTransp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenedorUndTransp.Location = new System.Drawing.Point(12, 21);
            this.dgvMantenedorUndTransp.Name = "dgvMantenedorUndTransp";
            this.dgvMantenedorUndTransp.ReadOnly = true;
            this.dgvMantenedorUndTransp.Size = new System.Drawing.Size(545, 179);
            this.dgvMantenedorUndTransp.TabIndex = 0;
            this.dgvMantenedorUndTransp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMantenedorUndTransp_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(574, 140);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(574, 111);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(125, 23);
            this.btnDeshabilitar.TabIndex = 7;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(574, 82);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(574, 53);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbDatosUndTransporte
            // 
            this.gbDatosUndTransporte.Controls.Add(this.cbkEstadoUT);
            this.gbDatosUndTransporte.Controls.Add(this.btnAgregar);
            this.gbDatosUndTransporte.Controls.Add(this.btnModificar);
            this.gbDatosUndTransporte.Controls.Add(this.btnCancelar);
            this.gbDatosUndTransporte.Controls.Add(this.txtMarcaUT);
            this.gbDatosUndTransporte.Controls.Add(this.label4);
            this.gbDatosUndTransporte.Controls.Add(this.txtPlacaUT);
            this.gbDatosUndTransporte.Controls.Add(this.label3);
            this.gbDatosUndTransporte.Controls.Add(this.txtNombreUT);
            this.gbDatosUndTransporte.Controls.Add(this.label2);
            this.gbDatosUndTransporte.Controls.Add(this.txtidUT);
            this.gbDatosUndTransporte.Controls.Add(this.label1);
            this.gbDatosUndTransporte.Location = new System.Drawing.Point(12, 227);
            this.gbDatosUndTransporte.Name = "gbDatosUndTransporte";
            this.gbDatosUndTransporte.Size = new System.Drawing.Size(699, 188);
            this.gbDatosUndTransporte.TabIndex = 9;
            this.gbDatosUndTransporte.TabStop = false;
            this.gbDatosUndTransporte.Text = "Datos de la Unidad de transporte";
            // 
            // cbkEstadoUT
            // 
            this.cbkEstadoUT.AutoSize = true;
            this.cbkEstadoUT.Location = new System.Drawing.Point(515, 148);
            this.cbkEstadoUT.Name = "cbkEstadoUT";
            this.cbkEstadoUT.Size = new System.Drawing.Size(150, 17);
            this.cbkEstadoUT.TabIndex = 11;
            this.cbkEstadoUT.Text = "Estado Unidad Transporte";
            this.cbkEstadoUT.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(515, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(515, 70);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(163, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(515, 98);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtMarcaUT
            // 
            this.txtMarcaUT.Location = new System.Drawing.Point(163, 146);
            this.txtMarcaUT.Name = "txtMarcaUT";
            this.txtMarcaUT.Size = new System.Drawing.Size(230, 20);
            this.txtMarcaUT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca";
            // 
            // txtPlacaUT
            // 
            this.txtPlacaUT.Location = new System.Drawing.Point(163, 109);
            this.txtPlacaUT.Name = "txtPlacaUT";
            this.txtPlacaUT.Size = new System.Drawing.Size(230, 20);
            this.txtPlacaUT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Placa";
            // 
            // txtNombreUT
            // 
            this.txtNombreUT.Location = new System.Drawing.Point(163, 73);
            this.txtNombreUT.Name = "txtNombreUT";
            this.txtNombreUT.Size = new System.Drawing.Size(230, 20);
            this.txtNombreUT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtidUT
            // 
            this.txtidUT.Location = new System.Drawing.Point(163, 37);
            this.txtidUT.Name = "txtidUT";
            this.txtidUT.Size = new System.Drawing.Size(230, 20);
            this.txtidUT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Unidad de transporte";
            // 
            // MantenedorUnidadTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 431);
            this.Controls.Add(this.gbDatosUndTransporte);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvMantenedorUndTransp);
            this.Name = "MantenedorUnidadTransporte";
            this.Text = "MantenedorUnidadTransporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorUndTransp)).EndInit();
            this.gbDatosUndTransporte.ResumeLayout(false);
            this.gbDatosUndTransporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMantenedorUndTransp;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbDatosUndTransporte;
        private System.Windows.Forms.TextBox txtidUT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtMarcaUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlacaUT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbkEstadoUT;
    }
}