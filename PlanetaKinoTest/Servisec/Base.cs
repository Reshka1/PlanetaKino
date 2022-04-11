using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace PlanetaKinoTest.Servisec
{
    public class Base
    {
        protected static IWebDriver driver;
        protected static WebDriverWait wait;

        public Base()
        {
        }

        public Base(IWebDriver webDriver)
        {
            driver = webDriver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
    }
}
