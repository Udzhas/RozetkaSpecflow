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
    class CartPO : BasePO
    {
        #region XPathes
        private readonly string pgoneItemInCartXPath = "//a[@href = 'https://rozetka.com.ua/tenuta_berni_8010719007902/p132897944/']";
        private readonly string vineItemInCartXPath = "/html/body/app-root/single-modal-window/div[2]/div[2]/rz-shopping-cart/div/ul/li/rz-cart-product/div/div[1]/div[2]/a";
        #endregion

        #region WebElements
        IWebElement vineItemInCart => driver.FindElement(By.XPath(vineItemInCartXPath));
        IWebElement phoneItemInCart => driver.FindElement(By.XPath(pgoneItemInCartXPath));
        #endregion

        #region methods
        public CartPO(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }
        
        public void IsVineItemInCart()
        {
            Assert.IsTrue(vineItemInCart.Displayed);
            
        }

        public void IsPhoneItemInCart()
        {
            Assert.IsTrue(phoneItemInCart.Displayed);
        }
        #endregion
    }
}
