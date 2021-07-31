using BigBasketClone.views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BigBasketClone.viewmodels
{
    public class LoginAndSignupPageViewModel : BaseViewModel
    {

        public string _PhoneNumber;

        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
                ValidatePhoneNuber();
                PropertyChangedEvent("PhoneNumber");
            }
        }

        private void ValidatePhoneNuber()
        {
            var phnum = PhoneNumber;
            if (string.IsNullOrEmpty(phnum)) {

                IsLoginEnable = false;
            }
            if (phnum.Length >= 10)
            {

                IsLoginEnable = true;
            }
            else {

                IsLoginEnable = false;
            }
        }

        public bool _IsLoginEnable;
        public bool IsLoginEnable
        {
            get
            {
                return _IsLoginEnable;
            }
            set
            {
                _IsLoginEnable = value;
                PropertyChangedEvent("IsLoginEnable");
            }
        }


        private bool islogin;
        public bool IsLogin
        {
            get
            {
                return islogin;
            }
            set
            {
                islogin = value;
                PropertyChangedEvent("IsLogin");
            }
        }
        private bool issignup;
        public bool IsSignUp
        {
            get
            {
                return issignup;
            }
            set
            {
                issignup = value;
                PropertyChangedEvent("IsSignUp");
            }
        }

        public ICommand CloseCommand { get; set; }
        public ICommand TermsAndConditionsCommand { get; set; }
        public ICommand PriveryCommand { get; set; }
        public ICommand LoginTabCommand { get; set; }
        public ICommand SignUpTabCommand { get; set; }

        public LoginAndSignupPageViewModel()
        {
            IsLogin = true;
            IsSignUp = false;

            CloseCommand = new Command(CloseButton);
            TermsAndConditionsCommand = new Command(TermsAndConditionsCommandButton);
            PriveryCommand = new Command(PriveryCommandButton);
            LoginTabCommand = new Command(LoginTabButton);
            SignUpTabCommand = new Command(SignUpTabCommandButton);

        }

        private void SignUpTabCommandButton(object obj)
        {
            IsLogin = false;
            IsSignUp = true;
        }

        private void LoginTabButton(object obj)
        {
            IsLogin = true;
            IsSignUp = false;
        }

        private void PriveryCommandButton(object obj)
        {
            //naviagte Privacy
            App.Current.MainPage.Navigation.PushAsync(new PrivacyPolicyView());
        }

        private void TermsAndConditionsCommandButton(object obj)
        {
            //naviagte terms and conditions
        }

        private void CloseButton(object obj)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
