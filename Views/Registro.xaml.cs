namespace ElEconomico.Views;

public partial class Registro : ContentPage
{
    public Registro()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Verificacion());
        // Lógica de registro
        // if (registroExitoso)
        // {
        //     await Shell.Current.GoToAsync("Login");
        // }
    }
}