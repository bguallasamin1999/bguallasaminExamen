namespace bguallasaminExamen.Vista;

public partial class vista1 : ContentPage
{
    public List<Usuario> usuarios = new List<Usuario>();
    public vista1()
	{
		InitializeComponent();
        usuarios.Add(new Usuario("estudiante2025", "moviles"));
        usuarios.Add(new Usuario("uisrael", "2025"));
        usuarios.Add(new Usuario("sistemas", "2025_1"));
    }
    public class Usuario
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }

        public Usuario(string usuario, string contrasena)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
        }

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (txtUsuario.Text == "estudiante2025" && txtContrasena.Text == "moviles")
        {
            Navigation.PushAsync(new Vista.vista2("estudiante2025"));
        }
        else if (txtUsuario.Text == "uisrael" && txtContrasena.Text == "2025")
        {
            Navigation.PushAsync(new Vista.vista2("uisrael"));
        }
        else if (txtUsuario.Text == "sistemas" && txtContrasena.Text == "2025_1")
        {
            Navigation.PushAsync(new Vista.vista2("sistemas"));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "OK");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        string programador = "Byron Andres Guallasamin Morales";
        DisplayAlert("Acerca de..", "Desarrollado por: "+programador, "OK");
    }
}