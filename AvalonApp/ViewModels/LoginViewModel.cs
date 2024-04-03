using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AvalonApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _usuario;
        private string _password;

        public string Usuario
            { get => _usuario; set {if (_usuario != value){_usuario = value;OnPropertyChanged( nameof( Usuario ) );}}}

        public string Password 
            { get => _password; set { if (_password != value) { _password = value; OnPropertyChanged( nameof( Password ) );}}}

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged( string propertyName )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }


        public ICommand Logar => new Command( ExecutarLogar );

        private void ExecutarLogar()
        {
            Console.WriteLine( $"Usuario digitado: {Usuario}" );
        }
    }
}
