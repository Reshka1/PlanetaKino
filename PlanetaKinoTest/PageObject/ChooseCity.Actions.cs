using OpenQA.Selenium;
using PlanetaKinoTest.AllCinema;
using PlanetaKinoTest.Servisec;
using SeleniumExtras.WaitHelpers;

namespace PlanetaKinoTest.PageObject
{
    public partial class ChooseCity : Base
    {

        public ChooseCity(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        public void ClickBtnCity()
        {
            DniproCinema location = new DniproCinema();
            location.MyCinema("Dnipro");

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(btnCity))).Click();

        }

        public void ClickFieldDnipro()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(fieldDnipro)));

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(fieldDnipro))).Click();
            }
            catch
            {
                driver.Quit();
            }
        }

        public class ExpectedText
        {
            private object text = "Дніпро А";
            public object expectedText
            {
                get { return text; }
            }
        }

    }
}
