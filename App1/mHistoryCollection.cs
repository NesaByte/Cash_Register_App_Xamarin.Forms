using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1
{
    public class mHistoryCollection
    {
        static mHistoryCollection() { }

        public static ObservableCollection<mHistory> getHistory()
        {
            ObservableCollection<mHistory> history = new ObservableCollection<mHistory>() {

            };
            return history;
        } 
    }
}
