using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozetka
{
    public class SearchPO : BasePO
    {
        #region XPathes
        private readonly string mobilePhonesFilterXPath = "//span[contains(string(), 'Мобильные телефоны')]";
        private readonly string searchResultsXPath = "//span[contains(text(), 'Мобильный телефон Apple iPhone 12 Pro 128GB Graphite Официальная гарантия')]";
        private readonly string phoneTileXPath = "/html/body/app-root/div/div[1]/rz-search/rz-catalog/div/div[2]/section/rz-grid/ul/li[2]/app-goods-tile-default/div/div[2]/a[1]";
        #endregion

        #region WebElements
        private IWebElement mobilePhonesFilter => driver.FindElement(By.XPath(mobilePhonesFilterXPath));
        private IWebElement searchResults => driver.FindElement(By.XPath(searchResultsXPath));
        private IWebElement phoneTile => driver.FindElement(By.XPath(phoneTileXPath));
        #endregion

        #region methods
        public SearchPO(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }
        public void ApplyFilters()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            mobilePhonesFilter.Click();
        }

        public void SearchConfrimation()
        {
            Assert.IsTrue(searchResults.Displayed);
        }

        public void SelectProduct()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            phoneTile.Click();
        }
        #endregion
    }
}
