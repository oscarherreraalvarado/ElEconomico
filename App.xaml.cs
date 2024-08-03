using ElEconomico.Views;

namespace ElEconomico
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }
    }
}
