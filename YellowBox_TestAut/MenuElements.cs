using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace YellowBox_TestAut.WebDriversComponents.MenuObjects
{
    class MenuElements
    {
        public IWebElement MenuGeneralPantallaInicio(IWebDriver driver, string menuSeccion)
        {
            IWebElement menuElement = null;
            Thread.Sleep(3000);
            if (menuSeccion == "Configuracion")
            {
                IList<IWebElement> menu = driver.FindElements(By.TagName("a"));

                foreach (IWebElement menulista in menu)
                {
                    try
                    {
                        if (menulista.Text == "Configuración")
                        {
                            menulista.Click();
                        }
                    }
                    catch
                    {

                    }
                }
            }
            return menuElement;
        }
    }
}
