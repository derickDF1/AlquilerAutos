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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void buttonVerDGV_Click(object sender, EventArgs e)
        {
            MostrarVehiculos();
            MostrarClientes();
        }
    

        private void cargarVehiculos()
        {
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

        private void Guardar(string fileName, string texto)
        {
            
        }

        private void limpiarTextbox()
        {
            textBoxPlaca.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            textBoxColor.Text = "";
            textBoxPrecioXkilometro.Text = "";
        }

        private void buttonGuardarVehiculo_Click(object sender, EventArgs e)
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Vehiculos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(textBoxPlaca.Text);
            writer.WriteLine(textBoxMarca.Text);
            writer.WriteLine(textBoxModelo.Text);
            writer.WriteLine(textBoxColor.Text);
            writer.WriteLine(textBoxPrecioXkilometro.Text);

            limpiarTextbox();
            writer.Close();
            MessageBox.Show("Vehiculo Guardado");
        }

        private void buttonLimpiarVehiculo_Click(object sender, EventArgs e)
        {
            limpiarTextbox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarVehiculos();
            cargarClientes();

            comboBoxAl_nit.DisplayMember = "nit";
            comboBoxAl_nit.DataSource = clientes;
     

            comboBoxAl_placa.DisplayMember = "placa";
            comboBoxAl_placa.DataSource = vehiculos;
        }

        private void labelAl_placa_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAl_placa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
