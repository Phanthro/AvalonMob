using AvalonApp.Views;

namespace AvalonApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Teste();
        }
    }
}
