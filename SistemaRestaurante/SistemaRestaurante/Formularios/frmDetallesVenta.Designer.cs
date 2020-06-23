namespace SistemaRestaurante.Formularios
{
    partial class frmDetallesVenta
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idVentaLabel;
            System.Windows.Forms.Label totalPagarLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idVentaTextBox = new System.Windows.Forms.TextBox();
            this.totalPagarTextBox = new System.Windows.Forms.TextBox();
            this.detallesVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.btnRecibida = new System.Windows.Forms.Button();
            this.btnEntregada = new System.Windows.Forms.Button();
            this.btnPagada = new System.Windows.Forms.Button();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productosVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            fechaLabel = new System.Windows.Forms.Label();
            idVentaLabel = new System.Windows.Forms.Label();
            totalPagarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.ForeColor = System.Drawing.Color.White;
            fechaLabel.Location = new System.Drawing.Point(400, 102);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(67, 25);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha:";
            // 
            // idVentaLabel
            // 
            idVentaLabel.AutoSize = true;
            idVentaLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idVentaLabel.ForeColor = System.Drawing.Color.White;
            idVentaLabel.Location = new System.Drawing.Point(52, 103);
            idVentaLabel.Name = "idVentaLabel";
            idVentaLabel.Size = new System.Drawing.Size(31, 25);
            idVentaLabel.TabIndex = 5;
            idVentaLabel.Text = "Id:";
            // 
            // totalPagarLabel
            // 
            totalPagarLabel.AutoSize = true;
            totalPagarLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalPagarLabel.ForeColor = System.Drawing.Color.White;
            totalPagarLabel.Location = new System.Drawing.Point(221, 421);
            totalPagarLabel.Name = "totalPagarLabel";
            totalPagarLabel.Size = new System.Drawing.Size(109, 25);
            totalPagarLabel.TabIndex = 9;
            totalPagarLabel.Text = "Total Pagar:";
            // 
            // idVentaTextBox
            // 
            this.idVentaTextBox.BackColor = System.Drawing.Color.Black;
            this.idVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idVenta", true));
            this.idVentaTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idVentaTextBox.ForeColor = System.Drawing.Color.White;
            this.idVentaTextBox.Location = new System.Drawing.Point(98, 103);
            this.idVentaTextBox.Name = "idVentaTextBox";
            this.idVentaTextBox.Size = new System.Drawing.Size(200, 26);
            this.idVentaTextBox.TabIndex = 6;
            // 
            // totalPagarTextBox
            // 
            this.totalPagarTextBox.BackColor = System.Drawing.Color.Black;
            this.totalPagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "TotalPagar", true));
            this.totalPagarTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPagarTextBox.ForeColor = System.Drawing.Color.White;
            this.totalPagarTextBox.Location = new System.Drawing.Point(336, 421);
            this.totalPagarTextBox.Name = "totalPagarTextBox";
            this.totalPagarTextBox.Size = new System.Drawing.Size(200, 26);
            this.totalPagarTextBox.TabIndex = 10;
            // 
            // detallesVentaDataGridView
            // 
            this.detallesVentaDataGridView.AutoGenerateColumns = false;
            this.detallesVentaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesVentaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.detallesVentaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detallesVentaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detallesVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.detallesVentaDataGridView.DataSource = this.detallesVentaBindingSource;
            this.detallesVentaDataGridView.EnableHeadersVisualStyles = false;
            this.detallesVentaDataGridView.Location = new System.Drawing.Point(57, 158);
            this.detallesVentaDataGridView.Name = "detallesVentaDataGridView";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            this.detallesVentaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.detallesVentaDataGridView.Size = new System.Drawing.Size(670, 220);
            this.detallesVentaDataGridView.TabIndex = 10;
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.BackColor = System.Drawing.Color.Black;
            this.fechaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Fecha", true));
            this.fechaTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaTextBox.ForeColor = System.Drawing.Color.White;
            this.fechaTextBox.Location = new System.Drawing.Point(502, 102);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.Size = new System.Drawing.Size(225, 26);
            this.fechaTextBox.TabIndex = 11;
            // 
            // btnRecibida
            // 
            this.btnRecibida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecibida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibida.ForeColor = System.Drawing.Color.White;
            this.btnRecibida.Location = new System.Drawing.Point(57, 46);
            this.btnRecibida.Name = "btnRecibida";
            this.btnRecibida.Size = new System.Drawing.Size(161, 30);
            this.btnRecibida.TabIndex = 12;
            this.btnRecibida.Text = "Marcar como Recibida";
            this.btnRecibida.UseVisualStyleBackColor = true;
            this.btnRecibida.Click += new System.EventHandler(this.btnRecibida_Click);
            // 
            // btnEntregada
            // 
            this.btnEntregada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntregada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregada.ForeColor = System.Drawing.Color.White;
            this.btnEntregada.Location = new System.Drawing.Point(304, 46);
            this.btnEntregada.Name = "btnEntregada";
            this.btnEntregada.Size = new System.Drawing.Size(184, 30);
            this.btnEntregada.TabIndex = 13;
            this.btnEntregada.Text = "Marcar como Entregada";
            this.btnEntregada.UseVisualStyleBackColor = true;
            this.btnEntregada.Click += new System.EventHandler(this.btnEntregada_Click);
            // 
            // btnPagada
            // 
            this.btnPagada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagada.ForeColor = System.Drawing.Color.White;
            this.btnPagada.Location = new System.Drawing.Point(566, 46);
            this.btnPagada.Name = "btnPagada";
            this.btnPagada.Size = new System.Drawing.Size(161, 30);
            this.btnPagada.TabIndex = 14;
            this.btnPagada.Text = "Marcar como Pagada";
            this.btnPagada.UseVisualStyleBackColor = true;
            this.btnPagada.Click += new System.EventHandler(this.btnPagada_Click);
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.Ventas);
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
            // detallesVentaBindingSource
            // 
            this.detallesVentaBindingSource.DataSource = typeof(SistemaRestaurante.Entidades.DetallesVenta);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::SistemaRestaurante.Properties.Resources._61155;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(766, -3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmDetallesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPagada);
            this.Controls.Add(this.btnEntregada);
            this.Controls.Add(this.btnRecibida);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(this.detallesVentaDataGridView);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(idVentaLabel);
            this.Controls.Add(this.idVentaTextBox);
            this.Controls.Add(totalPagarLabel);
            this.Controls.Add(this.totalPagarTextBox);
            this.Name = "frmDetallesVenta";
            this.Load += new System.EventHandler(this.frmDetallesVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ventasBindingSource;
        private System.Windows.Forms.TextBox idVentaTextBox;
        private System.Windows.Forms.TextBox totalPagarTextBox;
        private System.Windows.Forms.BindingSource detallesVentaBindingSource;
        private System.Windows.Forms.DataGridView detallesVentaDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource productosVentaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.Button btnRecibida;
        private System.Windows.Forms.Button btnEntregada;
        private System.Windows.Forms.Button btnPagada;
        private System.Windows.Forms.Button btnCerrar;
    }
}