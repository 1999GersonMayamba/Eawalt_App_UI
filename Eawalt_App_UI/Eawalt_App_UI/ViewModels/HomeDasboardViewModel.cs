using Eawalt_App_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Eawalt_App_UI.ViewModels
{
  public  class HomeDasboardViewModel
    {

        public ObservableCollection<Card> Cards { get; set; }
        public ObservableCollection<TrasnferPayment> Payments { get; set; }
        public HomeDasboardViewModel()
        {
            Cards = new ObservableCollection<Card>
            {
                new Card {NameOfCard = "National Bank of south", CardNumber = "2536 1457 1477 2364", Name = "Konsta Peura", DateExpi = "01/2021", ColorOfCard = Color.FromHex("#F3C9DD")},
                new Card {NameOfCard = "National Bank of south", CardNumber = "2536 1457 1477 2364", Name = "Konsta Peura", DateExpi = "01/2021", ColorOfCard = Color.FromHex("#A6CFE2")}
            };

            Payments = new ObservableCollection<TrasnferPayment>
            {
                new TrasnferPayment {Image = "Image004", Destin = "Uber Ride", DateOfTransfer = "Jun 10-12:00pm", Amount = "-$45.14"},
                new TrasnferPayment {Image = "Image003", Destin = "Spotify Subcription", DateOfTransfer = "Jun 15-05:30pm", Amount = "-$99.99"},
                new TrasnferPayment {Image = "Image002", Destin = "Netflix Account", DateOfTransfer = "Jun 15-6:00pm", Amount = "-$50.00"}
            };
        }
    }
}
