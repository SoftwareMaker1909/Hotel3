using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mariotti
{
    public partial class Reserva : Form
    {
        private const string connectionString = "Data Source=ThekillerCode;Initial Catalog=Hotel_Mariotti;Integrated Security=True";

        public Reserva()
        {
            InitializeComponent();
        }

      

        private void CargarHabitacionesDisponibles()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ObtenerHabitacionesDisponibles2", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Asignar el DataTable como origen de datos del ComboBox
                            NoHabitacionCBX.DataSource = dataTable;
                            NoHabitacionCBX.DisplayMember = "NoHabitacion";
                            NoHabitacionCBX.ValueMember = "NoHabitacion";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las habitaciones disponibles: " + ex.Message);
            }



        }

        private void AgregarDatosReserva(int nocliente, int nohabitacion, int noreserva, DateTime fechaLlegada, DateTime fechaSalida)
        {
            // Verificar que los parámetros no sean nulos
            if (nohabitacion == 0 || noreserva == 0 || fechaLlegada == DateTime.MinValue || fechaSalida == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Cliente " +
                                   "SET NoHabitacion = @NoHabitacion, " +
                                   "    Noreservacion = @NoReservacion, " +
                                   "    Fecha_llegada = @FechaLlegada, " +
                                   "    Fecha_Salida = @FechaSalida " +
                                   "WHERE Nocliente = @Nocliente";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NoHabitacion", nohabitacion);
                        command.Parameters.AddWithValue("@NoReservacion", noreserva);
                        command.Parameters.AddWithValue("@FechaLlegada", fechaLlegada);
                        command.Parameters.AddWithValue("@FechaSalida", fechaSalida);
                        command.Parameters.AddWithValue("@Nocliente", nocliente);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos de reserva agregados y cliente actualizado exitosamente.");
                            // Aquí puedes agregar cualquier lógica adicional que necesites después de la actualización.
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el cliente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los datos de reserva y actualizar el cliente: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            AgregarDatosReserva();
        }

        private void AgregarDatosReserva()
        {
            if (int.TryParse(NumeroClienteCBX.SelectedValue?.ToString(), out int nocliente))
            {
                int nohabitacion = Convert.ToInt32(NoHabitacionCBX.SelectedValue);
                int noreserva = Convert.ToInt32(NoReservaUPDOWN.Value);
                DateTime fechaLlegada = EntradaDTP.Value;
                DateTime fechaSalida = SalidaDTP.Value;

                // Llamar al método para actualizar los datos de reserva
                AgregarDatosReserva(nocliente, nohabitacion, noreserva, fechaLlegada, fechaSalida);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un valor válido para el Nocliente.");
            }
        }

        private void CargarDatos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Cliente";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Asignar el DataTable como origen de datos del DataGridView
                            DataGridViewCliente.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            CargarHabitacionesDisponibles();
            CargarDatos();
            CargarNumeroClienteDisponibles();
        }
        private void CargarNumeroClienteDisponibles()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obtener los clientes que no tienen datos en la columna NoHabitacion
                    string query = "SELECT Nocliente FROM Cliente WHERE NoHabitacion IS NULL";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Asignar el DataTable como origen de datos del ComboBox
                            NumeroClienteCBX.DataSource = dataTable;
                            NumeroClienteCBX.DisplayMember = "Nocliente";
                            NumeroClienteCBX.ValueMember = "Nocliente";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números de cliente disponibles: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarHabitacionesDisponibles();
            CargarDatos(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            CrudClientes formulario = new CrudClientes();

            // Mostrar el formulario
            formulario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrudHabitaciones formulario2 = new CrudHabitaciones();

            // Mostrar el formulario
            formulario2.Show();
            this.Close();

        }
    }



}
