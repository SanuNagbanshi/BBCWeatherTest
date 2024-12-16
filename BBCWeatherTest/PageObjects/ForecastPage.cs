using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCWeatherTest.PageObjects
{
      public class ForecastPage : BasePage
        {
            [FindsBy(How = How.XPath, Using = "//*[@id='daylink-2']")]
            private IWebElement TomorrowTab;

            [FindsBy(How = How.CssSelector, Using = ".wr-day-temperature__high-value .wr-value--temperature--c")]
            private IWebElement HighTemperature;

            [FindsBy(How = How.CssSelector, Using = ".wr-day-temperature__low-value .wr-value--temperature--c")]
            private IWebElement LowTemperature;

            public ForecastPage(IWebDriver driver) : base(driver) { }

            public void SelectTomorrow()
            {
                TomorrowTab.Click();
            }

            public int GetHighTemperature()
            {
                return int.Parse(HighTemperature.Text.Replace("°", ""));
            }

            public int GetLowTemperature()
            {
                return int.Parse(LowTemperature.Text.Replace("°", ""));
            }
        }
}
