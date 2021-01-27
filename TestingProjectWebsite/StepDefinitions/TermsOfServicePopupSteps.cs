using System;
using System.Threading;
using TestingProjectWebsite.PageObjectsModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestingProjectWebsite.StepDefinitions
{
    [Binding]
    public class TermsOfServicePopupSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public TermsOfServicePopupSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am logged in with following user")]
        public void GivenIAmLoggedInWithFollowingUser(Table table)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authentification();
            var user = table.CreateInstance<UserDto>();
            SignInPage loginPage = new SignInPage(Driver);
            loginPage.EnterCredentials(user);

        }
        
        [Given(@"I add a product into cart")]
        public void GivenIAddAProductIntoCart()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AddBlouseToCart();
            Thread.Sleep(3000);
            homePage.proceedCheckoutButton.Click();
        }
        
        [When(@"I complete the checkout process")]
        public void WhenICompleteTheCheckoutProcess()
        {
            CheckoutPage checkoutPage = new CheckoutPage(Driver);
            checkoutPage.ProceedCheckout();

        }
        
        [Then(@"I am shown a popup if terms of service is not checked")]
        public void ThenIAmShownAPopupIfTermsOfServiceIsNotChecked()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/p")).Displayed);
        }
    }
}
