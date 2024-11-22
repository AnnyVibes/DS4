namespace Laboratorio_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(textBox1.Text);
                double valor2 = Convert.ToDouble(textBox2.Text);
                double valor3 = Convert.ToDouble(textBox3.Text);

                double sumaPromedio = valor1 + valor2 + valor3;
                double promedio = sumaPromedio / 3;

                textBox4.Text = promedio.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numericos validos en las notas", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
            MessageBox.Show("Todos los campos han sido borrados.", "Limpieza completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
