using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        } 
        async public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;  
            mHistory h = (mHistory)((ListView)sender).SelectedItem;
            await Navigation.PushAsync(new HistoryPageDetails(h));

            ((ListView)sender).SelectedItem = null;  
        }
    }
} 