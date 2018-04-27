using System;
using OpenQA.Selenium;
using OpenQA;
using OpenQA.Selenium.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Linq;

namespace YellowBox_TestAut.WebDriversComponents.WebDriverProcess
{
    [TestClass]
    class LogInProcess
    {
        private bool logInResult;

        //Creacion de los objetos de prueba 
        LogInObjects.LogInElements userLogIn = new LogInObjects.LogInElements();

        [TestMethod]
        public void LogInAccess(IWebDriver driver, WebDriverObjects.UserLogInObjects userLogInObject, string testCase)
        {
            string logoRoute = Path.GetFullPath("\\Users\\User\\Documents\\4.- Proyectos\\Yellow Box\\logo.png");
            int sleepTimerSlow = 7000;
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document();
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,new FileStream(@"..\00_Login_" + userLogInObject.TestCase + ".pdf", FileMode.Create));
            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Automatizacion");
            doc.AddCreator("Juan Carlos Valderrama");
            // Abrimos el archivo
            doc.Open();
            doc.NewPage();
            Image logoYellow = Image.GetInstance(logoRoute);
            logoYellow.ScalePercent(20);
            logoYellow.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            doc.Add(logoYellow);
            doc.Add(new Paragraph(testCase));

            //Document documento = new Document();
            //FileStream archivoPDF = File.Create(@"..\00_Login_" + userLogInObject.TestCase + ".pdf");
            //PdfWriter.GetInstance(documento, archivoPDF);
            //documento.Open();
            //documento.NewPage();
            //Image logoYellow = Image.GetInstance(logoRoute);
            //logoYellow.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            //documento.Add(logoYellow);
            //documento.Add(new Paragraph(""));
            //Paragraph texto = new Paragraph(testCase);
            //texto.Alignment = Element.ALIGN_LEFT;
            //documento.Add(texto);

            userLogIn.UserElement(driver).Clear();
            userLogIn.UserElement(driver).SendKeys(userLogInObject.UserName);

            userLogIn.UserPassword(driver).Clear();
            userLogIn.UserPassword(driver).SendKeys(userLogInObject.PasswordUser);
            userLogIn.UserPassword(driver).Submit();

            //userLogIn.LogIn(driver).Click();

            Thread.Sleep(sleepTimerSlow);
            //documento.Add(new Paragraph(""));
            doc.Add(new Paragraph("Entro Correctamente a la aolicacion Yellow Box"));
            //texto = new Paragraph("Entro Correctamente a la aolicacion Yellow Box");
            //texto.Alignment = Element.ALIGN_LEFT;
            //documento.Add(texto);

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();

            screenShot.SaveAsFile("imagenCaso" + testCase + ".png", ScreenshotImageFormat.Png);
            Image foto = Image.GetInstance("imagenCaso" + testCase + ".png");
            foto.ScalePercent(30);
            foto.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            //documento.Add(foto);
            doc.Add(foto);
            doc.Close();
            writer.Close();

            logInResult = true;

        }

        public IWebDriver InitializeTheBrowser (WebDriverObjects.UserLogInObjects browser)
        {
            IWebDriver driverBrowser = null;

            if (browser.Browser.Equals("Chrome"))
            {
                ChromeOptions options = new ChromeOptions();
                //Habilitar  Modo  incognito
                options.AddArguments("-incognito");
                //Deshabilitar infobars
                options.AddArgument("--disable-infobars");
                //Deshabilitar popup-blocking
                options.AddArguments("--disable-popup-blocking");

                driverBrowser = new ChromeDriver(@"C:\Driver", options);
            }

            if (browser.Browser.Equals("FireFox"))
            {
                driverBrowser = new FirefoxDriver();
            }

            if (browser.Browser.Equals("IE"))
            {
                driverBrowser = new InternetExplorerDriver();
            }

            driverBrowser.Navigate().GoToUrl(browser.Url);
            Thread.Sleep(2000);

            return driverBrowser;
       }

    }
}
