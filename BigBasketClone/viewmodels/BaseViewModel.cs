using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BigBasketClone.viewmodels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void PropertyChangedEvent(string propertyname) {

            var handler = PropertyChanged;
            if (handler != null) {

                handler(this,new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
