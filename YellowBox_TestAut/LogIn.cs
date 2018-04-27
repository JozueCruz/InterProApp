using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace YellowBox_TestAut
{
    [TestClass]
    public class LogIn
    {
        //Instancia del Objeto
        string urlTest = "http://yellowbox-web-escuela-app-dev.azurewebsites.net/ShellYellowBox/SFSdotNetFrameworkSecurity/Public/Login?ReturnUrl=%2FShellYellowBox%2FMBKYellowBox%2FZonaDireccions%2FEditGen%3Fid%3DE5Qsr2edZ7w6UvmB1M1%252BWrXH5qU2xcjEI1RGKh8iKgrHsNs9naNVN8gumv5W44diJa9fxVKvBBI%253D";
        WebDriversComponents.WebDriverObjects.UserLogInObjects objectsSystem = new WebDriversComponents.WebDriverObjects.UserLogInObjects();
        WebDriversComponents.LogInObjects.LogInElements LogInElement = new WebDriversComponents.LogInObjects.LogInElements();
        WebDriversComponents.WebDriverProcess.LogInProcess accessSystem = new WebDriversComponents.WebDriverProcess.LogInProcess();
        WebDriversComponents.MenuObjects.MenuElements menuGneralElements = new WebDriversComponents.MenuObjects.MenuElements();
        WebDriversComponents.MenuProcess.MenuProcess menuAccesSystem = new WebDriversComponents.MenuProcess.MenuProcess();
        WebDriversComponents.SubMenuObjects.SubMenuElements subMElements = new WebDriversComponents.SubMenuObjects.SubMenuElements();

        [TestMethod]
        public void AccesoYelloBoxTestCase_001()
        {
            objectsSystem.Browser = "Chrome";
            objectsSystem.Url = urlTest;
            objectsSystem.UserName = "juan.valderrama@mobiik.com";
            objectsSystem.PasswordUser = "ff2e54aee4c5";
            string testCase = "AccesoYellowTestCase_001";
            objectsSystem.TestCase = testCase;

            IWebDriver testDriver = accessSystem.InitializeTheBrowser(objectsSystem);
            accessSystem.LogInAccess(testDriver, objectsSystem, testCase);

            Thread.Sleep(2000);
            testDriver.Quit();
        }

        [TestMethod]
        public void AccesoMenuConfiguracion_002()
        {
            objectsSystem.Browser = "Chrome";
            objectsSystem.Url = urlTest;
            objectsSystem.UserName = "juan.valderrama@mobiik.com";
            objectsSystem.PasswordUser = "ff2e54aee4c5";
            string testCase = "AccesoMenuConfiguracionTestCase_002";
            objectsSystem.TestCase = testCase;
            objectsSystem.Menu = "Configuracion";

            IWebDriver testDriver = accessSystem.InitializeTheBrowser(objectsSystem);
            menuAccesSystem.MenuAccess(testDriver, objectsSystem, testCase);
            testDriver.Quit();
        }

        [TestMethod]
        public void AccesoSubMenuGrados_003 ()
        {
            objectsSystem.Browser = "Chrome";
            objectsSystem.Url = urlTest;
            objectsSystem.UserName = "juan.valderrama@mobiik.com";
            objectsSystem.PasswordUser = "ff2e54aee4c5";
            string testCase = "AccesoSubMenuGrados_003";
            objectsSystem.TestCase = testCase;
            objectsSystem.Menu = "Configuracion";
            objectsSystem.SubMenu = "Grados y Salones";

            IWebDriver testDriver = accessSystem.InitializeTheBrowser(objectsSystem);
            menuAccesSystem.MenuAccess(testDriver, objectsSystem, testCase);
            subMElements.SubMenuGradosYSalones(testDriver, objectsSystem.SubMenu).Click();

            testDriver.Quit();
        }

        /*
        Thread.Sleep(2000);
        //IWebElement menu = driver.FindElement(By.CssSelector("[href*='/ShellYellowBox/MBKYellowBox/Configuracion/IndexEscuela']"));
        //IWebElement menu = driver.FindElement(By.XPath("//[@id='menuconfiguracion']"));
        //var table = driver.FindElements(By.TagName("li"));


        //Agregar Niveles Escolares
        IWebElement nivelesEscolares = driver.FindElement(By.Id("c"));
        nivelesEscolares.Click();

        IWebElement capturaNivel = driver.FindElement(By.XPath("//*[@id='Descripcion']"));
        capturaNivel.SendKeys("Grado A");
        capturaNivel.Submit();

        /////
        Thread.Sleep(20000);
        IList<IWebElement> altagrado = driver.FindElements(By.TagName("tr"));

        Thread.Sleep(3000);


        // Dar clic al Menu Creado llamado "Grado A"

        driver.FindElement(By.LinkText("Grado A")).Click();


        */
        //Actual Solucion



        //Thread.Sleep(3000);
        /*
            // Dar clic al menu de opciones del grupo creado
            driver.FindElement(By.XPath("//span[@id='menuDesplagable']/i")).Click();

        // clic a la opcion de Eliminar
          driver.FindElement(By.LinkText("Eliminar")).Click();

        Thread.Sleep(3000);

        // Confirmar Eliminar

        driver.FindElement(By.XPath("//button[2]")).Click();

        */

        //foreach (IWebElement menugrado in altagrado)
        //{
        //    String temp = menugrado.Text.ToString();
        //    if (temp == "1 Grado A")
        //    {
        //        //Thread.Sleep(20000);
        //        menugrado.Click();
        //        IWebElement altaGrados = driver.FindElement(By.XPath("//*[@id='trAhoHg8RlL0yWQVq82uo8mqQhXcLMtZ5F9Gnu98OJk-Ruep9Vja9qgu4o5-CGSmd8aFTfkHIqHo']/td[3]/a"));
        //        altaGrados.Click();
        //        menugrado.Text.ToString();

        //    }
    }
}
    
    

