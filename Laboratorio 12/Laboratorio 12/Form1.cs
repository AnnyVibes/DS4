namespace Laboratorio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = Convert.ToDouble(textBox1.Text);
                double tiempo = Convert.ToDouble(textBox2.Text);

                double distancia = velocidad * tiempo;

                textBox3.Text = distancia.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numericos validos en los campos de velocidad y tiempo", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if(control is TextBox)
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


    }
}
