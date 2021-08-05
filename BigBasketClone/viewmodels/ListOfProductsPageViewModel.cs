using BigBasketClone.models;
using BigBasketClone.views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BigBasketClone.viewmodels
{
    public class ListOfProductsPageViewModel:BaseViewModel
    {
       public ICommand GoToProfileCommand { get; set; }
        public ObservableCollection<CarosalProducts> CarosalProducts { get; set; }
        public ListOfProductsPageViewModel() {
            GoToProfileCommand = new Command(NavigationToProfile);
            CarosalProducts = new ObservableCollection<CarosalProducts>()
            {
                new CarosalProducts{ ProductImage="icon",ProductName="product1"},
                new CarosalProducts{ ProductImage="icon",ProductName="product1"},
                new CarosalProducts{ ProductImage="icon",ProductName="product1"},
                new CarosalProducts{ ProductImage="icon",ProductName="product1"},
                new CarosalProducts{ ProductImage="icon",ProductName="product1"},
                new CarosalProducts{ ProductImage="icon",ProductName="product1"},
                new CarosalProducts{ ProductImage="icon",ProductName="product1"},
                new CarosalProducts{ ProductImage="icon",ProductName="product1"},
                new CarosalProducts{ ProductImage="icon",ProductName="product1"},
            };
        }

        private void NavigationToProfile(object obj)
        {
            Shell.Current.Navigation.PushAsync(new ProfilePage());
        }
    }
}
