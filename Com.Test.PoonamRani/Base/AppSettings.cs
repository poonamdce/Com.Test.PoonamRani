using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Com.Test.PoonamRani.Base

{
    public class AppSettings
    {
        public string baseUrl { get; set; }
        public IWebDriver driver { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string phonemobile { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        
    }



}

