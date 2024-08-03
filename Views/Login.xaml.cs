using System.Security.Cryptography.X509Certificates;

namespace ElEconomico.Views
{
    public partial class Login : ContentPage
    {
        public string webapiKey = "AIzaSyDGrJoB6Gw3NKtHiLMJLX-XOynXaK_mwsk";
        public Login()
        {
            InitializeComponent();
        }

        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
            //await Shell.Current.GoToAsync("//Registro");
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Es aaqui donde se debe de hacer la autenticacion de usuario 


            await Navigation.PushAsync(new Menu());
            // Lógica para el inicio de sesión
            // if (usuarioValido)
            // {
            //     await Shell.Current.GoToAsync("//MainPage");
            // }
        }

        private async void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CorreoRecuperacion());
            //await Shell.Current.GoToAsync("//CorreoRecuperacion");
        }
    }
}
