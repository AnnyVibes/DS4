namespace Laboratorio_12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double longitud1 = Convert.ToDouble(textBox1.Text);
                double longitud2 = Convert.ToDouble(textBox2.Text);
                double base1 = Convert.ToDouble(textBox3.Text);

                double suma = longitud1 + longitud2 + base1;
                double semiPerimetro = suma / 2;

                textBox4.Text = semiPerimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numericos validos en los campos de longitud", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = Convert.ToDouble(textBox1.Text);
                double LadoB = Convert.ToDouble(textBox2.Text);
                double base1 = Convert.ToDouble(textBox3.Text);

                if (ladoA + LadoB > base1 && ladoA + base1 > LadoB && LadoB + base1 > ladoA)
                {
                    double s = (ladoA + LadoB + base1) / 2;
                    double area = Math.Sqrt(s * (s - ladoA) * (s - LadoB) * (s - base1));
                    textBox5.Text = area.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Las longitudes ingresadas no forman un triángulo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para los lados del triángulo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
