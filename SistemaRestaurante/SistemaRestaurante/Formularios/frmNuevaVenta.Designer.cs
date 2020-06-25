namespace SistemaRestaurante.Formularios
{
    partial class frmNuevaVenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label totalPagarLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idProductoVLabel;
            System.Windows.Forms.Label precioVentaLabel;
            System.Windows.Forms.Label totalProductoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalPagarTextBox = new System.Windows.Forms.TextBox();
            this.detallesVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productosVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.detallesVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.precioVentaTextBox = new System.Windows.Forms.TextBox();
            this.totalProductoTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.idProductoVComboBox = new System.Windows.Forms.ComboBox();
            this.productosVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            totalPagarLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            idProductoVLabel = new System.Windows.Forms.Label();
            precioVentaLabel = new System.Windows.Forms.Label();
            totalProductoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosVentaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalPagarLabel
            // 
            totalPagarLabel.AutoSize = true;
            totalPagarLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalPagarLabel.ForeColor = System.Drawing.Color.White;
            totalPagarLabel.Location = new System.Drawing.Point(203, 527);
            totalPagarLabel.Name = "totalPagarLabel";
            totalPagarLabel.Size = new System.Drawing.Size(109, 25);
            totalPagarLabel.TabIndex = 10;
            totalPagarLabel.Text = "Total Pagar:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.ForeColor = System.Drawing.Color.White;
            cantidadLabel.Location = new System.Drawing.Point(319, 46);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(88, 25);
            cantidadLabel.TabIndex = 4;
            cantidadLabel.Text = "Cantidad:";
            // 
            // idProductoVLabel
            // 
            idProductoVLabel.AutoSize = true;
            idProductoVLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProductoVLabel.ForeColor = System.Drawing.Color.White;
            idProductoVLabel.Location = new System.Drawing.Point(51, 46);
            idProductoVLabel.Name = "idProductoVLabel";
            idProductoVLabel.Size = new System.Drawing.Size(88, 25);
            idProductoVLabel.TabIndex = 0;
            idProductoVLabel.Text = "Producto:";
            // 
            // precioVentaLabel
            // 
            precioVentaLabel.AutoSize = true;
            precioVentaLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioVentaLabel.ForeColor = System.Drawing.Color.White;
            precioVentaLabel.Location = new System.Drawing.Point(51, 90);
            precioVentaLabel.Name = "precioVentaLabel";
            precioVentaLabel.Size = new System.Drawing.Size(67, 25);
            precioVentaLabel.TabIndex = 2;
            precioVentaLabel.Text = "Precio:";
            // 
            // totalProductoLabel
            // 
            totalProductoLabel.AutoSize = true;
            totalProductoLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalProductoLabel.ForeColor = System.Drawing.Color.White;
            totalProductoLabel.Location = new System.Drawing.Point(319, 91);
            totalProductoLabel.Name = "totalProductoLabel";
            totalProductoLabel.Size = new System.Drawing.Size(57, 25);
            totalProductoLabel.TabIndex = 6;
            totalProductoLabel.Text = "Total:";
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.Ventas);
            // 
            // totalPagarTextBox
            // 
            this.totalPagarTextBox.BackColor = System.Drawing.Color.Black;
            this.totalPagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "TotalPagar", true));
            this.totalPagarTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPagarTextBox.ForeColor = System.Drawing.Color.White;
            this.totalPagarTextBox.Location = new System.Drawing.Point(322, 526);
            this.totalPagarTextBox.Name = "totalPagarTextBox";
            this.totalPagarTextBox.Size = new System.Drawing.Size(200, 26);
            this.totalPagarTextBox.TabIndex = 11;
            // 
            // detallesVentaBindingSource
            // 
            this.detallesVentaBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.DetallesVenta);
            // 
            // detallesVentaDataGridView
            // 
            this.detallesVentaDataGridView.AllowUserToAddRows = false;
            this.detallesVentaDataGridView.AllowUserToDeleteRows = false;
            this.detallesVentaDataGridView.AutoGenerateColumns = false;
            this.detallesVentaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesVentaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.detallesVentaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detallesVentaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detallesVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.detallesVentaDataGridView.DataSource = this.detallesVentaBindingSource;
            this.detallesVentaDataGridView.EnableHeadersVisualStyles = false;
            this.detallesVentaDataGridView.Location = new System.Drawing.Point(56, 152);
            this.detallesVentaDataGridView.Name = "detallesVentaDataGridView";
            this.detallesVentaDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            this.detallesVentaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.detallesVentaDataGridView.Size = new System.Drawing.Size(689, 342);
            this.detallesVentaDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idProductoV";
            this.dataGridViewTextBoxColumn2.DataSource = this.productosVentaBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "nombre";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "idProductoV";
            // 
            // productosVentaBindingSource
            // 
            this.productosVentaBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.ProductosVenta);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.BackColor = System.Drawing.Color.Black;
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource1, "cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTextBox.ForeColor = System.Drawing.Color.White;
            this.cantidadTextBox.Location = new System.Drawing.Point(413, 47);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(156, 26);
            this.cantidadTextBox.TabIndex = 5;
            this.cantidadTextBox.TextChanged += new System.EventHandler(this.cantidadTextBox_TextChanged);
            // 
            // detallesVentaBindingSource1
            // 
            this.detallesVentaBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.DetallesVenta);
            // 
            // precioVentaTextBox
            // 
            this.precioVentaTextBox.BackColor = System.Drawing.Color.Black;
            this.precioVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource1, "precioVenta", true));
            this.precioVentaTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioVentaTextBox.ForeColor = System.Drawing.Color.White;
            this.precioVentaTextBox.Location = new System.Drawing.Point(145, 92);
            this.precioVentaTextBox.Name = "precioVentaTextBox";
            this.precioVentaTextBox.Size = new System.Drawing.Size(167, 26);
            this.precioVentaTextBox.TabIndex = 3;
            // 
            // totalProductoTextBox
            // 
            this.totalProductoTextBox.BackColor = System.Drawing.Color.Black;
            this.totalProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource1, "totalProducto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.totalProductoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductoTextBox.ForeColor = System.Drawing.Color.White;
            this.totalProductoTextBox.Location = new System.Drawing.Point(413, 88);
            this.totalProductoTextBox.Name = "totalProductoTextBox";
            this.totalProductoTextBox.Size = new System.Drawing.Size(156, 26);
            this.totalProductoTextBox.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(584, 522);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 30);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Compra";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(584, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 30);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // idProductoVComboBox
            // 
            this.idProductoVComboBox.BackColor = System.Drawing.Color.Black;
            this.idProductoVComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detallesVentaBindingSource1, "idProductoV", true));
            this.idProductoVComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "idProductoV", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.idProductoVComboBox.DataSource = this.productosVentaBindingSource1;
            this.idProductoVComboBox.DisplayMember = "nombre";
            this.idProductoVComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProductoVComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idProductoVComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProductoVComboBox.ForeColor = System.Drawing.Color.White;
            this.idProductoVComboBox.FormattingEnabled = true;
            this.idProductoVComboBox.Location = new System.Drawing.Point(145, 47);
            this.idProductoVComboBox.Name = "idProductoVComboBox";
            this.idProductoVComboBox.Size = new System.Drawing.Size(167, 28);
            this.idProductoVComboBox.TabIndex = 1;
            this.idProductoVComboBox.ValueMember = "idProductoV";
            // 
            // productosVentaBindingSource1
            // 
            this.productosVentaBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.ProductosVenta);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::SistemaRestaurante.Properties.Resources._61155;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(773, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(808, 564);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.idProductoVComboBox);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(idProductoVLabel);
            this.Controls.Add(precioVentaLabel);
            this.Controls.Add(this.precioVentaTextBox);
            this.Controls.Add(totalProductoLabel);
            this.Controls.Add(this.totalProductoTextBox);
            this.Controls.Add(this.detallesVentaDataGridView);
            this.Controls.Add(totalPagarLabel);
            this.Controls.Add(this.totalPagarTextBox);
            this.Name = "frmNuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosVentaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ventasBindingSource;
        private System.Windows.Forms.TextBox totalPagarTextBox;
        private System.Windows.Forms.BindingSource detallesVentaBindingSource;
        private System.Windows.Forms.DataGridView detallesVentaDataGridView;
        private System.Windows.Forms.BindingSource productosVentaBindingSource;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox precioVentaTextBox;
        private System.Windows.Forms.TextBox totalProductoTextBox;
        private System.Windows.Forms.BindingSource detallesVentaBindingSource1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox idProductoVComboBox;
        private System.Windows.Forms.BindingSource productosVentaBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnCerrar;
    }
}