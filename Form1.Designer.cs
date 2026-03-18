namespace Alquiler_autos
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonMostrar2 = new System.Windows.Forms.Button();
            this.dataGridViewVehiculo = new System.Windows.Forms.DataGridView();
            this.buttonVehiculo = new System.Windows.Forms.Button();
            this.numericUpDownPrecio_porKm = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownModelo = new System.Windows.Forms.NumericUpDown();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonMostrar1 = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPlaca2 = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaca1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerAlquiler = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerdev = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownk_re = new System.Windows.Forms.NumericUpDown();
            this.buttonG1 = new System.Windows.Forms.Button();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.labelMaxKm = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio_porKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModelo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownk_re)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 649);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxPlaca1);
            this.tabPage1.Controls.Add(this.buttonMostrar2);
            this.tabPage1.Controls.Add(this.dataGridViewVehiculo);
            this.tabPage1.Controls.Add(this.buttonMostrar1);
            this.tabPage1.Controls.Add(this.dataGridViewClientes);
            this.tabPage1.Controls.Add(this.buttonVehiculo);
            this.tabPage1.Controls.Add(this.numericUpDownPrecio_porKm);
            this.tabPage1.Controls.Add(this.numericUpDownModelo);
            this.tabPage1.Controls.Add(this.textBoxMarca);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1110, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehiculos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonMostrar2
            // 
            this.buttonMostrar2.Location = new System.Drawing.Point(878, 356);
            this.buttonMostrar2.Name = "buttonMostrar2";
            this.buttonMostrar2.Size = new System.Drawing.Size(174, 61);
            this.buttonMostrar2.TabIndex = 12;
            this.buttonMostrar2.Text = "Mostrar vehiculos";
            this.buttonMostrar2.UseVisualStyleBackColor = true;
            this.buttonMostrar2.Click += new System.EventHandler(this.buttonMostrar2_Click);
            // 
            // dataGridViewVehiculo
            // 
            this.dataGridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculo.Location = new System.Drawing.Point(341, 293);
            this.dataGridViewVehiculo.Name = "dataGridViewVehiculo";
            this.dataGridViewVehiculo.RowHeadersWidth = 51;
            this.dataGridViewVehiculo.RowTemplate.Height = 24;
            this.dataGridViewVehiculo.Size = new System.Drawing.Size(518, 194);
            this.dataGridViewVehiculo.TabIndex = 11;
            // 
            // buttonVehiculo
            // 
            this.buttonVehiculo.Location = new System.Drawing.Point(54, 483);
            this.buttonVehiculo.Name = "buttonVehiculo";
            this.buttonVehiculo.Size = new System.Drawing.Size(213, 84);
            this.buttonVehiculo.TabIndex = 8;
            this.buttonVehiculo.Text = "Registrar";
            this.buttonVehiculo.UseVisualStyleBackColor = true;
            this.buttonVehiculo.Click += new System.EventHandler(this.buttonVehiculo_Click);
            // 
            // numericUpDownPrecio_porKm
            // 
            this.numericUpDownPrecio_porKm.DecimalPlaces = 2;
            this.numericUpDownPrecio_porKm.Location = new System.Drawing.Point(25, 398);
            this.numericUpDownPrecio_porKm.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownPrecio_porKm.Name = "numericUpDownPrecio_porKm";
            this.numericUpDownPrecio_porKm.Size = new System.Drawing.Size(260, 22);
            this.numericUpDownPrecio_porKm.TabIndex = 7;
            // 
            // numericUpDownModelo
            // 
            this.numericUpDownModelo.Location = new System.Drawing.Point(25, 280);
            this.numericUpDownModelo.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDownModelo.Name = "numericUpDownModelo";
            this.numericUpDownModelo.Size = new System.Drawing.Size(260, 22);
            this.numericUpDownModelo.TabIndex = 6;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(25, 180);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(260, 22);
            this.textBoxMarca.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese el precio por kilometro del vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el model del vehiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la marca del vehiculo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero de placa del vehiculo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelMaxKm);
            this.tabPage2.Controls.Add(this.buttonGenerar);
            this.tabPage2.Controls.Add(this.dataGridViewReporte);
            this.tabPage2.Controls.Add(this.buttonG1);
            this.tabPage2.Controls.Add(this.numericUpDownk_re);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dateTimePickerdev);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dateTimePickerAlquiler);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBoxPlaca2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBoxCliente);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1110, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alquiler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonMostrar1
            // 
            this.buttonMostrar1.Location = new System.Drawing.Point(865, 102);
            this.buttonMostrar1.Name = "buttonMostrar1";
            this.buttonMostrar1.Size = new System.Drawing.Size(187, 61);
            this.buttonMostrar1.TabIndex = 10;
            this.buttonMostrar1.Text = "Mostrar clientes";
            this.buttonMostrar1.UseVisualStyleBackColor = true;
            this.buttonMostrar1.Click += new System.EventHandler(this.buttonMostrar1_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(341, 24);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(518, 199);
            this.dataGridViewClientes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ingrese NIT del cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(27, 57);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(325, 24);
            this.comboBoxCliente.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Placa del auto a alquilar";
            // 
            // comboBoxPlaca2
            // 
            this.comboBoxPlaca2.FormattingEnabled = true;
            this.comboBoxPlaca2.Location = new System.Drawing.Point(30, 142);
            this.comboBoxPlaca2.Name = "comboBoxPlaca2";
            this.comboBoxPlaca2.Size = new System.Drawing.Size(322, 24);
            this.comboBoxPlaca2.TabIndex = 3;
            // 
            // comboBoxPlaca1
            // 
            this.comboBoxPlaca1.FormattingEnabled = true;
            this.comboBoxPlaca1.Location = new System.Drawing.Point(25, 102);
            this.comboBoxPlaca1.Name = "comboBoxPlaca1";
            this.comboBoxPlaca1.Size = new System.Drawing.Size(260, 24);
            this.comboBoxPlaca1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha de alquiler";
            // 
            // dateTimePickerAlquiler
            // 
            this.dateTimePickerAlquiler.Location = new System.Drawing.Point(33, 229);
            this.dateTimePickerAlquiler.Name = "dateTimePickerAlquiler";
            this.dateTimePickerAlquiler.Size = new System.Drawing.Size(319, 22);
            this.dateTimePickerAlquiler.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha de devolucion";
            // 
            // dateTimePickerdev
            // 
            this.dateTimePickerdev.Location = new System.Drawing.Point(33, 321);
            this.dateTimePickerdev.Name = "dateTimePickerdev";
            this.dateTimePickerdev.Size = new System.Drawing.Size(316, 22);
            this.dateTimePickerdev.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kilometros Recorridos";
            // 
            // numericUpDownk_re
            // 
            this.numericUpDownk_re.DecimalPlaces = 2;
            this.numericUpDownk_re.Location = new System.Drawing.Point(39, 402);
            this.numericUpDownk_re.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            this.numericUpDownk_re.Name = "numericUpDownk_re";
            this.numericUpDownk_re.Size = new System.Drawing.Size(313, 22);
            this.numericUpDownk_re.TabIndex = 9;
            // 
            // buttonG1
            // 
            this.buttonG1.Location = new System.Drawing.Point(52, 496);
            this.buttonG1.Name = "buttonG1";
            this.buttonG1.Size = new System.Drawing.Size(259, 81);
            this.buttonG1.TabIndex = 10;
            this.buttonG1.Text = "Registrar";
            this.buttonG1.UseVisualStyleBackColor = true;
            this.buttonG1.Click += new System.EventHandler(this.buttonG1_Click);
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(443, 37);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.RowHeadersWidth = 51;
            this.dataGridViewReporte.RowTemplate.Height = 24;
            this.dataGridViewReporte.Size = new System.Drawing.Size(602, 395);
            this.dataGridViewReporte.TabIndex = 11;
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(742, 496);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(217, 66);
            this.buttonGenerar.TabIndex = 12;
            this.buttonGenerar.Text = "Generar Reporte";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // labelMaxKm
            // 
            this.labelMaxKm.AutoSize = true;
            this.labelMaxKm.Location = new System.Drawing.Point(440, 511);
            this.labelMaxKm.Name = "labelMaxKm";
            this.labelMaxKm.Size = new System.Drawing.Size(0, 16);
            this.labelMaxKm.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 663);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio_porKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModelo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownk_re)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonVehiculo;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecio_porKm;
        private System.Windows.Forms.NumericUpDown numericUpDownModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Button buttonMostrar2;
        private System.Windows.Forms.DataGridView dataGridViewVehiculo;
        private System.Windows.Forms.Button buttonMostrar1;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxPlaca2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPlaca1;
        private System.Windows.Forms.Button buttonG1;
        private System.Windows.Forms.NumericUpDown numericUpDownk_re;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerdev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlquiler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Label labelMaxKm;
    }
}

