namespace login_mx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Verificar las credenciales
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Inicio de sesión exitoso");
                // Aquí puedes abrir el formulario principal de tu aplicación o realizar otras acciones
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Inténtalo de nuevo.");
            }
        }

    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

   
