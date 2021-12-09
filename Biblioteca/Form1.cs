namespace Biblioteca
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            
            frm2.txtMostrar.Text = textBox1.Text;
            frm2.txtMostrarApellidos.Text = textBox2.Text;

            frm2.Show();

                
        }

    }
}