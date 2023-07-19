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
            if (int.TryParse(TextBoxNocliente.Text, out int nocliente))
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
                MessageBox.Show("Por favor, ingresa un valor válido para el Nocliente.");
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarHabitacionesDisponibles();
            CargarDatos(); 
        }
    }



}
