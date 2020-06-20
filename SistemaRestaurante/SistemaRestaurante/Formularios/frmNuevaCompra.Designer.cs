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
            cantidadLabel.Location = new System.Drawing.Point(375, 129);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 6;
            cantidadLabel.Text = "Cantidad:";
            // 
            // idProductoCLabel
            // 
            idProductoCLabel.AutoSize = true;
            idProductoCLabel.Location = new System.Drawing.Point(92, 133);
            idProductoCLabel.Name = "idProductoCLabel";
            idProductoCLabel.Size = new System.Drawing.Size(53, 13);
            idProductoCLabel.TabIndex = 2;
            idProductoCLabel.Text = "Producto:";
            // 
            // precioCompraLabel
            // 
            precioCompraLabel.AutoSize = true;
            precioCompraLabel.Location = new System.Drawing.Point(92, 163);
            precioCompraLabel.Name = "precioCompraLabel";
            precioCompraLabel.Size = new System.Drawing.Size(40, 13);
            precioCompraLabel.TabIndex = 4;
            precioCompraLabel.Text = "Precio:";
            // 
            // totalProductoLabel
            // 
            totalProductoLabel.AutoSize = true;
            totalProductoLabel.Location = new System.Drawing.Point(375, 166);
            totalProductoLabel.Name = "totalProductoLabel";
            totalProductoLabel.Size = new System.Drawing.Size(34, 13);
            totalProductoLabel.TabIndex = 8;
            totalProductoLabel.Text = "Total:";
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Location = new System.Drawing.Point(182, 61);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(59, 13);
            idProveedorLabel.TabIndex = 0;
            idProveedorLabel.Text = "Proveedor:";
            // 
            // totalaPagarLabel
            // 
            totalaPagarLabel.AutoSize = true;
            totalaPagarLabel.Location = new System.Drawing.Point(211, 467);
            totalaPagarLabel.Name = "totalaPagarLabel";
            totalaPagarLabel.Size = new System.Drawing.Size(74, 13);
            totalaPagarLabel.TabIndex = 20;
            totalaPagarLabel.Text = "Total a Pagar:";
            // 
            // detallesCompraBindingSource
            // 
            this.detallesCompraBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.DetallesCompra);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(459, 126);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(121, 20);
            this.cantidadTextBox.TabIndex = 7;
            // 
            // idProductoCComboBox
            // 
            this.idProductoCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detallesCompraBindingSource, "idProductoC", true));
            this.idProductoCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "idProductoC", true));
            this.idProductoCComboBox.DataSource = this.productosCompraBindingSource;
            this.idProductoCComboBox.DisplayMember = "nombre";
            this.idProductoCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProductoCComboBox.FormattingEnabled = true;
            this.idProductoCComboBox.Location = new System.Drawing.Point(176, 130);
            this.idProductoCComboBox.Name = "idProductoCComboBox";
            this.idProductoCComboBox.Size = new System.Drawing.Size(121, 21);
            this.idProductoCComboBox.TabIndex = 3;
            this.idProductoCComboBox.ValueMember = "idProductoC";
            // 
            // productosCompraBindingSource
            // 
            this.productosCompraBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.ProductosCompra);
            // 
            // precioCompraTextBox
            // 
            this.precioCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "precioCompra", true));
            this.precioCompraTextBox.Location = new System.Drawing.Point(176, 160);
            this.precioCompraTextBox.Name = "precioCompraTextBox";
            this.precioCompraTextBox.Size = new System.Drawing.Size(121, 20);
            this.precioCompraTextBox.TabIndex = 5;
            // 
            // totalProductoTextBox
            // 
            this.totalProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "totalProducto", true));
            this.totalProductoTextBox.Location = new System.Drawing.Point(459, 163);
            this.totalProductoTextBox.Name = "totalProductoTextBox";
            this.totalProductoTextBox.Size = new System.Drawing.Size(121, 20);
            this.totalProductoTextBox.TabIndex = 9;
            // 
            // detallesCompraDataGridView
            // 
            this.detallesCompraDataGridView.AllowUserToAddRows = false;
            this.detallesCompraDataGridView.AllowUserToDeleteRows = false;
            this.detallesCompraDataGridView.AutoGenerateColumns = false;
            this.detallesCompraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoCDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.totalProductoDataGridViewTextBoxColumn});
            this.detallesCompraDataGridView.DataSource = this.detallesCompraBindingSource1;
            this.detallesCompraDataGridView.Location = new System.Drawing.Point(86, 224);
            this.detallesCompraDataGridView.Name = "detallesCompraDataGridView";
            this.detallesCompraDataGridView.ReadOnly = true;
            this.detallesCompraDataGridView.Size = new System.Drawing.Size(613, 220);
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
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idProveedor", true));
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idProveedor", true));
            this.idProveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.idProveedorComboBox.DisplayMember = "nombre";
            this.idProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProveedorComboBox.FormattingEnabled = true;
            this.idProveedorComboBox.Location = new System.Drawing.Point(287, 58);
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
            this.totalaPagarTextBox.Location = new System.Drawing.Point(313, 464);
            this.totalaPagarTextBox.Name = "totalaPagarTextBox";
            this.totalaPagarTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalaPagarTextBox.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(624, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(624, 161);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmNuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
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
            this.Text = "Form1";
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
    }
}