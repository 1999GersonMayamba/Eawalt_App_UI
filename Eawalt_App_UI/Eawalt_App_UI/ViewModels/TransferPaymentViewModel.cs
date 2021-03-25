using Eawalt_App_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Eawalt_App_UI.ViewModels
{
   public class TransferPaymentViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Values> Values { get; set; }
        public ICommand ItemSelectedCommand => new Command(ItemSelected);
        private User _UserSeleciodado { get; set; }
        public User UserSeleciodado
        {
            get => _UserSeleciodado;
            set
            {
                if (_UserSeleciodado != value)
                {
                    _UserSeleciodado = value;
                    UserSelecled(); //Método invocado quando se fazer o set da propriedade
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand SelectedItemCommand => new Command((e) =>
        {
            _UserSeleciodado.ColorFrame = "#1b1b2f";
            _UserSeleciodado.ColorText = "#ffffff";
        });
        private void UserSelecled()
        {
            _UserSeleciodado.ColorFrame = "#1b1b2f";
            _UserSeleciodado.ColorText = "#ffffff";
        }

        private void ItemSelected(object obj)
        {
            throw new NotImplementedException();
        }

        public TransferPaymentViewModel()
        {
            Users = new ObservableCollection<User>
            {
                new User {Name = "Leo Gill", Image = "Image_005", ColorFrame="#1b1b2f", ColorText = "#ffffff"},
                new User {Name = "Elliana Palacios", Image = "Image_007", ColorFrame="#ffffff", ColorText = "#1b1b2f"},
                new User {Name = "Eduard Franz", Image = "Image_006", ColorFrame="#ffffff", ColorText = "#1b1b2f"}
            };

            Values = new ObservableCollection<Values>
            {
                new Values { Value = "+10"},
                new Values {Value = "+100"},
                new Values {Value = "-10"},
                new Values {Value = "-100"}
            };
        }
    }
}
