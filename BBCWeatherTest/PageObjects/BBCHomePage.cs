using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCWeatherTest.PageObjects
{
    class BBCHomePage : BasePage
    {

        [FindsBy(How = How.Id, Using = "ls-c-search__input-label")]
        private IWebElement SearchBox;


        [FindsBy(How = How.XPath, Using = "//span[text()='Bournemouth, Bournemouth']")]
        private IWebElement selectedCity;

        
        public BBCHomePage(IWebDriver driver) : base(driver) { }

        public void SearchCity(string cityName)
        {
            SearchBox.Clear();
            SearchBox.SendKeys(cityName);
            SearchBox.SendKeys(Keys.Enter);
            selectedCity.Click();
        }
    }
}
