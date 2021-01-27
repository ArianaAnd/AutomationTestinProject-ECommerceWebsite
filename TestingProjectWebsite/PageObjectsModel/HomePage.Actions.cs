using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProjectWebsite.PageObjectsModel
{
    partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();
        }

        public void Authentification()
        {
            signInButton.Click();
        }

        public void AddBlouseToCart()
        {
            homeButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)");
            blouseButton.Click();
            System.Threading.Thread.Sleep(2000);
            blouseAddToCartButton.Click();
        }

        public void VerifyNextPrevButtons()
        {
            nextCarouselButton.Click();
            prevCarouselButton.Click();
        }

        public void VerifyPopularBestSellersButtons()
        {
            popularButton.Click();
            bestSellerButton.Click();
        }

        public void HomePageButton()
        {
            blouseButton.Click();
            homeButton.Click();
        }
    }
}
