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
                new mHistory("TEST", "20", "20", "4 Feb 2021"),
                new mHistory("TEST2", "20", "20", "4 Feb 2021"),

            };
            return history;
        }

        public void addHistory(string n, string q, string t, string d)
        {
            ObservableCollection<mHistory> history = new ObservableCollection<mHistory>() {
                new mHistory(n,q,t,d)
            };
        }


    }
}
