using BigBasketClone.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BigBasketClone.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginAndSignupPage : ContentPage
    {
        public LoginAndSignupPage(string Pagetype)
        {
            InitializeComponent();
            var viewmodel = this.BindingContext as LoginAndSignupPageViewModel;

            if (Pagetype.Equals("1")) {
                viewmodel.LoginTabCommand.Execute(null);
            }
            else {
                viewmodel.SignUpTabCommand.Execute(null);
            }
            
        }
    }
}