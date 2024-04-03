using AvalonApp.Dto;
using System.Collections.ObjectModel;
using System.Timers;


namespace AvalonApp.Views.Components;

public partial class CarrosselView : ContentView
{
    private int currentIndex = 0;
    private System.Timers.Timer timer;

    public static readonly BindableProperty ItensProperty =
       BindableProperty.Create(
           nameof( Itens ),
           typeof( List<CarrosselItem> ),
           typeof( CarrosselView ),
           defaultBindingMode: BindingMode.TwoWay,
           validateValue: null,
           propertyChanged: MudarItens
           );

    public static readonly BindableProperty TituloProperty =
       BindableProperty.Create(
           nameof( Titulo ),
           typeof( string ),
           typeof( CarrosselView ),
           defaultValue:"",
           defaultBindingMode: BindingMode.TwoWay,
           validateValue:null,
           propertyChanged: MudarTitulo
           

           );

    private static void MudarItens( BindableObject bindable, object oldValue, object newValue )
    {
        var control = (CarrosselView)bindable;
        control.Itens = (List<CarrosselItem>)newValue;
    }


    private static void MudarTitulo( BindableObject bindable, object oldValue, object newValue )
    {
        var control = ( CarrosselView )bindable;
        control.Titulo = (string)newValue;
    }

    public List<CarrosselItem> Itens
    {
        get => (List<CarrosselItem>)GetValue( ItensProperty );
        set => SetValue( ItensProperty, value );
    }

    public string Titulo
    {
        get => (string)GetValue( TituloProperty );
        set => SetValue(TituloProperty, value); 
    }

    public CarrosselView()
	{
		InitializeComponent();
        timer = new System.Timers.Timer( 5000 );
        timer.Elapsed += TimerElapsed;
        timer.Start();
    }


    private void TimerElapsed( object sender, ElapsedEventArgs e )
    {
        //// Muda automaticamente para o próximo item no CarouselView
        //Device.BeginInvokeOnMainThread( () =>
        //{
            
        //} );
        Dispatcher.Dispatch( () =>
        {
            currentIndex = (currentIndex + 1) % Itens.Count;
            carouselView.Position = currentIndex;
        } );
    }
}