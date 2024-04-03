using AvalonApp.Dto;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonApp.ViewModels
{
    public class MainPageViewModel : BindableObject
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

        public MainPageViewModel() 
        {
            Popup = Preferences.Get( preferenceKey, false );
        }

        private string _nome { get; set; }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (_nome != value)
                {
                    _nome = value;
                    OnPropertyChanged( nameof( Nome ) );
                }
            }
        }

        private List<CarrosselItem> _itensCarrossel;
        public List<CarrosselItem> ItensCarrossel
        {
            get { return _itensCarrossel; }
            set
            {
                if (_itensCarrossel != value)
                {
                    _itensCarrossel = value;
                    OnPropertyChanged( nameof( ItensCarrossel ) );
                }
            }
        }

        public void CarregarDados()
        {
            ItensCarrossel = new List<CarrosselItem>
            {
                new CarrosselItem { Nome = "Promoção 1", Imagem = "promo_1" },
                new CarrosselItem { Nome = "Promoção 2", Imagem = "promo_2" },
                new CarrosselItem { Nome = "Promoção 3", Imagem = "promo_3" },
            };

            Nome = "Carrossel";
        }
    }
}
