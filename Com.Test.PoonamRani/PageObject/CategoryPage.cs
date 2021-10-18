using Bogus;
using Com.Test.PoonamRani.Base;
using Com.Test.PoonamRani.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace Com.Test.PoonamRani.PageObject
{
    public class CategoryPage
    {

        private IWebDriver driver;

        public Settings _settings;
        public CategoryPage(Settings settings) => _settings = settings;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"block_top_menu\"]/ul/li[3]/a")]
        private IWebElement linkTshirt;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/ul/li/div/div[1]/div/a[1]/img")]
        private IWebElement hoverShirt;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add to cart')]")]
        private IWebElement btnAddToCart;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a/span")]
        private IWebElement btnProceedToCheckout;

        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/p[2]/a[1]/span")]
        private IWebElement btnProceedToCheckoutAfterSummary;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/form/p/button/span")]
        private IWebElement btnProceedToCheckoutAfterAddress;

        
        [FindsBy(How = How.XPath, Using = "//input[@id='cgv']")]
        private IWebElement checkBoxTermsOfService;

        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"form\"]/p/button/span")]
        private IWebElement btnProceedToCheckoutAfterShipping;

        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"HOOK_PAYMENT\"]/div[1]/div/p/a")]
        private IWebElement btnPayByWire;
       
        [FindsBy(How = How.XPath, Using = "//*[@id=\"cart_navigation\"]/button/span")]
        private IWebElement btnConfirmMyOrder;

        [FindsBy(How = How.XPath, Using = "//input[@id='email_create']")]
        private IWebElement txtBoxEmailCreate;

        //elements to be filled in for account creation
        [FindsBy(How = How.XPath, Using = "//input[@id='customer_firstname']")]
        private IWebElement txtBoxCustomerFirstName;
        [FindsBy(How = How.XPath, Using = "//input[@id='customer_lastname']")]
        private IWebElement txtBoxCustomerLastName;
        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        private IWebElement txtBoxPassword;
        [FindsBy(How = How.XPath, Using = "//input[@id='address1']")]
        private IWebElement txtBoxAddress;
        [FindsBy(How = How.XPath, Using = "//input[@id='city']")]
        private IWebElement txtBoxCity;
        [FindsBy(How = How.XPath, Using = "//select[@id='id_state']")]
        private IWebElement selectBoxState;
        [FindsBy(How = How.XPath, Using = "//input[@id='postcode']")]
        private IWebElement txtBoxPostCode;
        [FindsBy(How = How.XPath, Using = "//input[@id='phone_mobile']")]
        private IWebElement txtBoxMobilePhone;

        [FindsBy(How = How.XPath, Using = "//input[@id='SubmitCreate']")]
        private IWebElement btnCreateAccountByEmail;


        [FindsBy(How = How.XPath, Using = "//button[@id='submitAccount']")]
        private IWebElement btnRegisterAccount;

        public CategoryPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public CategoryPage navigateToTShirtCategory() {
            linkTshirt.Click();
            Actions action = new Actions(driver);
            action.MoveToElement(hoverShirt).Perform();
            btnAddToCart.Click();
            //Assert  //TODO
            return new CategoryPage(driver);

        }


        public CategoryPage CreateAccountByEmail(String emailToBeCreated)
        {
            if (emailToBeCreated.Equals("xxx"))
            {
                var f = new Faker();
                emailToBeCreated = f.Person.Email;
                GenericHelper.OutputFormattedAs("", "email selected for updating"
                    , emailToBeCreated);
            }


            txtBoxEmailCreate.Clear();
            txtBoxEmailCreate.SendKeys(emailToBeCreated);
            txtBoxEmailCreate.SendKeys(Keys.Enter);
            return new CategoryPage(driver);
        }

        public CategoryPage AddAccountDetails(AppSettings configurations)
        {
            txtBoxCustomerFirstName.Clear();
            txtBoxCustomerFirstName.SendKeys(configurations.firstname);
            txtBoxCustomerLastName.SendKeys(configurations.lastname);
            txtBoxPassword.SendKeys(configurations.password);
            txtBoxAddress.SendKeys(configurations.address);
            txtBoxCity.SendKeys(configurations.city);
            selectBoxState.SendKeys(configurations.state);
            txtBoxPostCode.SendKeys(configurations.postcode);
            txtBoxMobilePhone.SendKeys(configurations.phonemobile);
            btnRegisterAccount.Click();
            return new CategoryPage(driver);
        }

        public CategoryPage proceedToCheckout()
        {
            btnProceedToCheckout.Click();
            btnProceedToCheckoutAfterSummary.Click();
            return new CategoryPage(driver);

        }

        public CategoryPage completePurchase()
        {
            btnProceedToCheckoutAfterAddress.Click();
            checkBoxTermsOfService.Click();
            btnProceedToCheckoutAfterShipping.Click();
            btnPayByWire.Click();
            btnConfirmMyOrder.Click();
            return new CategoryPage(driver);

        }

    }
}
