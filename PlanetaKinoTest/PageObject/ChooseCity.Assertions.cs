
using NUnit.Framework;

namespace PlanetaKinoTest.PageObject
{
    public partial class ChooseCity
    {
        public void CheckMyCity()
        {
            ExpectedText cityName = new ExpectedText();

            var actualCity = CheckNewNameOfCity();
            var expedCity = cityName.expectedText;

            Assert.AreEqual(expected: expedCity, actualCity, $"{expedCity} is not equal to {actualCity}");
        }
    }
}
