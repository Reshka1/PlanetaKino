using NUnit.Framework;
using PlanetaKinoTest.PageObject;
using PlanetaKinoTest.Servisec;

namespace PlanetaKinoTest
{
    public class ChooseCorrectCityAndCinemaTest : Page
    {
        private ChooseCity chooseCity;

        [SetUp]
        public void SetUp()
        {
            chooseCity = new ChooseCity(driver);
        }

        [Test]
        public void CheckChoosingCorrectCityAndCinema()
        {
            chooseCity.ClickBtnCity();
            chooseCity.ClickFieldDnipro();
            chooseCity.CheckMyCity();
        }
    }
}