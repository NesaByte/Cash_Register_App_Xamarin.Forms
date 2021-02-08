using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class Restock : ContentPage
    {
        public Restock()
        {
            InitializeComponent();
        }

        void UpdateQty_Clicked(System.Object sender, System.EventArgs e) { }

        async void Cancel_Clicked(System.Object sender, System.EventArgs e) {
            await Navigation.PushModalAsync(new MainPage());

        }
    }
}