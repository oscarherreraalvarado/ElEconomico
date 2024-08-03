namespace ElEconomico.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Registro");
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // L�gica para el inicio de sesi�n
            // if (usuarioValido)
            // {
            //     await Shell.Current.GoToAsync("//MainPage");
            // }
        }

        private async void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CorreoRecuperacion");
        }
    }
}
