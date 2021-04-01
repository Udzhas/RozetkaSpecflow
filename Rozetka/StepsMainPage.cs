using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Rozetka
{
    [Binding]
    public sealed class StepsMainPage
    {
        protected static IWebDriver driver;
        MainPO mainPage = new MainPO(driver);
        ItemPO itemPage = new ItemPO(driver);
        CartPO cartPage = new CartPO(driver);
        SearchPO searchPage = new SearchPO(driver);

        [BeforeScenario]
        public static void Setup()
        {
            driver = new ChromeDriver("D:\\chromedriver");
            driver.Manage().Window.Maximize();
        }

        [Given(@"I am on Rozetka page")]
        public void GivenIAmOnRozetkaPage()
        {
            mainPage.GoTo();
            Console.WriteLine("Rozetka opened");
        }

        [When(@"I select item")]
        public void WhenISelectItem()
        {
            mainPage.SelectItem();
            Console.WriteLine("Item selected");
        }

        [Then(@"I add to cart this item")]
        public void ThenIAddToCartThisItem()
        {
            itemPage.ClickAddToCart();
            Console.WriteLine("Item added");
        }

        [Then(@"I see selected item in cart")]
        public void ThenIShouldSeeSelectedItemInCart()
        {
            cartPage.IsVineItemInCart();
            Console.WriteLine("Item is in cart");
        }

        [Given(@"I search for '(.*)'")]
        public void GivenSearchFor(string searchInfo)
        {
            mainPage.SearchItem(searchInfo);
        }

        [Then(@"I click Search button")]
        public void ThenIClickSearchButton()
        {
            mainPage.ClickSearchButton();
        }

        [Then(@"I filter for mobile phones only")]
        public void ThenIFilterForMobilePhonesOnly()
        {
            searchPage.ApplyFilters();
        }

        [Then(@"I see that title is present")]
        public void ThenIShouldHaveCorrectResult()
        {
            searchPage.SearchConfrimation();
        }

        [When(@"I click on item")]
        public void WhenIClickOnItem()
        {
            searchPage.SelectProduct();
        }

        [Then(@"I see selected phone item in cart")]
        public void ThenIShouldSeeSelectedPhoneItemInCart()
        {
            cartPage.IsPhoneItemInCart();
        }

        [AfterScenario]
        public static  void TearDown()
        {
            driver.Quit();
        }

    }
}




