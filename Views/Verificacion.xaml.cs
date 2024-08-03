using Microsoft.Maui.Controls;
using System;

namespace ElEconomico.Views
{
    public partial class Verificacion : ContentPage
    {
        public Verificacion()
        {
            InitializeComponent();
        }

        // Acci�n para el bot�n "Reenviar c�digo"
        private void OnResendCodeClicked(object sender, EventArgs e)
        {
            // Aqu� puedes agregar la l�gica para reenviar el c�digo de verificaci�n
            DisplayAlert("C�digo reenviado", "El c�digo de verificaci�n ha sido reenviado a tu correo.", "OK");
        }

        // Acci�n para el bot�n "Registrarse"
        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Aqu� puedes agregar la l�gica para verificar el c�digo y registrar al usuario
            bool isCodeValid = ValidateCode();

            if (isCodeValid)
            {
                // Navegar a la pantalla de inicio de sesi�n si el c�digo es v�lido
                await Navigation.PushAsync(new Login());
                //await Shell.Current.GoToAsync("//Login");
            }
            else
            {
                // Mostrar un mensaje de error si el c�digo no es v�lido
                await DisplayAlert("Error", "El c�digo de verificaci�n es incorrecto. Por favor, int�ntalo de nuevo.", "OK");
            }
        }

        // M�todo para validar el c�digo de verificaci�n (puedes personalizar esta l�gica)
        private bool ValidateCode()
        {
            // Supongamos que el c�digo correcto es "1234"
            string correctCode = "1234";

            // Obtener el texto del campo de entrada
            string enteredCode = codeEntry.Text;

            // Comparar el c�digo ingresado con el c�digo correcto
            return enteredCode == correctCode;
        }
    }
}
