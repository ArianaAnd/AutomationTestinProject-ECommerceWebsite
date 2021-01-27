using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingProjectWebsite.PageObjectsModel
{
   partial class CheckoutPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public CheckoutPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();
        }

        public void ProceedCheckout()
        {
            proceedCheckoutButton.Click();
            addressProceedCheckoutButton.Click();
            shippingTermsofServiceCheckbox.Click();
            shippingProceedCheckoutButton.Click();
            paymentBankWireButton.Click();
            confirmOrderButton.Click();
        }

        public void TermsofService()
        {
            proceedCheckoutButton.Click();
            addressProceedCheckoutButton.Click();
            shippingProceedCheckoutButton.Click();
        }
    }
}
