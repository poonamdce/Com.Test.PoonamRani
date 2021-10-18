using OpenQA.Selenium;
using Com.Test.PoonamRani.Base;
using Com.Test.PoonamRani.PageObject;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Com.Test.PoonamRani.Helpers;

namespace Com.Test.PoonamRani.Steps
{
    [Binding]
    public sealed class CategorySteps
    {

        public Settings _settings;
        public CategorySteps(Settings settings) => _settings = settings;

        CategoryPage categoryPage;

        [Given(@"mark wants to order a T-Shirt")]
        public void GivenMarkWantsToOrderAT_Shirt()
        {
        }
        [When(@"mark selects and add to basket")]
        public void WhenMarkSelectsAndAddToBasket()
        {
            categoryPage = new CategoryPage(_settings.configurations.driver);
            categoryPage
                .navigateToTShirtCategory()
                .proceedToCheckout();
        }

       
        [Then(@"mark create an account with email ""(.*)""")]
        public void ThenMarkCreateAnAccountWithEmail(string email)
        {
            categoryPage = new CategoryPage(_settings.configurations.driver);
            categoryPage
                .CreateAccountByEmail(email)
                .AddAccountDetails(_settings.configurations);
        }
        
        [Then(@"mark completes the purchase")]
        public void ThenMarkCompletesThePurchase()
        {
            categoryPage = new CategoryPage(_settings.configurations.driver);
            categoryPage
                .completePurchase();
        }





    }
}
