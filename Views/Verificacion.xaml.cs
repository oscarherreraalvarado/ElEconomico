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

        // Acción para el botón "Reenviar código"
        private void OnResendCodeClicked(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para reenviar el código de verificación
            DisplayAlert("Código reenviado", "El código de verificación ha sido reenviado a tu correo.", "OK");
        }

        // Acción para el botón "Registrarse"
        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para verificar el código y registrar al usuario
            bool isCodeValid = ValidateCode();

            if (isCodeValid)
            {
                // Navegar a la pantalla de inicio de sesión si el código es válido
                await Navigation.PushAsync(new Login());
                //await Shell.Current.GoToAsync("//Login");
            }
            else
            {
                // Mostrar un mensaje de error si el código no es válido
                await DisplayAlert("Error", "El código de verificación es incorrecto. Por favor, inténtalo de nuevo.", "OK");
            }
        }

        // Método para validar el código de verificación (puedes personalizar esta lógica)
        private bool ValidateCode()
        {
            // Supongamos que el código correcto es "1234"
            string correctCode = "1234";

            // Obtener el texto del campo de entrada
            string enteredCode = codeEntry.Text;

            // Comparar el código ingresado con el código correcto
            return enteredCode == correctCode;
        }
    }
}
