using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestingProjectWebsite.PageObjectsModel;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestingProjectWebsite.StepDefinitions
{
    [Binding]
    public class BuyAProductSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public BuyAProductSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am logged in with existing user")]
        public void GivenIAmLoggedInWithExistingUser(Table table)
        {
           HomePage homePage = new HomePage(Driver);
           homePage.Authentification();
           var user = table.CreateInstance<UserDto>();
           SignInPage signin = new SignInPage(Driver);
           signin.EnterCredentials(user);
        }
        
        [When(@"I add the T-shirt to cart")]
        public void WhenIAddTheT_ShirtToCart()
        {
            TShirtsPage tshirt = new TShirtsPage(Driver);
            tshirt.AddTShirtToCart();
        }
        
        [When(@"I access the cart to proceed to checkout")]
        public void WhenIAccessTheCartToProceedToCheckout()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.proceedCheckoutButton.Click();
        }
        
        [When(@"I finish the checkout steps")]
        public void WhenIFinishTheCheckoutSteps()
        {
            CheckoutPage checkoutPage = new CheckoutPage(Driver);
            checkoutPage.ProceedCheckout();
        }
        
        [Then(@"My order is completed")]
        public void ThenMyOrderIsCompleted()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/p/strong")).Text == "Your order on My Store is complete.");
        }
    }
}
