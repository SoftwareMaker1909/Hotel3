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
    public partial class CrudClientes : Form
    {
        private const string connectionString = "Data Source=ThekillerCode;Initial Catalog=Hotel_Mariotti;Integrated Security=True";

        public CrudClientes()
        {
            InitializeComponent();
            // Establecer la propiedad Value del DateTimePicker como null al iniciar el formulario
               
        }

        private void CrudClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotel_MariottiDataSet2.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.hotel_MariottiDataSet2.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'hotel_MariottiDataSet1.Habitacion' Puede moverla o quitarla según sea necesario.
            this.habitacionTableAdapter.Fill(this.hotel_MariottiDataSet1.Habitacion);
            CargarDatos();
        }

        private void NoHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Agregar()
        {
            string nombre = NombreTXT.Text.Trim();
            string apellido = ApellidoTXT.Text.Trim();
            string direccion = DireccionTXT.Text.Trim();
            string telefono = TelefonoTXT.Text.Trim();
            string sexo = SexoCBX.SelectedItem?.ToString();

            // Verificar que todos los campos estén llenos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(sexo))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Cliente (Nombre, Apellido, Direccion, Telefono, Sexo) " +
                                   "VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Sexo)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Sexo", sexo);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro agregado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el registro.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
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


       



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarDatos();
            
        }



        private void eliminar()
        {
            if (DataGridViewCliente.SelectedRows.Count > 0)
            {
                // Obtener el valor del Nocliente del registro seleccionado
                int noCliente = Convert.ToInt32(DataGridViewCliente.SelectedRows[0].Cells["Nocliente"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Cliente WHERE Nocliente = @NoCliente";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar el parámetro de consulta con el valor del Nocliente
                            command.Parameters.AddWithValue("@NoCliente", noCliente);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registro eliminado exitosamente.");
                                // Volver a cargar los datos en el DataGridView
                                CargarDatos();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el registro.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
            }
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            eliminar(); 
        }

        private void Buscar()
        {
            string nombreApellido = ClienteTXT.Text.Trim();
            if (!string.IsNullOrEmpty(nombreApellido))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("BuscarClientePorNombreOApellido", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@NombreApellido", nombreApellido);

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
                    MessageBox.Show("Error al buscar registros: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre o apellido para buscar.");
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Reserva formulario2 = new Reserva();

            // Mostrar el formulario
            formulario2.Show();
            this.Hide();
        }

        private void ActualizarCliente()
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (DataGridViewCliente.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DataGridViewCliente.SelectedRows[0];

                // Obtener el valor del Nocliente desde la fila seleccionada
                if (int.TryParse(filaSeleccionada.Cells["Nocliente"].Value.ToString(), out int nocliente))
                {
                    // Obtener los nuevos valores para actualizar los datos personales del cliente
                    string nuevoNombre = NombreTXT.Text.Trim();
                    string nuevoApellido = ApellidoTXT.Text.Trim();
                    string nuevaDireccion = DireccionTXT.Text.Trim();
                    string nuevoTelefono = TelefonoTXT.Text.Trim();
                    string nuevoSexo = SexoCBX.SelectedItem.ToString();

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = "UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Telefono = @Telefono, Sexo = @Sexo " +
                                           "WHERE Nocliente = @Nocliente";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Nocliente", nocliente);
                                command.Parameters.AddWithValue("@Nombre", nuevoNombre);
                                command.Parameters.AddWithValue("@Apellido", nuevoApellido);
                                command.Parameters.AddWithValue("@Direccion", nuevaDireccion);
                                command.Parameters.AddWithValue("@Telefono", nuevoTelefono);
                                command.Parameters.AddWithValue("@Sexo", nuevoSexo);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Información del cliente actualizada correctamente.");
                                    // Actualizar el DataGridView con los nuevos datos
                                    CargarDatos();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo actualizar la información del cliente.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la información del cliente: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el Nocliente del cliente seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para actualizar.");
            }
        }

        private void ActualizarBTN_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrudHabitaciones formulario2 = new CrudHabitaciones();

            // Mostrar el formulario
            formulario2.Show();
            this.Close();

        }
    }




}
