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
    public sealed class IndexSteps
    {

        public Settings _settings;
        IndexSteps(Settings settings) => _settings = settings;

        IndexPage indexPage;

       
    }
}
