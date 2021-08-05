using BigBasketClone.services;
using BigBasketClone.views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BigBasketClone.viewmodels
{
    public class ShellViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }
        public ObservableCollection<FlyoutItemsModel> FlyoutItems { get; set; }

        private string _pagetype;

        public string PageType
        {

            get { return _pagetype; }
            set
            {
                _pagetype = value;
                PropertyChangedEvent("PageType");

            }
        }

        public ShellViewModel()
        {

            FlyoutItems = FlyoutItemsService.flyoutItemsModels;
            LoginCommand = new Command((x)=>GotoLogin(x));
        }

        private void GotoLogin(object obj)
        {
            var data = obj as string;
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;

            Shell.Current.Navigation.PushModalAsync(new LoginAndSignupPage(data));
            Shell.Current.FlyoutIsPresented = false;
        }

    }
}
