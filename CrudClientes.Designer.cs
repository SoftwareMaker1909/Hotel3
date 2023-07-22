namespace Hotel_Mariotti
{
    partial class CrudClientes
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
            this.button5 = new System.Windows.Forms.Button();
            this.ActualizarBTN = new System.Windows.Forms.Button();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.ClienteTXT = new System.Windows.Forms.TextBox();
            this.BuscarBTN = new System.Windows.Forms.Button();
            this.DataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.NoHabitacion = new System.Windows.Forms.Label();
            this.NombreTXT = new System.Windows.Forms.TextBox();
            this.ApellidoTXT = new System.Windows.Forms.TextBox();
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_MariottiDataSet1 = new Hotel_Mariotti.Hotel_MariottiDataSet1();
            this.habitacionTableAdapter = new Hotel_Mariotti.Hotel_MariottiDataSet1TableAdapters.HabitacionTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SexoCBX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DireccionTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TelefonoTXT = new System.Windows.Forms.TextBox();
            this.hotel_MariottiDataSet2 = new Hotel_Mariotti.Hotel_MariottiDataSet2();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Hotel_Mariotti.Hotel_MariottiDataSet2TableAdapters.ClienteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_MariottiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_MariottiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 31);
            this.button5.TabIndex = 31;
            this.button5.Text = "Reserva";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ActualizarBTN
            // 
            this.ActualizarBTN.Location = new System.Drawing.Point(558, 235);
            this.ActualizarBTN.Name = "ActualizarBTN";
            this.ActualizarBTN.Size = new System.Drawing.Size(93, 35);
            this.ActualizarBTN.TabIndex = 29;
            this.ActualizarBTN.Text = "Actualizar";
            this.ActualizarBTN.UseVisualStyleBackColor = true;
            this.ActualizarBTN.Click += new System.EventHandler(this.ActualizarBTN_Click);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Location = new System.Drawing.Point(444, 235);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(93, 35);
            this.EliminarBTN.TabIndex = 28;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // ClienteTXT
            // 
            this.ClienteTXT.Location = new System.Drawing.Point(177, 235);
            this.ClienteTXT.Multiline = true;
            this.ClienteTXT.Name = "ClienteTXT";
            this.ClienteTXT.Size = new System.Drawing.Size(130, 35);
            this.ClienteTXT.TabIndex = 27;
            // 
            // BuscarBTN
            // 
            this.BuscarBTN.Location = new System.Drawing.Point(334, 235);
            this.BuscarBTN.Name = "BuscarBTN";
            this.BuscarBTN.Size = new System.Drawing.Size(93, 35);
            this.BuscarBTN.TabIndex = 26;
            this.BuscarBTN.Text = "Buscar";
            this.BuscarBTN.UseVisualStyleBackColor = true;
            this.BuscarBTN.Click += new System.EventHandler(this.BuscarBTN_Click);
            // 
            // DataGridViewCliente
            // 
            this.DataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCliente.Location = new System.Drawing.Point(162, 276);
            this.DataGridViewCliente.Name = "DataGridViewCliente";
            this.DataGridViewCliente.RowHeadersWidth = 51;
            this.DataGridViewCliente.RowTemplate.Height = 24;
            this.DataGridViewCliente.Size = new System.Drawing.Size(694, 150);
            this.DataGridViewCliente.TabIndex = 25;
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Location = new System.Drawing.Point(660, 238);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(84, 32);
            this.Agregarbtn.TabIndex = 24;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // NoHabitacion
            // 
            this.NoHabitacion.AutoSize = true;
            this.NoHabitacion.Location = new System.Drawing.Point(219, 216);
            this.NoHabitacion.Name = "NoHabitacion";
            this.NoHabitacion.Size = new System.Drawing.Size(48, 16);
            this.NoHabitacion.TabIndex = 30;
            this.NoHabitacion.Text = "Cliente";
            this.NoHabitacion.Click += new System.EventHandler(this.NoHabitacion_Click);
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(156, 62);
            this.NombreTXT.Multiline = true;
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(130, 35);
            this.NombreTXT.TabIndex = 32;
            // 
            // ApellidoTXT
            // 
            this.ApellidoTXT.Location = new System.Drawing.Point(339, 62);
            this.ApellidoTXT.Multiline = true;
            this.ApellidoTXT.Name = "ApellidoTXT";
            this.ApellidoTXT.Size = new System.Drawing.Size(130, 35);
            this.ApellidoTXT.TabIndex = 33;
            // 
            // habitacionBindingSource
            // 
            this.habitacionBindingSource.DataMember = "Habitacion";
            this.habitacionBindingSource.DataSource = this.hotel_MariottiDataSet1;
            // 
            // hotel_MariottiDataSet1
            // 
            this.hotel_MariottiDataSet1.DataSetName = "Hotel_MariottiDataSet1";
            this.hotel_MariottiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitacionTableAdapter
            // 
            this.habitacionTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Apellido";
            // 
            // SexoCBX
            // 
            this.SexoCBX.FormattingEnabled = true;
            this.SexoCBX.Items.AddRange(new object[] {
            "M",
            "F"});
            this.SexoCBX.Location = new System.Drawing.Point(165, 127);
            this.SexoCBX.Name = "SexoCBX";
            this.SexoCBX.Size = new System.Drawing.Size(121, 24);
            this.SexoCBX.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Sexo";
            // 
            // DireccionTXT
            // 
            this.DireccionTXT.Location = new System.Drawing.Point(493, 62);
            this.DireccionTXT.Multiline = true;
            this.DireccionTXT.Name = "DireccionTXT";
            this.DireccionTXT.Size = new System.Drawing.Size(130, 35);
            this.DireccionTXT.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Telefono";
            // 
            // TelefonoTXT
            // 
            this.TelefonoTXT.Location = new System.Drawing.Point(632, 62);
            this.TelefonoTXT.Multiline = true;
            this.TelefonoTXT.Name = "TelefonoTXT";
            this.TelefonoTXT.Size = new System.Drawing.Size(130, 35);
            this.TelefonoTXT.TabIndex = 42;
            // 
            // hotel_MariottiDataSet2
            // 
            this.hotel_MariottiDataSet2.DataSetName = "Hotel_MariottiDataSet2";
            this.hotel_MariottiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.hotel_MariottiDataSet2;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 51;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 31);
            this.button2.TabIndex = 52;
            this.button2.Text = "Habitacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CrudClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Mariotti.Properties.Resources.Logo_sobre_moda_femenina_minimalista_neutral;
            this.ClientSize = new System.Drawing.Size(944, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelefonoTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DireccionTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SexoCBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApellidoTXT);
            this.Controls.Add(this.NombreTXT);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.NoHabitacion);
            this.Controls.Add(this.ActualizarBTN);
            this.Controls.Add(this.EliminarBTN);
            this.Controls.Add(this.ClienteTXT);
            this.Controls.Add(this.BuscarBTN);
            this.Controls.Add(this.DataGridViewCliente);
            this.Controls.Add(this.Agregarbtn);
            this.DoubleBuffered = true;
            this.Name = "CrudClientes";
            this.Text = "CrudClientes";
            this.Load += new System.EventHandler(this.CrudClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_MariottiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_MariottiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ActualizarBTN;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.TextBox ClienteTXT;
        private System.Windows.Forms.Button BuscarBTN;
        private System.Windows.Forms.DataGridView DataGridViewCliente;
        private System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.Label NoHabitacion;
        private System.Windows.Forms.TextBox NombreTXT;
        private System.Windows.Forms.TextBox ApellidoTXT;
        private Hotel_MariottiDataSet1 hotel_MariottiDataSet1;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        private Hotel_MariottiDataSet1TableAdapters.HabitacionTableAdapter habitacionTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SexoCBX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DireccionTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TelefonoTXT;
        private Hotel_MariottiDataSet2 hotel_MariottiDataSet2;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Hotel_MariottiDataSet2TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}