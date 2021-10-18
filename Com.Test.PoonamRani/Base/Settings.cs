using Com.Test.PoonamRani.PageObject;
using Com.Test.PoonamRani.Steps;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Com.Test.PoonamRani.Base

{
    public class Settings
    {
        public AppSettings configurations { get; set; }
        public IndexPage indexPage;
        
        Settings()
        {
            //Read settings from JSON file and parse to class object 
            using (StreamReader r = new StreamReader("appSettings.json"))
            {
                string json = r.ReadToEnd();
                configurations = JsonConvert.DeserializeObject<AppSettings>(json);
            }

            configurations.driver = new ChromeDriver();
            configurations.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);
            configurations.driver.Manage().Window.Maximize();
        }

    }
}

