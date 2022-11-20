namespace pryCuevasEjxResolverSP4
{
    partial class frmVentasDiarias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasDiarias));
            this.dgvImportes = new System.Windows.Forms.DataGridView();
            this.dgvColumna0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpConsultas = new System.Windows.Forms.GroupBox();
            this.lblPostres = new System.Windows.Forms.Label();
            this.lblBebidasSin = new System.Windows.Forms.Label();
            this.lblBebidasCon = new System.Windows.Forms.Label();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPostres = new System.Windows.Forms.TextBox();
            this.txtMozodelDia = new System.Windows.Forms.TextBox();
            this.txtBebidascon = new System.Windows.Forms.TextBox();
            this.btnMozoDelDia = new System.Windows.Forms.Button();
            this.txtBebidassin = new System.Windows.Forms.TextBox();
            this.btnTotales = new System.Windows.Forms.Button();
            this.txtComidas = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportes)).BeginInit();
            this.grpConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImportes
            // 
            this.dgvImportes.AllowUserToAddRows = false;
            this.dgvImportes.AllowUserToDeleteRows = false;
            this.dgvImportes.BackgroundColor = System.Drawing.Color.Sienna;
            this.dgvImportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumna0,
            this.dgvColumna1,
            this.dgvColumna2,
            this.dgvColumna3,
            this.dgvColumna4});
            this.dgvImportes.Location = new System.Drawing.Point(12, 11);
            this.dgvImportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvImportes.Name = "dgvImportes";
            this.dgvImportes.RowHeadersWidth = 51;
            this.dgvImportes.RowTemplate.Height = 24;
            this.dgvImportes.Size = new System.Drawing.Size(861, 208);
            this.dgvImportes.TabIndex = 1;
            // 
            // dgvColumna0
            // 
            this.dgvColumna0.HeaderText = "Nombre Mozo";
            this.dgvColumna0.MinimumWidth = 6;
            this.dgvColumna0.Name = "dgvColumna0";
            this.dgvColumna0.Width = 125;
            // 
            // dgvColumna1
            // 
            this.dgvColumna1.HeaderText = "Comidas";
            this.dgvColumna1.MinimumWidth = 6;
            this.dgvColumna1.Name = "dgvColumna1";
            this.dgvColumna1.Width = 125;
            // 
            // dgvColumna2
            // 
            this.dgvColumna2.HeaderText = "Bebidas Sin Alcohol";
            this.dgvColumna2.MinimumWidth = 6;
            this.dgvColumna2.Name = "dgvColumna2";
            this.dgvColumna2.Width = 125;
            // 
            // dgvColumna3
            // 
            this.dgvColumna3.HeaderText = "Bebidas Con Alcohol";
            this.dgvColumna3.MinimumWidth = 6;
            this.dgvColumna3.Name = "dgvColumna3";
            this.dgvColumna3.Width = 125;
            // 
            // dgvColumna4
            // 
            this.dgvColumna4.HeaderText = "Postres";
            this.dgvColumna4.MinimumWidth = 6;
            this.dgvColumna4.Name = "dgvColumna4";
            this.dgvColumna4.Width = 125;
            // 
            // btnValidarDatos
            // 
            this.btnValidarDatos.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnValidarDatos.Location = new System.Drawing.Point(905, 54);
            this.btnValidarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidarDatos.Name = "btnValidarDatos";
            this.btnValidarDatos.Size = new System.Drawing.Size(108, 47);
            this.btnValidarDatos.TabIndex = 2;
            this.btnValidarDatos.Text = "Validar Datos";
            this.btnValidarDatos.UseVisualStyleBackColor = false;
            this.btnValidarDatos.Click += new System.EventHandler(this.btnValidarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSalir.Location = new System.Drawing.Point(905, 121);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 45);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpConsultas
            // 
            this.grpConsultas.BackColor = System.Drawing.Color.Sienna;
            this.grpConsultas.Controls.Add(this.lblPostres);
            this.grpConsultas.Controls.Add(this.lblBebidasSin);
            this.grpConsultas.Controls.Add(this.lblBebidasCon);
            this.grpConsultas.Controls.Add(this.lblComidas);
            this.grpConsultas.Controls.Add(this.lblTotal);
            this.grpConsultas.Controls.Add(this.txtPostres);
            this.grpConsultas.Controls.Add(this.txtMozodelDia);
            this.grpConsultas.Controls.Add(this.txtBebidascon);
            this.grpConsultas.Controls.Add(this.btnMozoDelDia);
            this.grpConsultas.Controls.Add(this.txtBebidassin);
            this.grpConsultas.Controls.Add(this.btnTotales);
            this.grpConsultas.Controls.Add(this.txtComidas);
            this.grpConsultas.Controls.Add(this.txtTotal);
            this.grpConsultas.Location = new System.Drawing.Point(12, 242);
            this.grpConsultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultas.Name = "grpConsultas";
            this.grpConsultas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultas.Size = new System.Drawing.Size(685, 308);
            this.grpConsultas.TabIndex = 7;
            this.grpConsultas.TabStop = false;
            this.grpConsultas.Text = "CONSULTAS";
            // 
            // lblPostres
            // 
            this.lblPostres.AutoSize = true;
            this.lblPostres.Location = new System.Drawing.Point(326, 175);
            this.lblPostres.Name = "lblPostres";
            this.lblPostres.Size = new System.Drawing.Size(53, 16);
            this.lblPostres.TabIndex = 17;
            this.lblPostres.Text = "Postres";
            // 
            // lblBebidasSin
            // 
            this.lblBebidasSin.AutoSize = true;
            this.lblBebidasSin.Location = new System.Drawing.Point(121, 175);
            this.lblBebidasSin.Name = "lblBebidasSin";
            this.lblBebidasSin.Size = new System.Drawing.Size(125, 16);
            this.lblBebidasSin.TabIndex = 16;
            this.lblBebidasSin.Text = "Bebidas sin alcohol";
            // 
            // lblBebidasCon
            // 
            this.lblBebidasCon.AutoSize = true;
            this.lblBebidasCon.Location = new System.Drawing.Point(291, 96);
            this.lblBebidasCon.Name = "lblBebidasCon";
            this.lblBebidasCon.Size = new System.Drawing.Size(130, 16);
            this.lblBebidasCon.TabIndex = 15;
            this.lblBebidasCon.Text = "Bebidas con alcohol";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(154, 96);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(61, 16);
            this.lblComidas.TabIndex = 14;
            this.lblComidas.Text = "Comidas";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(491, 129);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 16);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "TOTAL VENTAS";
            // 
            // txtPostres
            // 
            this.txtPostres.Location = new System.Drawing.Point(268, 193);
            this.txtPostres.Multiline = true;
            this.txtPostres.Name = "txtPostres";
            this.txtPostres.Size = new System.Drawing.Size(163, 59);
            this.txtPostres.TabIndex = 12;
            // 
            // txtMozodelDia
            // 
            this.txtMozodelDia.Location = new System.Drawing.Point(102, 47);
            this.txtMozodelDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMozodelDia.Multiline = true;
            this.txtMozodelDia.Name = "txtMozodelDia";
            this.txtMozodelDia.Size = new System.Drawing.Size(75, 28);
            this.txtMozodelDia.TabIndex = 7;
            // 
            // txtBebidascon
            // 
            this.txtBebidascon.Location = new System.Drawing.Point(268, 115);
            this.txtBebidascon.Multiline = true;
            this.txtBebidascon.Name = "txtBebidascon";
            this.txtBebidascon.Size = new System.Drawing.Size(163, 57);
            this.txtBebidascon.TabIndex = 11;
            // 
            // btnMozoDelDia
            // 
            this.btnMozoDelDia.Enabled = false;
            this.btnMozoDelDia.Location = new System.Drawing.Point(21, 35);
            this.btnMozoDelDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMozoDelDia.Name = "btnMozoDelDia";
            this.btnMozoDelDia.Size = new System.Drawing.Size(74, 46);
            this.btnMozoDelDia.TabIndex = 2;
            this.btnMozoDelDia.Text = "Mozo del Dia";
            this.btnMozoDelDia.UseVisualStyleBackColor = true;
            this.btnMozoDelDia.Click += new System.EventHandler(this.btnMozoDelDia_Click);
            // 
            // txtBebidassin
            // 
            this.txtBebidassin.Location = new System.Drawing.Point(99, 193);
            this.txtBebidassin.Multiline = true;
            this.txtBebidassin.Name = "txtBebidassin";
            this.txtBebidassin.Size = new System.Drawing.Size(163, 59);
            this.txtBebidassin.TabIndex = 10;
            // 
            // btnTotales
            // 
            this.btnTotales.Enabled = false;
            this.btnTotales.Location = new System.Drawing.Point(21, 148);
            this.btnTotales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(72, 43);
            this.btnTotales.TabIndex = 3;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // txtComidas
            // 
            this.txtComidas.Location = new System.Drawing.Point(99, 115);
            this.txtComidas.Multiline = true;
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.Size = new System.Drawing.Size(163, 57);
            this.txtComidas.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(458, 148);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(183, 54);
            this.txtTotal.TabIndex = 8;
            // 
            // frmVentasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::pryCuevasEjxResolverSP4.Properties.Resources.fondo_restaurante;
            this.ClientSize = new System.Drawing.Size(1094, 604);
            this.Controls.Add(this.grpConsultas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnValidarDatos);
            this.Controls.Add(this.dgvImportes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentasDiarias";
            this.Text = "Ventas Diarias";
            this.Load += new System.EventHandler(this.frmVentasDiarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportes)).EndInit();
            this.grpConsultas.ResumeLayout(false);
            this.grpConsultas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumna4;
        private System.Windows.Forms.Button btnValidarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpConsultas;
        private System.Windows.Forms.TextBox txtMozodelDia;
        private System.Windows.Forms.Button btnMozoDelDia;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtComidas;
        private System.Windows.Forms.TextBox txtBebidassin;
        private System.Windows.Forms.TextBox txtBebidascon;
        private System.Windows.Forms.TextBox txtPostres;
        private System.Windows.Forms.Label lblPostres;
        private System.Windows.Forms.Label lblBebidasSin;
        private System.Windows.Forms.Label lblBebidasCon;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblTotal;
    }
}

