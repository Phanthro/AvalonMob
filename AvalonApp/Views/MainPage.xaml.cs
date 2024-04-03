using AvalonApp.ViewModels;
using AvalonApp.Views.Components;
using CommunityToolkit.Maui.Views;

namespace AvalonApp.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        MainPageViewModel viewModel = (MainPageViewModel)BindingContext;
        
        if (!viewModel.Popup)
        {
            this.ShowPopup( new BasicPopup() );
        }
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}