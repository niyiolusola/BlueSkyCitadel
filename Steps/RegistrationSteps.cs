using Longrichway21.PageObjects;
using System;
using TechTalk.SpecFlow;


namespace Longrichway21.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;
        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }
        
        [Given(@"a user navigates to ""(.*)""")]
        public void GivenAUserNavigatesTo(string url)
        {
            registrationPage.Navigate(url);
        }
        
        [When(@"the user Clicks on register")]
        public void WhenTheUserClicksOnRegister()
        {
            registrationPage.ClickRegister();
        }
        
        [When(@"the user enters First Name ""(.*)""")]
        public void WhenTheUserEntersFirstName(string firstNameTest)
        {
            registrationPage.EnterFirstName(firstNameTest);
        }
        
        [When(@"the user enters Last Name ""(.*)""")]
        public void WhenTheUserEntersLastName(string lastNameText)
        {
            registrationPage.EnterLastName(lastNameText);
        }
        
        [When(@"the user enters Email Address ""(.*)""")]
        public void WhenTheUserEntersEmailAddress(string emailText)
        {
            registrationPage.EnterEmailAddress(emailText);
        }
        
        [When(@"the user enters Phone ""(.*)""")]
        public void WhenTheUserEntersPhone(String phoneText)
        {
            registrationPage.EnterPhone(phoneText);
        }
        
        [When(@"the user enters Password ""(.*)""")]
        public void WhenTheUserEntersPassword(string Password)
        {
            registrationPage.EnterPassword(Password);
        }
        
        [When(@"the user enters Confirm Password ""(.*)""")]
        public void WhenTheUserEntersConfirmPassword(string ConfPassword)
        {
            registrationPage.EnterConfPassword(ConfPassword);
        }
        
        [When(@"the user enters Address ""(.*)""")]
        public void WhenTheUserEntersAddress(string Address)
        {
            registrationPage.EnterAddress(Address);
        }
        
        [When(@"the user enters TownCity ""(.*)""")]
        public void WhenTheUserEntersTownCity(string TownCity)
        {
            registrationPage.EnterTownCity(TownCity);
        }
        
        [When(@"the user enters State ""(.*)""")]
        public void WhenTheUserEntersState(string State)
        {
            registrationPage.EnterState(State);
        }
        
        [When(@"the user Clicks on Create Account")]
        public void WhenTheUserClicksOnCreateAccount()
        {
            registrationPage.ClickCreateAccount();
        }
        
        [Then(@"the user is logged into New Account")]
        public void ThenTheUserIsLoggedIntoNewAccount()
        {
            
        }
    }
}
