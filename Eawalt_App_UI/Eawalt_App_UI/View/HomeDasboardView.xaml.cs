using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eawalt_App_UI.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeDasboardView : ContentPage
    {
        public HomeDasboardView()
        {
            InitializeComponent();
            this.BindingContext = new Eawalt_App_UI.ViewModels.HomeDasboardViewModel();
        }
    }
}