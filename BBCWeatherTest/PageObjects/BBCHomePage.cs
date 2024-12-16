using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace BBCWeatherTest.PageObjects
{
    class BBCHomePage : BasePage
    {
        private IWebDriver driver;

        public BBCHomePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.Id, Using = "ls-c-search__input-label")]
        private IWebElement SearchBox;

        [FindsBy(How = How.XPath, Using = "//span[text()='Bournemouth, Bournemouth']")]
        private IWebElement selectedCity;     

        public void SearchCity(string cityName)
        {
            SearchBox.Clear();
            SearchBox.SendKeys(cityName);
            SearchBox.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            selectedCity.Click();
        }
    }
}
