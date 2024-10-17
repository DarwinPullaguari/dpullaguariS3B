namespace dpullaguariS3B.Views;

public partial class Login : ContentPage
{
    string user = "x", pass = "x";
    public Login()
	{
		InitializeComponent();
	}
    public Login(string usuario, string contrasena)
    {
        
        InitializeComponent();
        user= usuario;
        pass = contrasena;
    }
    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && pass == txtContraseña.Text)
        {
            Navigation.PushAsync(new Views.Home());
        }
        else
        {
            DisplayAlert("ERROR", "Usuario /COntraseña Incorectos", "Cerrar");
        }
    }
    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registro());
    }
}