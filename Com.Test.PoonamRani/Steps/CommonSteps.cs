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
    public sealed class CommonSteps
    {

        public Settings _settings;
        public CommonSteps(Settings settings) => _settings = settings;

        public string inputWebsiteName = "";
        IndexPage indexPage;

        [Given(@"mark navigates to site ""(.*)""")]
        public void GivenMarkNavigatesToSite(
            string websiteName)
        {
            if (websiteName.Equals("xxx")) websiteName = _settings.configurations.baseUrl;
            GenericHelper.OutputFormattedAs("", "Website Name", websiteName);
            inputWebsiteName = websiteName;
            indexPage = new IndexPage(_settings.configurations.driver);
            indexPage
                .goToPage(inputWebsiteName);
        }

    }
}
