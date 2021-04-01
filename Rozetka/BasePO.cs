using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozetka
{
    public class BasePO
    {
        protected IWebDriver driver;
        
        protected BasePO(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
