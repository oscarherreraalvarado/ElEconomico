namespace ElEconomico.Views;

public partial class RestorePass : ContentPage
{
	public RestorePass()
	{
		InitializeComponent();
	}

    private void btnRestContraseña_Clicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new Views.Registro());
    }

    private async void OnResetPasswordClicked(object sender, EventArgs e)
    {
        // Lógica para restablecer la contraseña
        await DisplayAlert("Éxito", "Tu contraseña ha sido restablecida", "OK");
    }

    private async void OnBackToLoginTapped(object sender, EventArgs e)
    {
        // Navegar de vuelta a la pantalla de login
        await Shell.Current.GoToAsync("//Registro");
    }
}