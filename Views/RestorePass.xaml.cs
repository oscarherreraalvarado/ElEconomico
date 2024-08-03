namespace ElEconomico.Views;

public partial class RestorePass : ContentPage
{
	public RestorePass()
	{
		InitializeComponent();
	}

    private void btnRestContrase�a_Clicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new Views.Registro());
    }

    private async void OnResetPasswordClicked(object sender, EventArgs e)
    {
        // L�gica para restablecer la contrase�a
        await DisplayAlert("�xito", "Tu contrase�a ha sido restablecida", "OK");
    }

    private async void OnBackToLoginTapped(object sender, EventArgs e)
    {
        // Navegar de vuelta a la pantalla de login
        await Shell.Current.GoToAsync("//Registro");
    }
}