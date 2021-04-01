using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rozetka
{
    public class ItemPO : BasePO
    {
        #region XPathes
        private readonly string btnAddToCartXPath = "//button[@class = 'buy-button button button_with_icon button_color_green button_size_large']";
        #endregion

        #region WebElements
        private IWebElement btnAddToCart => driver.FindElement(By.XPath(btnAddToCartXPath));
        #endregion

        #region methods
        public ItemPO(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }
       
        public void ClickAddToCart()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            btnAddToCart.Click();
        }
        #endregion
    }
}
