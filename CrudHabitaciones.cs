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
    public partial class CrudHabitaciones : Form
    {

        private const string connectionString = "Data Source=ThekillerCode;Initial Catalog=Hotel_Mariotti;Integrated Security=True";
        private DataTable habitacionDataTable;

        public CrudHabitaciones()
        {
            InitializeComponent();
            habitacionDataTable = new DataTable();
            habitacionesDataGridView.DataSource = habitacionDataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotel_MariottiDataSet.Habitacion' Puede moverla o quitarla según sea necesario.
            this.habitacionTableAdapter.Fill(this.hotel_MariottiDataSet.Habitacion);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int tipoHabitacion = (int)TipoUpDown1.Value;
                decimal precio = decimal.Parse(PrecioTXT.Text);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO Habitacion (Tipohabitacion, Precio) VALUES (@TipoHabitacion, @Precio)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TipoHabitacion", tipoHabitacion);
                            command.Parameters.AddWithValue("@Precio", precio);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Registro agregado exitosamente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numeroHabitacion = int.Parse(NumeroHabitacionTXT.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Habitacion WHERE NoHabitacion = @NumeroHabitacion";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NumeroHabitacion", numeroHabitacion);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            habitacionDataTable.Clear();
                            adapter.Fill(habitacionDataTable);

                            if (habitacionDataTable.Rows.Count > 0)
                            {
                                // Si se encuentra el registro, se actualiza el DataGridView
                                habitacionesDataGridView.Refresh();
                            }
                            else
                            {
                                // Si no se encuentra el registro, se muestra un mensaje
                                MessageBox.Show("No se encontraron habitaciones con el número especificado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar las habitaciones: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numeroHabitacion = int.Parse(NumeroHabitacionTXT.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Habitacion WHERE NoHabitacion = @NumeroHabitacion";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NumeroHabitacion", numeroHabitacion);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Habitación eliminada exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró una habitación con el número especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la habitación: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numeroHabitacion = int.Parse(NumeroHabitacionTXT.Text);
            int tipoHabitacion = (int)TipoUpDown1.Value;
            decimal precio = decimal.Parse(PrecioTXT.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Habitacion SET Tipohabitacion = @TipoHabitacion, Precio = @Precio WHERE NoHabitacion = @NumeroHabitacion";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TipoHabitacion", tipoHabitacion);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@NumeroHabitacion", numeroHabitacion);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro actualizado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró una habitación con el número especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            CrudClientes formulario = new CrudClientes();

            // Mostrar el formulario
            formulario.Show();
        }


    }
}