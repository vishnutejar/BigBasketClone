namespace BigBasketClone.viewmodels
{
    public class PrivacyAndTermsandconditionsViewModel : BaseViewModel
    {
        public string _PrivacyPolicy;
        public string TermsAndConditions { get; set; }
        public string PrivacyPolicy
        {
            get
            {

                return _PrivacyPolicy;
            }
            set
            {
                _PrivacyPolicy = value;
                PropertyChangedEvent("PrivacyPolicy");
            }
        }

        public PrivacyAndTermsandconditionsViewModel()
        {
            TermsAndConditions = @"<html><body>
  <h1>Terms and conditions</h1>
  <p>Mobile app terms and conditions, also referred to as app terms of service or app terms of use, explain the rules, requirements, restrictions, and limitations that users must abide by in order to use a mobile application. Specifically, they act as a binding contract between you and your users. This contract helps protect the rights of both parties.
Business owners and app developers often use the same terms and conditions for both their website and mobile applications in order to keep their terms consistent across all platforms.
App terms and conditions help protect the owner’s intellectual property, and allow them to prohibit unwanted user activity and terminate user accounts that violate their terms.</p>
  </body></html>";

            PrivacyPolicy = @"<html><body>
  <h1>Terms and conditions</h1>
  <p>Mobile app terms and conditions, also referred to as app terms of service or app terms of use, explain the rules, requirements, restrictions, and limitations that users must abide by in order to use a mobile application. Specifically, they act as a binding contract between you and your users. This contract helps protect the rights of both parties.
Business owners and app developers often use the same terms and conditions for both their website and mobile applications in order to keep their terms consistent across all platforms.
App terms and conditions help protect the owner’s intellectual property, and allow them to prohibit unwanted user activity and terminate user accounts that violate their terms.</p>
  </body></html>";
        }
    }
}
