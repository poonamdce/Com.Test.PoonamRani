using Com.Test.PoonamRani.Base;
using Com.Test.PoonamRani.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Com.Test.PoonamRani.PageObject
{
    public class IndexPage
    {
        private IWebDriver driver;

        public Settings _settings;
        public IndexPage(Settings settings) => _settings = settings;

        public IndexPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IndexPage goToPage(string url) {
            driver.Navigate().GoToUrl(url);
            return new IndexPage(driver);

        }

    }
}
