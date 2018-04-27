using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA;

namespace YellowBox_TestAut.WebDriversComponents.SubMenuObjects
{
    class SubMenuElements
    {
        public IWebElement SubMenuGradosYSalones(IWebDriver driver, string subMenu)
        {
            IWebElement SubMenuGyS = null;

            IWebElement submenu = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/section/div/div/div[2]/div[3]/a"));
            submenu.Click();

            return SubMenuGyS;
        }

    }
}
