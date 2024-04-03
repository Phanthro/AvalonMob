using AvalonApp.ViewModels;

namespace AvalonApp.Views;

public partial class Preferencias : ContentPage
{
	public Preferencias()
	{
		InitializeComponent();
        BindingContext = new PreferenciaViewModel();
    }
}