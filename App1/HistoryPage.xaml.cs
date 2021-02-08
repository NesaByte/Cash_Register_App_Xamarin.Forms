using App1.myClasses;
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
        public ObservableCollection<myHistory> history;

        public HistoryPage()
        {
            InitializeComponent();
            history = new ObservableCollection<myHistory>
            {
                //(string hname, string hqty, string htotalprice, string hpurchasedate)
                new myHistory(){hname = "TEST hname", hqty="20", htotalprice ="10", hpurchasedate="4 Feb 2021"}, 
            };
            myhlist.ItemsSource = history;

            //myhlist.BindingContext = new myHistoryCollection(Navigation);

        }
    }
} 