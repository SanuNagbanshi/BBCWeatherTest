using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCWeatherTest.PageObjects
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
