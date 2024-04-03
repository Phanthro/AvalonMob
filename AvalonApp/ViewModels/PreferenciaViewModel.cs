using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonApp.ViewModels
{
    public class PreferenciaViewModel : BindableObject
    {
        const string preferenceKey = "ExibirPopup";

        public bool Popup
        {
            get => Preferences.Get( preferenceKey, false );
            set
            {
                Preferences.Set( preferenceKey, value );

                OnPropertyChanged();
            }
        }
    }
}
