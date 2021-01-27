using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingProjectWebsite.PageObjectsModel
{
    partial class TShirtsPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public TShirtsPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();
        }
        public void AddTShirtToCart()
        {
            tShirtButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)");
            fadedshortSleeveShirtButton.Click();
            System.Threading.Thread.Sleep(2000);
            fadedshortSleeveShirtAddToCartButton.Click();
        }
    }
}
