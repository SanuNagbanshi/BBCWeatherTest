using BBCWeatherTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BBCWeatherTest.Steps
{
    [Binding]
    class BBCHomePageStepDefinition
    {
        private readonly IWebDriver _driver;
        BBCHomePage _bBCHomePage;
        ForecastPage _forecastPage;

        public BBCHomePageStepDefinition(ScenarioContext scenarioContext)
        {
            _driver = scenarioContext["WebDriver"] as IWebDriver;
        }

        [Given(@"Url of BBC Weather Site is launched")]
        public void GivenUrlOfBBCWeatherSiteIsLaunched()
        {
            _driver.Navigate().GoToUrl("https://www.bbc.com/weather");
        }

        [When(@"I enter city Name as ""(.*)""")]
        public void WhenIEnterCityNameAs(string cityName)
        {
            _bBCHomePage = new BBCHomePage(_driver);
            _bBCHomePage.SearchCity(cityName);
        }

        [When(@"I click on Tomorrow Date On Weather Page")]
        public void WhenIClickOnTomorrowDateOnWeatherPage()
        {

            _forecastPage = new ForecastPage(_driver);
            _forecastPage.SelectTomorrow();
        }

        [Then(@"I verify tomorrow Max temperature is higher than tomorrows low temperature")]
        public void ThenIVerifyTomorrowMaxTemperatureIsHigherThanTomorrowsLowTemperature()
        {
            int highTemp = _forecastPage.GetHighTemperature();
            int lowTemp = _forecastPage.GetLowTemperature();
            Assert.Greater(highTemp, lowTemp, $"High temperature ({highTemp}) is not greater than Low temperature ({lowTemp}).");
        }
    }



    }

