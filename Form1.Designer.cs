
namespace AlquilerAutos
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
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPrecioXkilometro = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxPrecioXkilometro = new System.Windows.Forms.TextBox();
            this.labelDatosVehiculo = new System.Windows.Forms.Label();
            this.buttonGuardarVehiculo = new System.Windows.Forms.Button();
            this.buttonLimpiarVehiculo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewVehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewAlquileres = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaDev = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaAl = new System.Windows.Forms.DateTimePicker();
            this.labelAl_datosVehiculo = new System.Windows.Forms.Label();
            this.labelAl_clienteNombre = new System.Windows.Forms.Label();
            this.comboBoxAl_placa = new System.Windows.Forms.ComboBox();
            this.comboBoxAl_nit = new System.Windows.Forms.ComboBox();
            this.labelAlquileres = new System.Windows.Forms.Label();
            this.buttonLimpiarAlquiler = new System.Windows.Forms.Button();
            this.buttonRegistrarAlquiler = new System.Windows.Forms.Button();
            this.labelAl_nit = new System.Windows.Forms.Label();
            this.labelAl_placa = new System.Windows.Forms.Label();
            this.textBoxAl_kmRecorridos = new System.Windows.Forms.TextBox();
            this.labelAl_fechaAlquiler = new System.Windows.Forms.Label();
            this.labelAl_fechaDev = new System.Windows.Forms.Label();
            this.labelAl_kmRecorridos = new System.Windows.Forms.Label();
            this.dataGridViewReportes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaca.Location = new System.Drawing.Point(21, 52);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(43, 16);
            this.labelPlaca.TabIndex = 1;
            this.labelPlaca.Text = "Placa";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(21, 93);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(46, 16);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(21, 128);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(54, 16);
            this.labelModelo.TabIndex = 3;
            this.labelModelo.Text = "Modelo";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(21, 163);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(40, 16);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Color";
            // 
            // labelPrecioXkilometro
            // 
            this.labelPrecioXkilometro.AutoSize = true;
            this.labelPrecioXkilometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioXkilometro.Location = new System.Drawing.Point(21, 199);
            this.labelPrecioXkilometro.Name = "labelPrecioXkilometro";
            this.labelPrecioXkilometro.Size = new System.Drawing.Size(107, 16);
            this.labelPrecioXkilometro.TabIndex = 5;
            this.labelPrecioXkilometro.Text = "Precio/Kilometro";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(148, 85);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(206, 22);
            this.textBoxMarca.TabIndex = 2;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelo.Location = new System.Drawing.Point(148, 120);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(206, 22);
            this.textBoxModelo.TabIndex = 3;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(148, 155);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(206, 22);
            this.textBoxColor.TabIndex = 4;
            // 
            // textBoxPrecioXkilometro
            // 
            this.textBoxPrecioXkilometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioXkilometro.Location = new System.Drawing.Point(148, 192);
            this.textBoxPrecioXkilometro.Name = "textBoxPrecioXkilometro";
            this.textBoxPrecioXkilometro.Size = new System.Drawing.Size(206, 22);
            this.textBoxPrecioXkilometro.TabIndex = 5;
            // 
            // labelDatosVehiculo
            // 
            this.labelDatosVehiculo.AutoSize = true;
            this.labelDatosVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosVehiculo.Location = new System.Drawing.Point(94, 10);
            this.labelDatosVehiculo.Name = "labelDatosVehiculo";
            this.labelDatosVehiculo.Size = new System.Drawing.Size(167, 24);
            this.labelDatosVehiculo.TabIndex = 10;
            this.labelDatosVehiculo.Text = "Ingresar Vehiculos";
            // 
            // buttonGuardarVehiculo
            // 
            this.buttonGuardarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarVehiculo.Location = new System.Drawing.Point(41, 237);
            this.buttonGuardarVehiculo.Name = "buttonGuardarVehiculo";
            this.buttonGuardarVehiculo.Size = new System.Drawing.Size(129, 32);
            this.buttonGuardarVehiculo.TabIndex = 6;
            this.buttonGuardarVehiculo.Text = "Guardar Vehiculo";
            this.buttonGuardarVehiculo.UseVisualStyleBackColor = true;
            this.buttonGuardarVehiculo.Click += new System.EventHandler(this.buttonGuardarVehiculo_Click);
            // 
            // buttonLimpiarVehiculo
            // 
            this.buttonLimpiarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarVehiculo.Location = new System.Drawing.Point(194, 237);
            this.buttonLimpiarVehiculo.Name = "buttonLimpiarVehiculo";
            this.buttonLimpiarVehiculo.Size = new System.Drawing.Size(108, 32);
            this.buttonLimpiarVehiculo.TabIndex = 7;
            this.buttonLimpiarVehiculo.Text = "Limpiar";
            this.buttonLimpiarVehiculo.UseVisualStyleBackColor = true;
            this.buttonLimpiarVehiculo.Click += new System.EventHandler(this.buttonLimpiarVehiculo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxPlaca);
            this.groupBox1.Controls.Add(this.labelDatosVehiculo);
            this.groupBox1.Controls.Add(this.buttonLimpiarVehiculo);
            this.groupBox1.Controls.Add(this.buttonGuardarVehiculo);
            this.groupBox1.Controls.Add(this.labelPlaca);
            this.groupBox1.Controls.Add(this.labelMarca);
            this.groupBox1.Controls.Add(this.textBoxPrecioXkilometro);
            this.groupBox1.Controls.Add(this.labelModelo);
            this.groupBox1.Controls.Add(this.textBoxColor);
            this.groupBox1.Controls.Add(this.labelColor);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.labelPrecioXkilometro);
            this.groupBox1.Controls.Add(this.textBoxMarca);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 289);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBoxPlaca
            // 
            this.maskedTextBoxPlaca.Location = new System.Drawing.Point(148, 48);
            this.maskedTextBoxPlaca.Mask = "A-00000";
            this.maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            this.maskedTextBoxPlaca.Size = new System.Drawing.Size(206, 20);
            this.maskedTextBoxPlaca.TabIndex = 1;
            this.maskedTextBoxPlaca.Click += new System.EventHandler(this.maskedTextBoxPlaca_Click);
            this.maskedTextBoxPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxPlaca_KeyPress);
            // 
            // dataGridViewVehiculos
            // 
            this.dataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculos.Location = new System.Drawing.Point(412, 12);
            this.dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            this.dataGridViewVehiculos.Size = new System.Drawing.Size(552, 151);
            this.dataGridViewVehiculos.TabIndex = 14;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(412, 175);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(552, 139);
            this.dataGridViewClientes.TabIndex = 15;
            // 
            // dataGridViewAlquileres
            // 
            this.dataGridViewAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquileres.Location = new System.Drawing.Point(412, 323);
            this.dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            this.dataGridViewAlquileres.Size = new System.Drawing.Size(552, 129);
            this.dataGridViewAlquileres.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerFechaDev);
            this.groupBox2.Controls.Add(this.dateTimePickerFechaAl);
            this.groupBox2.Controls.Add(this.labelAl_datosVehiculo);
            this.groupBox2.Controls.Add(this.labelAl_clienteNombre);
            this.groupBox2.Controls.Add(this.comboBoxAl_placa);
            this.groupBox2.Controls.Add(this.comboBoxAl_nit);
            this.groupBox2.Controls.Add(this.labelAlquileres);
            this.groupBox2.Controls.Add(this.buttonLimpiarAlquiler);
            this.groupBox2.Controls.Add(this.buttonRegistrarAlquiler);
            this.groupBox2.Controls.Add(this.labelAl_nit);
            this.groupBox2.Controls.Add(this.labelAl_placa);
            this.groupBox2.Controls.Add(this.textBoxAl_kmRecorridos);
            this.groupBox2.Controls.Add(this.labelAl_fechaAlquiler);
            this.groupBox2.Controls.Add(this.labelAl_fechaDev);
            this.groupBox2.Controls.Add(this.labelAl_kmRecorridos);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 310);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePickerFechaDev
            // 
            this.dateTimePickerFechaDev.Location = new System.Drawing.Point(158, 187);
            this.dateTimePickerFechaDev.Name = "dateTimePickerFechaDev";
            this.dateTimePickerFechaDev.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerFechaDev.TabIndex = 11;
            // 
            // dateTimePickerFechaAl
            // 
            this.dateTimePickerFechaAl.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFechaAl.Location = new System.Drawing.Point(158, 152);
            this.dateTimePickerFechaAl.Name = "dateTimePickerFechaAl";
            this.dateTimePickerFechaAl.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerFechaAl.TabIndex = 10;
            // 
            // labelAl_datosVehiculo
            // 
            this.labelAl_datosVehiculo.AutoSize = true;
            this.labelAl_datosVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAl_datosVehiculo.Location = new System.Drawing.Point(155, 125);
            this.labelAl_datosVehiculo.Name = "labelAl_datosVehiculo";
            this.labelAl_datosVehiculo.Size = new System.Drawing.Size(17, 16);
            this.labelAl_datosVehiculo.TabIndex = 16;
            this.labelAl_datosVehiculo.Text = "...";
            // 
            // labelAl_clienteNombre
            // 
            this.labelAl_clienteNombre.AutoSize = true;
            this.labelAl_clienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAl_clienteNombre.Location = new System.Drawing.Point(155, 75);
            this.labelAl_clienteNombre.Name = "labelAl_clienteNombre";
            this.labelAl_clienteNombre.Size = new System.Drawing.Size(17, 16);
            this.labelAl_clienteNombre.TabIndex = 15;
            this.labelAl_clienteNombre.Text = "...";
            // 
            // comboBoxAl_placa
            // 
            this.comboBoxAl_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAl_placa.FormattingEnabled = true;
            this.comboBoxAl_placa.Location = new System.Drawing.Point(158, 98);
            this.comboBoxAl_placa.Name = "comboBoxAl_placa";
            this.comboBoxAl_placa.Size = new System.Drawing.Size(196, 24);
            this.comboBoxAl_placa.TabIndex = 9;
            this.comboBoxAl_placa.SelectedIndexChanged += new System.EventHandler(this.comboBoxAl_placa_SelectedIndexChanged);
            // 
            // comboBoxAl_nit
            // 
            this.comboBoxAl_nit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAl_nit.FormattingEnabled = true;
            this.comboBoxAl_nit.Location = new System.Drawing.Point(158, 48);
            this.comboBoxAl_nit.Name = "comboBoxAl_nit";
            this.comboBoxAl_nit.Size = new System.Drawing.Size(196, 24);
            this.comboBoxAl_nit.TabIndex = 8;
            this.comboBoxAl_nit.SelectedIndexChanged += new System.EventHandler(this.comboBoxAl_nit_SelectedIndexChanged);
            // 
            // labelAlquileres
            // 
            this.labelAlquileres.AutoSize = true;
            this.labelAlquileres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlquileres.Location = new System.Drawing.Point(94, 10);
            this.labelAlquileres.Name = "labelAlquileres";
            this.labelAlquileres.Size = new System.Drawing.Size(167, 24);
            this.labelAlquileres.TabIndex = 10;
            this.labelAlquileres.Text = "Ingresar Alquileres";
            // 
            // buttonLimpiarAlquiler
            // 
            this.buttonLimpiarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarAlquiler.Location = new System.Drawing.Point(219, 265);
            this.buttonLimpiarAlquiler.Name = "buttonLimpiarAlquiler";
            this.buttonLimpiarAlquiler.Size = new System.Drawing.Size(104, 32);
            this.buttonLimpiarAlquiler.TabIndex = 14;
            this.buttonLimpiarAlquiler.Text = "Limpiar";
            this.buttonLimpiarAlquiler.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrarAlquiler
            // 
            this.buttonRegistrarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarAlquiler.Location = new System.Drawing.Point(64, 265);
            this.buttonRegistrarAlquiler.Name = "buttonRegistrarAlquiler";
            this.buttonRegistrarAlquiler.Size = new System.Drawing.Size(129, 32);
            this.buttonRegistrarAlquiler.TabIndex = 13;
            this.buttonRegistrarAlquiler.Text = "Registrar Alquiler";
            this.buttonRegistrarAlquiler.UseVisualStyleBackColor = true;
            this.buttonRegistrarAlquiler.Click += new System.EventHandler(this.buttonRegistrarAlquiler_Click);
            // 
            // labelAl_nit
            // 
            this.labelAl_nit.AutoSize = true;
            this.labelAl_nit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAl_nit.Location = new System.Drawing.Point(21, 56);
            this.labelAl_nit.Name = "labelAl_nit";
            this.labelAl_nit.Size = new System.Drawing.Size(24, 16);
            this.labelAl_nit.TabIndex = 1;
            this.labelAl_nit.Text = "Nit";
            // 
            // labelAl_placa
            // 
            this.labelAl_placa.AutoSize = true;
            this.labelAl_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAl_placa.Location = new System.Drawing.Point(21, 106);
            this.labelAl_placa.Name = "labelAl_placa";
            this.labelAl_placa.Size = new System.Drawing.Size(43, 16);
            this.labelAl_placa.TabIndex = 2;
            this.labelAl_placa.Text = "Placa";
            // 
            // textBoxAl_kmRecorridos
            // 
            this.textBoxAl_kmRecorridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAl_kmRecorridos.Location = new System.Drawing.Point(158, 220);
            this.textBoxAl_kmRecorridos.Name = "textBoxAl_kmRecorridos";
            this.textBoxAl_kmRecorridos.Size = new System.Drawing.Size(196, 22);
            this.textBoxAl_kmRecorridos.TabIndex = 12;
            // 
            // labelAl_fechaAlquiler
            // 
            this.labelAl_fechaAlquiler.AutoSize = true;
            this.labelAl_fechaAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAl_fechaAlquiler.Location = new System.Drawing.Point(21, 156);
            this.labelAl_fechaAlquiler.Name = "labelAl_fechaAlquiler";
            this.labelAl_fechaAlquiler.Size = new System.Drawing.Size(113, 16);
            this.labelAl_fechaAlquiler.TabIndex = 3;
            this.labelAl_fechaAlquiler.Text = "Fecha de Alquiler";
            // 
            // labelAl_fechaDev
            // 
            this.labelAl_fechaDev.AutoSize = true;
            this.labelAl_fechaDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAl_fechaDev.Location = new System.Drawing.Point(21, 191);
            this.labelAl_fechaDev.Name = "labelAl_fechaDev";
            this.labelAl_fechaDev.Size = new System.Drawing.Size(136, 16);
            this.labelAl_fechaDev.TabIndex = 4;
            this.labelAl_fechaDev.Text = "Fecha de Devolucion";
            // 
            // labelAl_kmRecorridos
            // 
            this.labelAl_kmRecorridos.AutoSize = true;
            this.labelAl_kmRecorridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAl_kmRecorridos.Location = new System.Drawing.Point(21, 227);
            this.labelAl_kmRecorridos.Name = "labelAl_kmRecorridos";
            this.labelAl_kmRecorridos.Size = new System.Drawing.Size(135, 16);
            this.labelAl_kmRecorridos.TabIndex = 5;
            this.labelAl_kmRecorridos.Text = "Kilomertos recorridos";
            // 
            // dataGridViewReportes
            // 
            this.dataGridViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportes.Location = new System.Drawing.Point(412, 463);
            this.dataGridViewReportes.Name = "dataGridViewReportes";
            this.dataGridViewReportes.Size = new System.Drawing.Size(552, 151);
            this.dataGridViewReportes.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(979, 636);
            this.Controls.Add(this.dataGridViewReportes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewAlquileres);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.dataGridViewVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelPrecioXkilometro;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxPrecioXkilometro;
        private System.Windows.Forms.Label labelDatosVehiculo;
        private System.Windows.Forms.Button buttonGuardarVehiculo;
        private System.Windows.Forms.Button buttonLimpiarVehiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewVehiculos;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridView dataGridViewAlquileres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAlquileres;
        private System.Windows.Forms.Button buttonLimpiarAlquiler;
        private System.Windows.Forms.Button buttonRegistrarAlquiler;
        private System.Windows.Forms.Label labelAl_nit;
        private System.Windows.Forms.Label labelAl_placa;
        private System.Windows.Forms.TextBox textBoxAl_kmRecorridos;
        private System.Windows.Forms.Label labelAl_fechaAlquiler;
        private System.Windows.Forms.Label labelAl_fechaDev;
        private System.Windows.Forms.Label labelAl_kmRecorridos;
        private System.Windows.Forms.ComboBox comboBoxAl_nit;
        private System.Windows.Forms.ComboBox comboBoxAl_placa;
        private System.Windows.Forms.Label labelAl_clienteNombre;
        private System.Windows.Forms.Label labelAl_datosVehiculo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaca;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDev;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaAl;
        private System.Windows.Forms.DataGridView dataGridViewReportes;
    }
}

