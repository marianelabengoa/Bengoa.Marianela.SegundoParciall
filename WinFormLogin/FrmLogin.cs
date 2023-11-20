using System.Text.Json;
using System.IO;
using System.Windows.Forms;


namespace WinFormLogin
{
    public partial class FrmLogin : Form
    {
        private Usuario usuario;

        public Usuario UsuarioDelForm
        {
            get { return this.usuario; }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }
        public FrmLogin(Usuario usuario) : this()
        {
            this.usuario = usuario;
            this.txtUser.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.usuario = this.Verificar();

            if (this.usuario != null)
            {
                RegistrarAcceso();
                this.DialogResult = DialogResult.OK;
            }
        }

        private Usuario Verificar()
        {
            Usuario rta = null;

            if (File.Exists(@"..\..\..\Usuarios.json"))
            {
                string json_str = File.ReadAllText(@"..\..\..\Usuarios.json");


                List<Usuario> users = JsonSerializer.Deserialize<List<Usuario>>(json_str);


                if (users != null && users.Count > 0)
                {
                    foreach (Usuario item in users)
                    {
                        if (item.Correo == this.txtUser.Text && item.Clave == this.txtClave.Text)
                        {
                            rta = item;
                            break;
                        }
                    }

                    if (rta == null)
                    {
                        MessageBox.Show("Usuario o contrase�a incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("No hay usuarios en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("El archivo de usuarios no existe.");
            }

            return rta;
        }

        private void RegistrarAcceso()
        {
            string usuario = this.txtUser.Text;
            string logFilePath = @"..\..\..\Usuarios.log";
            //string logFilePath = Path.Combine(Application.StartupPath, "usuarios.log");

            string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string registro = $"{fechaHora} - Usuario: {usuario} accedi� a la aplicaci�n";

            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine(registro);
            }
        }
        private void btnVisualizarLog_Click(object sender, EventArgs e)
        {
            
        }
    }
}