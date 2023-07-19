namespace Hotel_Mariotti
{
    partial class Reserva
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
            this.NoHabitacionCBX = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NoReservaUPDOWN = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SalidaDTP = new System.Windows.Forms.DateTimePicker();
            this.EntradaDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxNocliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoReservaUPDOWN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // NoHabitacionCBX
            // 
            this.NoHabitacionCBX.FormattingEnabled = true;
            this.NoHabitacionCBX.Location = new System.Drawing.Point(114, 75);
            this.NoHabitacionCBX.Name = "NoHabitacionCBX";
            this.NoHabitacionCBX.Size = new System.Drawing.Size(168, 24);
            this.NoHabitacionCBX.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "No.Reserva";
            // 
            // NoReservaUPDOWN
            // 
            this.NoReservaUPDOWN.Location = new System.Drawing.Point(122, 135);
            this.NoReservaUPDOWN.Name = "NoReservaUPDOWN";
            this.NoReservaUPDOWN.Size = new System.Drawing.Size(120, 22);
            this.NoReservaUPDOWN.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Llegada";
            // 
            // SalidaDTP
            // 
            this.SalidaDTP.Location = new System.Drawing.Point(503, 73);
            this.SalidaDTP.Name = "SalidaDTP";
            this.SalidaDTP.Size = new System.Drawing.Size(200, 22);
            this.SalidaDTP.TabIndex = 53;
            // 
            // EntradaDTP
            // 
            this.EntradaDTP.Location = new System.Drawing.Point(297, 73);
            this.EntradaDTP.Name = "EntradaDTP";
            this.EntradaDTP.Size = new System.Drawing.Size(200, 22);
            this.EntradaDTP.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "No.Habitacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 59;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxNocliente
            // 
            this.TextBoxNocliente.Location = new System.Drawing.Point(308, 138);
            this.TextBoxNocliente.Name = "TextBoxNocliente";
            this.TextBoxNocliente.Size = new System.Drawing.Size(100, 22);
            this.TextBoxNocliente.TabIndex = 60;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 61;
            this.button2.Text = "Cargar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataGridViewCliente
            // 
            this.DataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCliente.Location = new System.Drawing.Point(114, 187);
            this.DataGridViewCliente.Name = "DataGridViewCliente";
            this.DataGridViewCliente.RowHeadersWidth = 51;
            this.DataGridViewCliente.RowTemplate.Height = 24;
            this.DataGridViewCliente.Size = new System.Drawing.Size(603, 215);
            this.DataGridViewCliente.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "No.CLiente";
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextBoxNocliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NoHabitacionCBX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NoReservaUPDOWN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SalidaDTP);
            this.Controls.Add(this.EntradaDTP);
            this.Controls.Add(this.label1);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoReservaUPDOWN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NoHabitacionCBX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NoReservaUPDOWN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker SalidaDTP;
        private System.Windows.Forms.DateTimePicker EntradaDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxNocliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DataGridViewCliente;
        private System.Windows.Forms.Label label2;
    }
}