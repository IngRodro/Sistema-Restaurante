namespace SistemaRestaurante.Formularios
{
    partial class frmNuevaCompra
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idProductoCLabel;
            System.Windows.Forms.Label precioCompraLabel;
            System.Windows.Forms.Label totalProductoLabel;
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label totalaPagarLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.detallesCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.idProductoCComboBox = new System.Windows.Forms.ComboBox();
            this.productosCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precioCompraTextBox = new System.Windows.Forms.TextBox();
            this.totalProductoTextBox = new System.Windows.Forms.TextBox();
            this.detallesCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.idProductoCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productosCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalaPagarTextBox = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            cantidadLabel = new System.Windows.Forms.Label();
            idProductoCLabel = new System.Windows.Forms.Label();
            precioCompraLabel = new System.Windows.Forms.Label();
            totalProductoLabel = new System.Windows.Forms.Label();
            idProveedorLabel = new System.Windows.Forms.Label();
            totalaPagarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.ForeColor = System.Drawing.Color.White;
            cantidadLabel.Location = new System.Drawing.Point(343, 124);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(88, 25);
            cantidadLabel.TabIndex = 6;
            cantidadLabel.Text = "Cantidad:";
            // 
            // idProductoCLabel
            // 
            idProductoCLabel.AutoSize = true;
            idProductoCLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProductoCLabel.ForeColor = System.Drawing.Color.White;
            idProductoCLabel.Location = new System.Drawing.Point(71, 124);
            idProductoCLabel.Name = "idProductoCLabel";
            idProductoCLabel.Size = new System.Drawing.Size(88, 25);
            idProductoCLabel.TabIndex = 2;
            idProductoCLabel.Text = "Producto:";
            // 
            // precioCompraLabel
            // 
            precioCompraLabel.AutoSize = true;
            precioCompraLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioCompraLabel.ForeColor = System.Drawing.Color.White;
            precioCompraLabel.Location = new System.Drawing.Point(71, 163);
            precioCompraLabel.Name = "precioCompraLabel";
            precioCompraLabel.Size = new System.Drawing.Size(67, 25);
            precioCompraLabel.TabIndex = 4;
            precioCompraLabel.Text = "Precio:";
            // 
            // totalProductoLabel
            // 
            totalProductoLabel.AutoSize = true;
            totalProductoLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalProductoLabel.ForeColor = System.Drawing.Color.White;
            totalProductoLabel.Location = new System.Drawing.Point(359, 163);
            totalProductoLabel.Name = "totalProductoLabel";
            totalProductoLabel.Size = new System.Drawing.Size(57, 25);
            totalProductoLabel.TabIndex = 8;
            totalProductoLabel.Text = "Total:";
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProveedorLabel.ForeColor = System.Drawing.Color.White;
            idProveedorLabel.Location = new System.Drawing.Point(196, 65);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(99, 25);
            idProveedorLabel.TabIndex = 0;
            idProveedorLabel.Text = "Proveedor:";
            // 
            // totalaPagarLabel
            // 
            totalaPagarLabel.AutoSize = true;
            totalaPagarLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalaPagarLabel.ForeColor = System.Drawing.Color.White;
            totalaPagarLabel.Location = new System.Drawing.Point(171, 464);
            totalaPagarLabel.Name = "totalaPagarLabel";
            totalaPagarLabel.Size = new System.Drawing.Size(124, 25);
            totalaPagarLabel.TabIndex = 20;
            totalaPagarLabel.Text = "Total a Pagar:";
            // 
            // detallesCompraBindingSource
            // 
            this.detallesCompraBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.DetallesCompra);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.BackColor = System.Drawing.Color.Black;
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTextBox.ForeColor = System.Drawing.Color.White;
            this.cantidadTextBox.Location = new System.Drawing.Point(437, 125);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(139, 26);
            this.cantidadTextBox.TabIndex = 7;
            this.cantidadTextBox.TextChanged += new System.EventHandler(this.cantidadTextBox_TextChanged);
            // 
            // idProductoCComboBox
            // 
            this.idProductoCComboBox.BackColor = System.Drawing.Color.Black;
            this.idProductoCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detallesCompraBindingSource, "idProductoC", true));
            this.idProductoCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "idProductoC", true));
            this.idProductoCComboBox.DataSource = this.productosCompraBindingSource;
            this.idProductoCComboBox.DisplayMember = "nombre";
            this.idProductoCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProductoCComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idProductoCComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProductoCComboBox.ForeColor = System.Drawing.Color.White;
            this.idProductoCComboBox.FormattingEnabled = true;
            this.idProductoCComboBox.Location = new System.Drawing.Point(165, 124);
            this.idProductoCComboBox.Name = "idProductoCComboBox";
            this.idProductoCComboBox.Size = new System.Drawing.Size(172, 28);
            this.idProductoCComboBox.TabIndex = 3;
            this.idProductoCComboBox.ValueMember = "idProductoC";
            // 
            // productosCompraBindingSource
            // 
            this.productosCompraBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.ProductosCompra);
            // 
            // precioCompraTextBox
            // 
            this.precioCompraTextBox.BackColor = System.Drawing.Color.Black;
            this.precioCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "precioCompra", true));
            this.precioCompraTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioCompraTextBox.ForeColor = System.Drawing.Color.White;
            this.precioCompraTextBox.Location = new System.Drawing.Point(165, 164);
            this.precioCompraTextBox.Name = "precioCompraTextBox";
            this.precioCompraTextBox.Size = new System.Drawing.Size(173, 26);
            this.precioCompraTextBox.TabIndex = 5;
            // 
            // totalProductoTextBox
            // 
            this.totalProductoTextBox.BackColor = System.Drawing.Color.Black;
            this.totalProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "totalProducto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.totalProductoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductoTextBox.ForeColor = System.Drawing.Color.White;
            this.totalProductoTextBox.Location = new System.Drawing.Point(437, 164);
            this.totalProductoTextBox.Name = "totalProductoTextBox";
            this.totalProductoTextBox.Size = new System.Drawing.Size(139, 26);
            this.totalProductoTextBox.TabIndex = 9;
            // 
            // detallesCompraDataGridView
            // 
            this.detallesCompraDataGridView.AllowUserToAddRows = false;
            this.detallesCompraDataGridView.AllowUserToDeleteRows = false;
            this.detallesCompraDataGridView.AutoGenerateColumns = false;
            this.detallesCompraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesCompraDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.detallesCompraDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detallesCompraDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detallesCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoCDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.totalProductoDataGridViewTextBoxColumn});
            this.detallesCompraDataGridView.DataSource = this.detallesCompraBindingSource1;
            this.detallesCompraDataGridView.EnableHeadersVisualStyles = false;
            this.detallesCompraDataGridView.Location = new System.Drawing.Point(56, 231);
            this.detallesCompraDataGridView.Name = "detallesCompraDataGridView";
            this.detallesCompraDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            this.detallesCompraDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.detallesCompraDataGridView.Size = new System.Drawing.Size(677, 220);
            this.detallesCompraDataGridView.TabIndex = 12;
            // 
            // idProductoCDataGridViewTextBoxColumn
            // 
            this.idProductoCDataGridViewTextBoxColumn.DataPropertyName = "idProductoC";
            this.idProductoCDataGridViewTextBoxColumn.DataSource = this.productosCompraBindingSource1;
            this.idProductoCDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.idProductoCDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idProductoCDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.idProductoCDataGridViewTextBoxColumn.Name = "idProductoCDataGridViewTextBoxColumn";
            this.idProductoCDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoCDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProductoCDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idProductoCDataGridViewTextBoxColumn.ValueMember = "idProductoC";
            // 
            // productosCompraBindingSource1
            // 
            this.productosCompraBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.ProductosCompra);
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "precioCompra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            this.precioCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalProductoDataGridViewTextBoxColumn
            // 
            this.totalProductoDataGridViewTextBoxColumn.DataPropertyName = "totalProducto";
            this.totalProductoDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalProductoDataGridViewTextBoxColumn.Name = "totalProductoDataGridViewTextBoxColumn";
            this.totalProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detallesCompraBindingSource1
            // 
            this.detallesCompraBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.DetallesCompra);
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.Compras);
            // 
            // idProveedorComboBox
            // 
            this.idProveedorComboBox.BackColor = System.Drawing.Color.Black;
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idProveedor", true));
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idProveedor", true));
            this.idProveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.idProveedorComboBox.DisplayMember = "nombre";
            this.idProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProveedorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idProveedorComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProveedorComboBox.ForeColor = System.Drawing.Color.White;
            this.idProveedorComboBox.FormattingEnabled = true;
            this.idProveedorComboBox.Location = new System.Drawing.Point(330, 62);
            this.idProveedorComboBox.Name = "idProveedorComboBox";
            this.idProveedorComboBox.Size = new System.Drawing.Size(211, 28);
            this.idProveedorComboBox.TabIndex = 1;
            this.idProveedorComboBox.ValueMember = "idProveedor";
            this.idProveedorComboBox.SelectedIndexChanged += new System.EventHandler(this.idProveedorComboBox_SelectedIndexChanged);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.Proveedores);
            // 
            // totalaPagarTextBox
            // 
            this.totalaPagarTextBox.BackColor = System.Drawing.Color.Black;
            this.totalaPagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "totalaPagar", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.totalaPagarTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalaPagarTextBox.ForeColor = System.Drawing.Color.White;
            this.totalaPagarTextBox.Location = new System.Drawing.Point(319, 465);
            this.totalaPagarTextBox.Name = "totalaPagarTextBox";
            this.totalaPagarTextBox.Size = new System.Drawing.Size(200, 26);
            this.totalaPagarTextBox.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(608, 160);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 34);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(608, 461);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 34);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::SistemaRestaurante.Properties.Resources._61155;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(763, -4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmNuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(idProveedorLabel);
            this.Controls.Add(this.idProveedorComboBox);
            this.Controls.Add(totalaPagarLabel);
            this.Controls.Add(this.totalaPagarTextBox);
            this.Controls.Add(this.detallesCompraDataGridView);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(idProductoCLabel);
            this.Controls.Add(this.idProductoCComboBox);
            this.Controls.Add(precioCompraLabel);
            this.Controls.Add(this.precioCompraTextBox);
            this.Controls.Add(totalProductoLabel);
            this.Controls.Add(this.totalProductoTextBox);
            this.Name = "frmNuevaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNuevaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource detallesCompraBindingSource;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.ComboBox idProductoCComboBox;
        private System.Windows.Forms.TextBox precioCompraTextBox;
        private System.Windows.Forms.TextBox totalProductoTextBox;
        private System.Windows.Forms.BindingSource productosCompraBindingSource;
        private System.Windows.Forms.DataGridView detallesCompraDataGridView;
        private System.Windows.Forms.BindingSource productosCompraBindingSource1;
        private System.Windows.Forms.BindingSource detallesCompraBindingSource1;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.ComboBox idProveedorComboBox;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.TextBox totalaPagarTextBox;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProductoCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCerrar;
    }
}