using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Alquiler_autos
{
    public partial class Form1 : Form
    {
        List<Vehiculos> vehiculos2 = new List<Vehiculos>();
        List<Clientes> clientes2 = new List<Clientes>();
        List<Alquiler> alquileres2 = new List<Alquiler>();
        List<Reporte> reportes2 = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LeerCliente()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Repaso2\Clientes.txt";
            if (File.Exists(fileName))
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileStream);
                while (reader.Peek() > -1)
                {
                    Clientes cliente = new Clientes();
                    cliente.Nit = reader.ReadLine();
                    cliente.Nombre = reader.ReadLine();
                    cliente.Direccion = reader.ReadLine();

                    clientes2.Add(cliente);
                }
                reader.Close();
            }

        }
        private void LeerVehiculo()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Repaso2\vehiculos.txt";
            if (File.Exists(fileName))
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileStream);
                while (reader.Peek() > -1)
                {
                    Vehiculos vehiculo = new Vehiculos();
                    vehiculo.Placa = reader.ReadLine();
                    vehiculo.Marca = reader.ReadLine();
                    vehiculo.Modelo = Convert.ToInt32(reader.ReadLine());
                    vehiculo.Precio_kilometro = Convert.ToDecimal(reader.ReadLine());
                    vehiculos2.Add(vehiculo);
                }
                reader.Close();
            }
        }
        private void GuardarVehiculo()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Repaso2\vehiculos.txt";

            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            foreach (Vehiculos vehiculo in vehiculos2)
            {
                writer.WriteLine(vehiculo.Placa);
                writer.WriteLine(vehiculo.Marca);
                writer.WriteLine(vehiculo.Modelo);
                writer.WriteLine(vehiculo.Precio_kilometro);
            }
            writer.Close();

        }

        private void LeerAlquiler()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Repaso2\alquileres.txt";
            if (File.Exists(fileName))
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileStream);
                while (reader.Peek() > -1)
                {
                    Alquiler alquiler = new Alquiler();
                    alquiler.Nit = reader.ReadLine();
                    alquiler.Placa_auto = reader.ReadLine();
                    alquiler.Fecha_alquiler = Convert.ToDateTime(reader.ReadLine());
                    alquiler.Fecha_devolucion = Convert.ToDateTime(reader.ReadLine());
                    alquiler.Kilometros_recorridos = Convert.ToDecimal(reader.ReadLine());
                    alquileres2.Add(alquiler);
                }
                reader.Close();
            }
        }

        private void GuardadAlquiler()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Repaso2\alquileres.txt";
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            foreach (Alquiler alquiler in alquileres2)
            {
                writer.WriteLine(alquiler.Nit);
                writer.WriteLine(alquiler.Placa_auto);
                writer.WriteLine(alquiler.Fecha_alquiler);
                writer.WriteLine(alquiler.Fecha_devolucion);
                writer.WriteLine(alquiler.Kilometros_recorridos);
            }
            writer.Close();

        }

        private void buttonVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculos vehiculo = new Vehiculos();
            vehiculo.Placa = comboBoxPlaca1.Text;
            vehiculo.Marca = textBoxMarca.Text;
            vehiculo.Modelo = Convert.ToInt32(numericUpDownModelo.Value);
            vehiculo.Precio_kilometro = Convert.ToDecimal(numericUpDownPrecio_porKm.Value);
            vehiculos2.Add(vehiculo);
            GuardarVehiculo();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            LeerCliente();
            LeerVehiculo();
            LeerAlquiler();
            mostrarReporte();
            comboBoxCliente.DisplayMember = "Nit";
            comboBoxCliente.DataSource = clientes2;

            comboBoxPlaca2.DisplayMember = "Placa";
            comboBoxPlaca2.DataSource = vehiculos2;

        }

        private void buttonMostrar1_Click(object sender, EventArgs e)
        {

            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientes2;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonMostrar2_Click(object sender, EventArgs e)
        {
            dataGridViewVehiculo.DataSource = null;
            dataGridViewVehiculo.DataSource = vehiculos2;
            dataGridViewVehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void buttonG1_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.Nit = comboBoxCliente.Text;
            alquiler.Placa_auto = comboBoxPlaca2.Text;
            alquiler.Fecha_alquiler = dateTimePickerAlquiler.Value;
            alquiler.Fecha_devolucion = dateTimePickerdev.Value;
            alquiler.Kilometros_recorridos = Convert.ToDecimal(numericUpDownk_re.Value);
            alquileres2.Add(alquiler);
            GuardadAlquiler();

        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            reportes2.Clear();

            foreach (Alquiler alquiler in alquileres2)
            {

                foreach (Clientes cliente in clientes2)
                {

                    foreach (Vehiculos vehiculo in vehiculos2)
                    {
                        if (alquiler.Nit == cliente.Nit &&
                            alquiler.Placa_auto == vehiculo.Placa)
                        {
                            Reporte reporte = new Reporte();
                            reporte.Nombre = cliente.Nombre;
                            reporte.Plac = vehiculo.Placa;
                            reporte.Marc = vehiculo.Marca;
                            reporte.Mod = vehiculo.Modelo;
                            reporte.Precio_km = vehiculo.Precio_kilometro;
                            reporte.Fecha_devolucion = alquiler.Fecha_devolucion;
                            reporte.Kilometros = alquiler.Kilometros_recorridos;

                            reporte.Total = alquiler.Kilometros_recorridos * vehiculo.Precio_kilometro;

                            reportes2.Add(reporte);
                        }
                    }
                }
            }mostrarReporte();
            decimal maxKm = alquileres2.Max(a => a.Kilometros_recorridos);

            
            labelMaxKm.Text = "Mayor recorrido: " + maxKm.ToString() + " km";

        }
        private void mostrarReporte()
        {
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes2;
            dataGridViewReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}





                
