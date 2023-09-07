namespace Tienda
{
    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 prueba = new Form2();
            prueba.Show();

            this.Hide();
        }
    }
}