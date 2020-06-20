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
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalPagarTextBox = new System.Windows.Forms.TextBox();
            this.detallesVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productosVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            totalPagarLabel.Location = new System.Drawing.Point(220, 394);
            totalPagarLabel.Name = "totalPagarLabel";
            totalPagarLabel.Size = new System.Drawing.Size(65, 13);
            totalPagarLabel.TabIndex = 10;
            totalPagarLabel.Text = "Total Pagar:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(350, 38);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 4;
            cantidadLabel.Text = "Cantidad:";
            // 
            // idProductoVLabel
            // 
            idProductoVLabel.AutoSize = true;
            idProductoVLabel.Location = new System.Drawing.Point(86, 38);
            idProductoVLabel.Name = "idProductoVLabel";
            idProductoVLabel.Size = new System.Drawing.Size(53, 13);
            idProductoVLabel.TabIndex = 0;
            idProductoVLabel.Text = "Producto:";
            // 
            // precioVentaLabel
            // 
            precioVentaLabel.AutoSize = true;
            precioVentaLabel.Location = new System.Drawing.Point(86, 82);
            precioVentaLabel.Name = "precioVentaLabel";
            precioVentaLabel.Size = new System.Drawing.Size(40, 13);
            precioVentaLabel.TabIndex = 2;
            precioVentaLabel.Text = "Precio:";
            // 
            // totalProductoLabel
            // 
            totalProductoLabel.AutoSize = true;
            totalProductoLabel.Location = new System.Drawing.Point(350, 79);
            totalProductoLabel.Name = "totalProductoLabel";
            totalProductoLabel.Size = new System.Drawing.Size(34, 13);
            totalProductoLabel.TabIndex = 6;
            totalProductoLabel.Text = "Total:";
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.Ventas);
            // 
            // totalPagarTextBox
            // 
            this.totalPagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "TotalPagar", true));
            this.totalPagarTextBox.Location = new System.Drawing.Point(322, 391);
            this.totalPagarTextBox.Name = "totalPagarTextBox";
            this.totalPagarTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalPagarTextBox.TabIndex = 11;
            // 
            // detallesVentaBindingSource
            // 
            this.detallesVentaBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.DetallesVenta);
            // 
            // detallesVentaDataGridView
            // 
            this.detallesVentaDataGridView.AutoGenerateColumns = false;
            this.detallesVentaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.detallesVentaDataGridView.DataSource = this.detallesVentaBindingSource;
            this.detallesVentaDataGridView.Location = new System.Drawing.Point(77, 152);
            this.detallesVentaDataGridView.Name = "detallesVentaDataGridView";
            this.detallesVentaDataGridView.Size = new System.Drawing.Size(648, 220);
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
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "idProductoV";
            // 
            // productosVentaBindingSource
            // 
            this.productosVentaBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.ProductosVenta);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "precioVenta";
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
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource1, "cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(432, 35);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 5;
            // 
            // detallesVentaBindingSource1
            // 
            this.detallesVentaBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.DetallesVenta);
            // 
            // precioVentaTextBox
            // 
            this.precioVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource1, "precioVenta", true));
            this.precioVentaTextBox.Location = new System.Drawing.Point(168, 79);
            this.precioVentaTextBox.Name = "precioVentaTextBox";
            this.precioVentaTextBox.Size = new System.Drawing.Size(144, 20);
            this.precioVentaTextBox.TabIndex = 3;
            // 
            // totalProductoTextBox
            // 
            this.totalProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource1, "totalProducto", true));
            this.totalProductoTextBox.Location = new System.Drawing.Point(432, 76);
            this.totalProductoTextBox.Name = "totalProductoTextBox";
            this.totalProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalProductoTextBox.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(585, 74);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Compra";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(585, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // idProductoVComboBox
            // 
            this.idProductoVComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detallesVentaBindingSource1, "idProductoV", true));
            this.idProductoVComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "idProductoV", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.idProductoVComboBox.DataSource = this.productosVentaBindingSource1;
            this.idProductoVComboBox.DisplayMember = "nombre";
            this.idProductoVComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProductoVComboBox.FormattingEnabled = true;
            this.idProductoVComboBox.Location = new System.Drawing.Point(168, 38);
            this.idProductoVComboBox.Name = "idProductoVComboBox";
            this.idProductoVComboBox.Size = new System.Drawing.Size(144, 21);
            this.idProductoVComboBox.TabIndex = 1;
            this.idProductoVComboBox.ValueMember = "idProductoV";
            // 
            // productosVentaBindingSource1
            // 
            this.productosVentaBindingSource1.DataSource = typeof(SistemaRestaurante.Entidades.ProductosVenta);
            // 
            // frmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 433);
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
            this.Text = "frmNuevaVenta";
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
    }
}