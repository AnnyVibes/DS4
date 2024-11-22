using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        private readonly string connectionString =
            @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void conexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    MessageBox.Show("Conexión establecida correctamente con la base de datos.");

                    string query = "SELECT ProductName FROM [dbo].[Products]";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            listBox1.Items.Clear();

                            while (reader.Read())
                            {
                                listBox1.Items.Add(reader["ProductName"].ToString());
                            }
                        }
                    }

                    MessageBox.Show("Los productos se han listado correctamente en el ListBox.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
