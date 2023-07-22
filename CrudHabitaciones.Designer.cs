namespace Hotel_Mariotti
{
    partial class CrudHabitaciones
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.habitacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.noHabitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipohabitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_MariottiDataSet = new Hotel_Mariotti.Hotel_MariottiDataSet();
            this.habitacionTableAdapter = new Hotel_Mariotti.Hotel_MariottiDataSetTableAdapters.HabitacionTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.NumeroHabitacionTXT = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.NoHabitacion = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TipoUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_MariottiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de habitacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TipoUpDown1
            // 
            this.TipoUpDown1.Location = new System.Drawing.Point(387, 69);
            this.TipoUpDown1.Name = "TipoUpDown1";
            this.TipoUpDown1.Size = new System.Drawing.Size(120, 22);
            this.TipoUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "1 para habitacion simple";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "2 para habitacion doble";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "3 para habitacion suite";
            // 
            // PrecioTXT
            // 
            this.PrecioTXT.Location = new System.Drawing.Point(655, 69);
            this.PrecioTXT.Multiline = true;
            this.PrecioTXT.Name = "PrecioTXT";
            this.PrecioTXT.Size = new System.Drawing.Size(130, 41);
            this.PrecioTXT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio de habitaciones";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(893, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // habitacionesDataGridView
            // 
            this.habitacionesDataGridView.AutoGenerateColumns = false;
            this.habitacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.habitacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noHabitacionDataGridViewTextBoxColumn,
            this.tipohabitacionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.habitacionesDataGridView.DataSource = this.habitacionBindingSource;
            this.habitacionesDataGridView.Location = new System.Drawing.Point(413, 220);
            this.habitacionesDataGridView.Name = "habitacionesDataGridView";
            this.habitacionesDataGridView.RowHeadersWidth = 51;
            this.habitacionesDataGridView.RowTemplate.Height = 24;
            this.habitacionesDataGridView.Size = new System.Drawing.Size(573, 150);
            this.habitacionesDataGridView.TabIndex = 10;
            this.habitacionesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.habitacionesDataGridView_CellContentClick);
            // 
            // noHabitacionDataGridViewTextBoxColumn
            // 
            this.noHabitacionDataGridViewTextBoxColumn.DataPropertyName = "NoHabitacion";
            this.noHabitacionDataGridViewTextBoxColumn.HeaderText = "NoHabitacion";
            this.noHabitacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noHabitacionDataGridViewTextBoxColumn.Name = "noHabitacionDataGridViewTextBoxColumn";
            this.noHabitacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.noHabitacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipohabitacionDataGridViewTextBoxColumn
            // 
            this.tipohabitacionDataGridViewTextBoxColumn.DataPropertyName = "Tipohabitacion";
            this.tipohabitacionDataGridViewTextBoxColumn.HeaderText = "Tipohabitacion";
            this.tipohabitacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipohabitacionDataGridViewTextBoxColumn.Name = "tipohabitacionDataGridViewTextBoxColumn";
            this.tipohabitacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // habitacionBindingSource
            // 
            this.habitacionBindingSource.DataMember = "Habitacion";
            this.habitacionBindingSource.DataSource = this.hotel_MariottiDataSet;
            // 
            // hotel_MariottiDataSet
            // 
            this.hotel_MariottiDataSet.DataSetName = "Hotel_MariottiDataSet";
            this.hotel_MariottiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitacionTableAdapter
            // 
            this.habitacionTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumeroHabitacionTXT
            // 
            this.NumeroHabitacionTXT.Location = new System.Drawing.Point(464, 179);
            this.NumeroHabitacionTXT.Multiline = true;
            this.NumeroHabitacionTXT.Name = "NumeroHabitacionTXT";
            this.NumeroHabitacionTXT.Size = new System.Drawing.Size(130, 35);
            this.NumeroHabitacionTXT.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(724, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(838, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 35);
            this.button4.TabIndex = 14;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NoHabitacion
            // 
            this.NoHabitacion.AutoSize = true;
            this.NoHabitacion.Location = new System.Drawing.Point(478, 160);
            this.NoHabitacion.Name = "NoHabitacion";
            this.NoHabitacion.Size = new System.Drawing.Size(93, 16);
            this.NoHabitacion.TabIndex = 15;
            this.NoHabitacion.Text = "No.Habitacion";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(655, 412);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 31);
            this.button5.TabIndex = 16;
            this.button5.Text = "Clientes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Hotel_Mariotti.Properties.Resources.Logo_sobre_moda_femenina_minimalista_neutral;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 449);
            this.panel1.TabIndex = 17;
            // 
            // CrudHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.NoHabitacion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NumeroHabitacionTXT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.habitacionesDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrecioTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoUpDown1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CrudHabitaciones";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_MariottiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TipoUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecioTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView habitacionesDataGridView;
        private Hotel_MariottiDataSet hotel_MariottiDataSet;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        private Hotel_MariottiDataSetTableAdapters.HabitacionTableAdapter habitacionTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NumeroHabitacionTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipohabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label NoHabitacion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}

