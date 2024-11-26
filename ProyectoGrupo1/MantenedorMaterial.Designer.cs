namespace ProyectoGrupo1
{
    partial class MantenedorMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorMaterial));
            this.gbDatosMaterial = new System.Windows.Forms.GroupBox();
            this.Marca = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Medidas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvMantenedorMaterial = new System.Windows.Forms.DataGridView();
            this.gbDatosMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosMaterial
            // 
            this.gbDatosMaterial.Controls.Add(this.Marca);
            this.gbDatosMaterial.Controls.Add(this.Nombre);
            this.gbDatosMaterial.Controls.Add(this.btnAgregar);
            this.gbDatosMaterial.Controls.Add(this.btnModificar);
            this.gbDatosMaterial.Controls.Add(this.btnCancelar);
            this.gbDatosMaterial.Controls.Add(this.label4);
            this.gbDatosMaterial.Controls.Add(this.Medidas);
            this.gbDatosMaterial.Controls.Add(this.label3);
            this.gbDatosMaterial.Controls.Add(this.Stock);
            this.gbDatosMaterial.Controls.Add(this.label2);
            this.gbDatosMaterial.Controls.Add(this.label1);
            this.gbDatosMaterial.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbDatosMaterial.ForeColor = System.Drawing.Color.White;
            this.gbDatosMaterial.Location = new System.Drawing.Point(13, 266);
            this.gbDatosMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosMaterial.Name = "gbDatosMaterial";
            this.gbDatosMaterial.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosMaterial.Size = new System.Drawing.Size(932, 232);
            this.gbDatosMaterial.TabIndex = 21;
            this.gbDatosMaterial.TabStop = false;
            this.gbDatosMaterial.Text = "Datos de Operario";
            // 
            // Marca
            // 
            this.Marca.Location = new System.Drawing.Point(217, 175);
            this.Marca.Margin = new System.Windows.Forms.Padding(4);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(305, 28);
            this.Marca.TabIndex = 15;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(217, 41);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(305, 28);
            this.Nombre.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAgregar.Location = new System.Drawing.Point(732, 54);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 28);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnModificar.Location = new System.Drawing.Point(732, 96);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(184, 28);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.Location = new System.Drawing.Point(732, 131);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 28);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca";
            // 
            // Medidas
            // 
            this.Medidas.Location = new System.Drawing.Point(217, 130);
            this.Medidas.Margin = new System.Windows.Forms.Padding(4);
            this.Medidas.Name = "Medidas";
            this.Medidas.Size = new System.Drawing.Size(305, 28);
            this.Medidas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medidas";
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(217, 86);
            this.Stock.Margin = new System.Windows.Forms.Padding(4);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(305, 28);
            this.Stock.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(762, 159);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(167, 28);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.Location = new System.Drawing.Point(762, 124);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(167, 28);
            this.btnDeshabilitar.TabIndex = 19;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(762, 88);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(167, 28);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(762, 52);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(167, 28);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvMantenedorMaterial
            // 
            this.dgvMantenedorMaterial.BackgroundColor = System.Drawing.Color.White;
            this.dgvMantenedorMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenedorMaterial.Location = new System.Drawing.Point(13, 13);
            this.dgvMantenedorMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMantenedorMaterial.Name = "dgvMantenedorMaterial";
            this.dgvMantenedorMaterial.ReadOnly = true;
            this.dgvMantenedorMaterial.RowHeadersWidth = 51;
            this.dgvMantenedorMaterial.Size = new System.Drawing.Size(727, 245);
            this.dgvMantenedorMaterial.TabIndex = 16;
            this.dgvMantenedorMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMantenedorMaterial_CellClick);
            this.dgvMantenedorMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMantenedorMaterial_CellContentClick);
            // 
            // MantenedorMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(134)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(962, 513);
            this.Controls.Add(this.gbDatosMaterial);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvMantenedorMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenedorMaterial";
            this.Text = "MantenedorMateriales";
            this.gbDatosMaterial.ResumeLayout(false);
            this.gbDatosMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosMaterial;
        private System.Windows.Forms.TextBox Marca;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Medidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvMantenedorMaterial;
    }
}