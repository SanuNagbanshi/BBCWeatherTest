using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCWeatherTest.PageObjects
{
      public class ForecastPage : BasePage
        {
            [FindsBy(How = How.XPath, Using = "//*[@id='daylink-1']")]
            private IWebElement TomorrowTab;

            [FindsBy(How = How.XPath, Using = "//*[@id='daylink-2']//span[@class='wr-day-temperature__high-value']/span/span[1]")]
            private IWebElement _tomorrowHighTemperature;

            [FindsBy(How = How.XPath, Using = "//*[@id='daylink-2']//span[@class='wr-day-temperature__low-value']/span/span[1]")]
            private IWebElement _tomorrowLowTemperature;


            public ForecastPage(IWebDriver driver) : base(driver) { }

            public void SelectTomorrow()
            {
                TomorrowTab.Click();
            }

            public int GetHighTemperature()
            {
                return int.Parse(_tomorrowHighTemperature.Text.Replace("°", ""));
            }

            public int GetLowTemperature()
            {
                return int.Parse(_tomorrowLowTemperature.Text.Replace("°", ""));
            }
        }
}
