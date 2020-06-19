namespace SistemaRestaurante.Formularios
{
    partial class frmNuevaOrden
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
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label totalaPagarLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idProductoCLabel;
            System.Windows.Forms.Label precioCompraLabel;
            System.Windows.Forms.Label totalProductoLabel;
            this.productosCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalaPagarTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.detallesCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.precioCompraTextBox = new System.Windows.Forms.TextBox();
            this.totalProductoTextBox = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.idProductoCComboBox = new System.Windows.Forms.ComboBox();
            this.detallesCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idProveedorLabel = new System.Windows.Forms.Label();
            totalaPagarLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            idProductoCLabel = new System.Windows.Forms.Label();
            precioCompraLabel = new System.Windows.Forms.Label();
            totalProductoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Location = new System.Drawing.Point(231, 46);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(59, 13);
            idProveedorLabel.TabIndex = 0;
            idProveedorLabel.Text = "Proveedor:";
            // 
            // totalaPagarLabel
            // 
            totalaPagarLabel.AutoSize = true;
            totalaPagarLabel.Location = new System.Drawing.Point(242, 477);
            totalaPagarLabel.Name = "totalaPagarLabel";
            totalaPagarLabel.Size = new System.Drawing.Size(74, 13);
            totalaPagarLabel.TabIndex = 10;
            totalaPagarLabel.Text = "Total a Pagar:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(309, 98);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 6;
            cantidadLabel.Text = "Cantidad:";
            // 
            // idProductoCLabel
            // 
            idProductoCLabel.AutoSize = true;
            idProductoCLabel.Location = new System.Drawing.Point(57, 95);
            idProductoCLabel.Name = "idProductoCLabel";
            idProductoCLabel.Size = new System.Drawing.Size(53, 13);
            idProductoCLabel.TabIndex = 2;
            idProductoCLabel.Text = "Producto:";
            // 
            // precioCompraLabel
            // 
            precioCompraLabel.AutoSize = true;
            precioCompraLabel.Location = new System.Drawing.Point(57, 134);
            precioCompraLabel.Name = "precioCompraLabel";
            precioCompraLabel.Size = new System.Drawing.Size(79, 13);
            precioCompraLabel.TabIndex = 4;
            precioCompraLabel.Text = "Precio Compra:";
            // 
            // totalProductoLabel
            // 
            totalProductoLabel.AutoSize = true;
            totalProductoLabel.Location = new System.Drawing.Point(309, 134);
            totalProductoLabel.Name = "totalProductoLabel";
            totalProductoLabel.Size = new System.Drawing.Size(80, 13);
            totalProductoLabel.TabIndex = 8;
            totalProductoLabel.Text = "Total Producto:";
            // 
            // productosCompraBindingSource
            // 
            this.productosCompraBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.ProductosCompra);
            // 
            // detallesCompraBindingSource
            // 
            this.detallesCompraBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.DetallesCompra);
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.Compras);
            // 
            // idProveedorComboBox
            // 
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idProveedor", true));
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idProveedor", true));
            this.idProveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.idProveedorComboBox.DisplayMember = "nombre";
            this.idProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProveedorComboBox.FormattingEnabled = true;
            this.idProveedorComboBox.Location = new System.Drawing.Point(333, 43);
            this.idProveedorComboBox.Name = "idProveedorComboBox";
            this.idProveedorComboBox.Size = new System.Drawing.Size(200, 21);
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
            this.totalaPagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "totalaPagar", true));
            this.totalaPagarTextBox.Location = new System.Drawing.Point(344, 474);
            this.totalaPagarTextBox.Name = "totalaPagarTextBox";
            this.totalaPagarTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalaPagarTextBox.TabIndex = 11;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource1, "cantidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cantidadTextBox.Location = new System.Drawing.Point(394, 95);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(139, 20);
            this.cantidadTextBox.TabIndex = 7;
            this.cantidadTextBox.TextChanged += new System.EventHandler(this.cantidadTextBox_TextChanged);
            // 
            // detallesCompraBindingSource1
            // 
            this.detallesCompraBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.DetallesCompra);
            // 
            // productosCompraBindingSource1
            // 
            this.productosCompraBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.ProductosCompra);
            // 
            // precioCompraTextBox
            // 
            this.precioCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource1, "precioCompra", true));
            this.precioCompraTextBox.Location = new System.Drawing.Point(151, 131);
            this.precioCompraTextBox.Name = "precioCompraTextBox";
            this.precioCompraTextBox.Size = new System.Drawing.Size(121, 20);
            this.precioCompraTextBox.TabIndex = 5;
            // 
            // totalProductoTextBox
            // 
            this.totalProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource1, "totalProducto", true));
            this.totalProductoTextBox.Location = new System.Drawing.Point(394, 131);
            this.totalProductoTextBox.Name = "totalProductoTextBox";
            this.totalProductoTextBox.Size = new System.Drawing.Size(139, 20);
            this.totalProductoTextBox.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(585, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(585, 129);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar Compra";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // idProductoCComboBox
            // 
            this.idProductoCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource1, "idProductoC", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.idProductoCComboBox.DataSource = this.productosCompraBindingSource1;
            this.idProductoCComboBox.DisplayMember = "nombre";
            this.idProductoCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProductoCComboBox.FormattingEnabled = true;
            this.idProductoCComboBox.Location = new System.Drawing.Point(151, 91);
            this.idProductoCComboBox.Name = "idProductoCComboBox";
            this.idProductoCComboBox.Size = new System.Drawing.Size(121, 21);
            this.idProductoCComboBox.TabIndex = 3;
            this.idProductoCComboBox.ValueMember = "idProductoC";
            this.idProductoCComboBox.SelectedIndexChanged += new System.EventHandler(this.idProductoCComboBox_SelectedIndexChanged);
            // 
            // detallesCompraDataGridView
            // 
            this.detallesCompraDataGridView.AutoGenerateColumns = false;
            this.detallesCompraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.detallesCompraDataGridView.DataSource = this.detallesCompraBindingSource;
            this.detallesCompraDataGridView.Location = new System.Drawing.Point(77, 228);
            this.detallesCompraDataGridView.Name = "detallesCompraDataGridView";
            this.detallesCompraDataGridView.Size = new System.Drawing.Size(648, 220);
            this.detallesCompraDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idProductoC";
            this.dataGridViewTextBoxColumn2.DataSource = this.productosCompraBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "nombre";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "idProductoC";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "precioCompra";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmNuevaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.detallesCompraDataGridView);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(idProductoCLabel);
            this.Controls.Add(this.idProductoCComboBox);
            this.Controls.Add(precioCompraLabel);
            this.Controls.Add(this.precioCompraTextBox);
            this.Controls.Add(totalProductoLabel);
            this.Controls.Add(this.totalProductoTextBox);
            this.Controls.Add(idProveedorLabel);
            this.Controls.Add(this.idProveedorComboBox);
            this.Controls.Add(totalaPagarLabel);
            this.Controls.Add(this.totalaPagarTextBox);
            this.Name = "frmNuevaOrden";
            this.Text = "frmNuevaOrden";
            this.Load += new System.EventHandler(this.frmNuevaOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosCompraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productosCompraBindingSource;
        private System.Windows.Forms.BindingSource detallesCompraBindingSource;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.ComboBox idProveedorComboBox;
        private System.Windows.Forms.TextBox totalaPagarTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.BindingSource detallesCompraBindingSource1;
        private System.Windows.Forms.BindingSource productosCompraBindingSource1;
        private System.Windows.Forms.TextBox precioCompraTextBox;
        private System.Windows.Forms.TextBox totalProductoTextBox;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.ComboBox idProductoCComboBox;
        private System.Windows.Forms.DataGridView detallesCompraDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}