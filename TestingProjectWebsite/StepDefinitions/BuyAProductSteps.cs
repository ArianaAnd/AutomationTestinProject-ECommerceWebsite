using System;
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
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I finish the checkout steps")]
        public void WhenIFinishTheCheckoutSteps()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"My order is completed")]
        public void ThenMyOrderIsCompleted()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
