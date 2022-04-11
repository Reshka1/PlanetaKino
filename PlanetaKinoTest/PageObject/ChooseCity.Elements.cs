using OpenQA.Selenium;

namespace PlanetaKinoTest.PageObject
{
    public partial class ChooseCity
    {
        public readonly string btnCity = "//*[contains(@class, 'city-selector__text')]";
        public readonly string fieldDnipro = "//*[text()='Дніпро (APPOLO)']";
        public readonly string nameOfNewCity = "//*[text()='Дніпро А']";

        private IWebElement newNameOfCity => driver.FindElement(By.XPath(nameOfNewCity));
        public string CheckNewNameOfCity() => newNameOfCity.Text;
    }
}
