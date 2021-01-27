using System;
using TestingProjectWebsite.PageObjectsModel;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestingProjectWebsite.StepDefinitions
{
    [Binding]
    public class CreateAnUserSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public CreateAnUserSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I navigate to website and click login")]
        public void GivenINavigateToWebsiteAndClickLogin()
        {
           HomePage homePage = new HomePage(Driver);
           homePage.Authentification();
        }
        
        [When(@"I fill the register form with following data")]
        public void WhenIFillTheRegisterFormWithFollowingData(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            CreateAccountPage createAccountPage = new CreateAccountPage(Driver);
            createAccountPage.EnterCreateAccountCredentials(user);
        }
        
        [When(@"I click the register button")]
        public void WhenIClickTheRegisterButton()
        {
            CreateAccountPage createAccountPage = new CreateAccountPage(Driver);
            createAccountPage.registerButton.Click();
        }
        
        [Then(@"I fill desired email")]
        public void ThenIFillDesiredEmail(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            HomePage homePage = new HomePage(Driver);
            homePage.emailAddressTextBox.SendKeys(user.userEmail);
            homePage.signInButton.Click();
        }
    }
}
