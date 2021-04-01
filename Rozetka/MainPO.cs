using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Rozetka
{
    public class MainPO : BasePO
    {
        #region XPathes
        private readonly string inputBoxXPath = "//input[@name = 'search']";
        private readonly string btnSearchXPath = "//button[contains(text(), 'Найти')]";
        private readonly string itemTitleXPath = "//a[@title = 'Вино игристое Tenuta Berni Prosecco Vino Frizzante doc белое сухое 0.75 л 10.5% (8010719007902)']";
        #endregion

        #region WebElements
        private IWebElement inputBox => driver.FindElement(By.XPath(inputBoxXPath));
        protected IWebElement btnSearch => driver.FindElement(By.XPath(btnSearchXPath));
        protected IWebElement itemTitle => driver.FindElement(By.XPath(itemTitleXPath));
        #endregion

        #region methods
        public MainPO(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void GoTo()
        {
            driver.Navigate().GoToUrl("https://rozetka.com.ua");
        }

        public void SelectItem()
        {
            itemTitle.Click();
        }

        public void SearchItem(String inputText)
        {
            inputBox.SendKeys(inputText);
        }

        public void ClickSearchButton()
        {
            btnSearch.Click();
        }
        #endregion
    }
}
