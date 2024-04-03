using AvalonApp.ViewModels;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Views;

namespace AvalonApp.Views.Components;

public partial class BasicPopup : Popup
{
	public BasicPopup()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();
        MainPageViewModel viewModel = (MainPageViewModel)BindingContext;
        viewModel.CarregarDados();

    }

    void OnOKButtonClicked( object? sender, EventArgs e )
    {
        Close();   

    }
    void OnCheckBoxCheckedChanged( object sender, CheckedChangedEventArgs e )
    {
        MainPageViewModel viewModel = (MainPageViewModel)BindingContext;
        viewModel.Popup = e.Value;
    }
}