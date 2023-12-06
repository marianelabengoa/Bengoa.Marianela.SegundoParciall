using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using System.Text;


namespace WinFormLogin
{
    public partial class FrmLogin : Form
    {
        private Usuario usuario;
        public static int i;

        public Usuario UsuarioDelForm
        {
            get { return this.usuario; }
        }
        /*public int PerfilUsuario
         * 
        {
            get
            {
                if (usuario != null)
                {
                    if (usuario.Perfil == "administrador")
                    {
                        return 3;
                    }
                    else if (usuario.Perfil == "supervisor")
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    // Handle the case where 'usuario' is null (e.g., log an error or return a default value).
                    MessageBox.Show("El objeto 'usuario' es nulo.");
                    return -1; // Default value or appropriate error code.
                }
            }
        }*/
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
                MostrarDatos();
                //PerfilUsuario();
                this.DialogResult = DialogResult.OK;
            }
        }

        /*private Usuario Verificar()
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
                        MessageBox.Show("Usuario o contraseña incorrectos");
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
        }*/
        private Usuario Verificar()
        {
            Usuario rta = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar archivo JSON de usuarios";
                openFileDialog.Filter = "Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string json_str = File.ReadAllText(openFileDialog.FileName);

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
                            MessageBox.Show("Usuario o contraseña incorrectos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay usuarios en la base de datos.");
                    }
                }
            }
            return rta;
        }

        private void RegistrarAcceso()
        {
            string usuario = this.txtUser.Text;
            string logFilePath = @"..\..\..\Usuarios.log";
            //string logFilePath = Path.Combine(Application.StartupPath, "usuarios.log");

            string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string registro = $"{fechaHora} - Usuario: {usuario} accedió a la aplicación";

            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine(registro);
            }
        }
        private void btnVisualizarLog_Click(object sender, EventArgs e)
        {
            
        }
        private void MostrarDatos()
        {
            if (usuario.Perfil == "administrador")
            {
                i= 3;
            }
            else if (usuario.Perfil == "supervisor")
            {
                i = 2;
            }
            else
            {
                i = 1;
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {usuario.Nombre}");
            sb.AppendLine($"Apellido: {usuario.Apellido}");
            sb.AppendLine($"Legajo: {usuario.Legajo}");
            sb.AppendLine($"Correo: {usuario.Correo}");
            sb.AppendLine($"Perfil: {usuario.Perfil}");
            

            MessageBox.Show(sb.ToString());
        }

        /*public int PerfilUsuario()
        {
            if (usuario != null)
            {
                if (usuario.Perfil == "administrador")
                {
                    return 3;
                }
                else if (usuario.Perfil == "supervisor")
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                // Handle the case where 'usuario' is null (e.g., log an error or return a default value).
                MessageBox.Show("El objeto 'usuario' es nulo.");
                return -1; // Default value or appropriate error code.
            }
        }*/

    }
}