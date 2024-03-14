using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class Form1 : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();    //Cargar Vehiculos
        List<Cliente> clientes = new List<Cliente>();    //Cargar Clientes
        List<Alquiler> alquileres = new List<Alquiler>();    //Cargar Alquileres
        List<Reporte> reportes = new List<Reporte>(); //Cargar reportes
        public Form1()
        {
            InitializeComponent();

            dateTimePickerFechaAl.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaAl.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFechaDev.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaDev.CustomFormat = "dd/MM/yyyy";

        }

        private void MostrarVehiculos()
        {
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = vehiculos;
            dataGridViewVehiculos.Refresh();
        }

        private void MostrarClientes()
        {
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientes;
            dataGridViewClientes.Refresh();
        }

        private void MostrarAlquileres()
        {
            dataGridViewAlquileres.DataSource = null;
            dataGridViewAlquileres.DataSource = alquileres;
            dataGridViewAlquileres.Refresh();
        }

        private void cargarComboBoxPlacas()
        {
            comboBoxAl_placa.DataSource = null;
            comboBoxAl_placa.DataSource = vehiculos;
            comboBoxAl_placa.DisplayMember = "Placa";
        }

        private void mostrarReportes()
        {
            dataGridViewReportes.DataSource = null;
            dataGridViewReportes.DataSource = reportes;
            dataGridViewReportes.Refresh();
        }

        private void refrescarDatos()
        {
            cargarVehiculos();
            cargarClientes();
            cargarAlquileres();
            MostrarVehiculos();
            MostrarClientes();
            MostrarAlquileres();
            cargarComboBoxPlacas();
            mostrarReportes();
        }

        private void cargarVehiculos()
        {
            vehiculos.Clear();
            //Leer el archivo y cargarlo a la lista
            string fileName = "Vehiculos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //Leer los datos de los vehiculos
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = reader.ReadLine();
                vehiculo.Marca = reader.ReadLine();
                vehiculo.Modelo = reader.ReadLine();
                vehiculo.Color = reader.ReadLine();
                vehiculo.PrecioXkilometro = Convert.ToDecimal(reader.ReadLine());
                vehiculos.Add(vehiculo);    //Guardar el vehiculo a la lista de vehiculos
            }
            reader.Close();
        }

        private void cargarClientes()
        {
            clientes.Clear();
            string fileName = "Clientes.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //Leer los datos de los vehiculos
                Cliente cliente = new Cliente();
                cliente.Nit = reader.ReadLine();
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();
                clientes.Add(cliente);    //Guardar el cliente a la lista de clientes
            }
            reader.Close();
        }

        private void cargarAlquileres()
        {
            alquileres.Clear();
            string fileName = "Alquileres.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //Leer los datos de los vehiculos
                Alquiler alquiler = new Alquiler();
                alquiler.Nit = reader.ReadLine();
                alquiler.Placa = reader.ReadLine();
                alquiler.FechaAlquiler = Convert.ToDateTime(reader.ReadLine());
                alquiler.FechaDevolución = Convert.ToDateTime(reader.ReadLine());
                alquiler.KilómetrosRecorridos = Convert.ToInt16(reader.ReadLine());
                alquileres.Add(alquiler);    //Guardar el alquiler a la lista de alquileres
            }
            reader.Close();
        }

        private void limpiarTextbox()
        {
            maskedTextBoxPlaca.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            textBoxColor.Text = "";
            textBoxPrecioXkilometro.Text = "";

            comboBoxAl_nit.Text = "";
            comboBoxAl_placa.Text = "";
            dateTimePickerFechaAl.Text = "";
            dateTimePickerFechaDev.Text = "";
            textBoxAl_kmRecorridos.Text = "";
            labelAl_clienteNombre.Text = "...";
            labelAl_datosVehiculo.Text = "...";
        }

        private void buttonGuardarVehiculo_Click(object sender, EventArgs e)
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Vehiculos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(maskedTextBoxPlaca.Text);
            writer.WriteLine(textBoxMarca.Text);
            writer.WriteLine(textBoxModelo.Text);
            writer.WriteLine(textBoxColor.Text);
            writer.WriteLine(textBoxPrecioXkilometro.Text);

            limpiarTextbox();
            writer.Close();
            MessageBox.Show("Vehiculo Guardado");

            refrescarDatos();
            labelAl_datosVehiculo.Text = "...";
            comboBoxAl_placa.Text = "";
            maskedTextBoxPlaca.Select();
        }

        private void buttonLimpiarVehiculo_Click(object sender, EventArgs e)
        {
            limpiarTextbox();
            maskedTextBoxPlaca.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refrescarDatos();
            mostrarReportes();

            comboBoxAl_nit.DataSource = clientes;
            comboBoxAl_nit.DisplayMember = "nit";

            comboBoxAl_placa.DataSource = vehiculos;
            comboBoxAl_placa.DisplayMember = "placa";

            comboBoxAl_nit.Text = "";
            comboBoxAl_placa.Text = "";
            labelAl_clienteNombre.Text = "...";
            labelAl_datosVehiculo.Text = "...";
        }

        private void comboBoxAl_placa_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAl_placa.ValueMember = "Placa";
            string placaVehiculo = (Convert.ToString(comboBoxAl_placa.SelectedValue)).Trim();

            Vehiculo vehiculoEncontrado = vehiculos.Find(c => c.Placa == placaVehiculo);
            if (vehiculoEncontrado != null)
            {
                labelAl_datosVehiculo.Text = vehiculoEncontrado.Marca + ", " + vehiculoEncontrado.Modelo + ", " + vehiculoEncontrado.Color;
            }
        }

        private void comboBoxAl_nit_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAl_nit.ValueMember = "nit";
            string nitCliente = Convert.ToString(comboBoxAl_nit.SelectedValue);

            Cliente clienteEncontrado = clientes.Find(c => c.Nit == nitCliente);
            labelAl_clienteNombre.Text = clienteEncontrado.Nombre;
        }

        private void maskedTextBoxPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar); // Convertir la letra a mayúscula
            }
        }

        private void maskedTextBoxPlaca_Click(object sender, EventArgs e)
        {
            maskedTextBoxPlaca.SelectAll();
        }

        private void buttonRegistrarAlquiler_Click(object sender, EventArgs e)
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Alquileres.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(comboBoxAl_nit.Text);
            writer.WriteLine(comboBoxAl_placa.Text);
            writer.WriteLine(dateTimePickerFechaAl.Text);
            writer.WriteLine(dateTimePickerFechaDev.Text);
            writer.WriteLine(textBoxAl_kmRecorridos.Text);

            limpiarTextbox();
            writer.Close();
            MessageBox.Show("Alquiler registrado.");

            refrescarDatos();
            comboBoxAl_nit.Select();
            adjuntarReporte();
            guardarReportes();

            labelAl_datosVehiculo.Text = "...";
            comboBoxAl_placa.Text = "";
        }
        
        private void adjuntarReporte ()
        {
            reportes.Clear();
            foreach (Alquiler alquiler in alquileres)
            {
                Cliente cliente = clientes.Find(c => c.Nit == alquiler.Nit);
                Vehiculo vehiculo = vehiculos.Find(v => v.Placa == alquiler.Placa);

                Reporte reporte = new Reporte();
                reporte.NombreCliente = cliente.Nombre;
                reporte.Placa = vehiculo.Placa;
                reporte.Marca = vehiculo.Marca;
                reporte.Modelo = vehiculo.Modelo;
                reporte.Color = vehiculo.Color;
                reporte.FechaDevolución = alquiler.FechaDevolución;
                reporte.TotalPagar = (vehiculo.PrecioXkilometro) * alquiler.KilómetrosRecorridos;
                reportes.Add(reporte);
            }
            refrescarDatos();
        }

        private void guardarReportes ()
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Reportes.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Reporte reporte in reportes)
            {
                int i = 0;
                writer.WriteLine(reportes[i].NombreCliente);
                writer.WriteLine(reportes[i].Placa);
                writer.WriteLine(reportes[i].Marca);
                writer.WriteLine(reportes[i].Modelo);
                writer.WriteLine(reportes[i].Color);
                writer.WriteLine(reportes[i].FechaDevolución);
                writer.WriteLine(reportes[i].TotalPagar);
                i++;
            }
            
            writer.Close();
        }

        private void buttonActualizarReporte_Click(object sender, EventArgs e)
        {
            
        }
    }
}