using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Threading;

namespace YellowBox_TestAut
{
    class Evidence
    {
        public enum TimerSleepType
        {
            sleepTimerMinimum = 1500,
            sleepTimerFast = 2500,
            sleepTimerMedium = 3500,
            sleepTimerSlow = 5000,
            sleepTimerLoad = 6500
        };

        public void ObtenerEvidenciaCaso(IWebDriver driver, Document doc, string EncabezadoEvidencia, string testCase)
        {
            string logoRoute = Path.GetFullPath("\\Users\\User\\Documents\\4.- Proyectos\\Yellow Box\\logo.png");
            int sleepTimerSlow = 7000;
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document();
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"..\00_Login_" + userLogInObject.TestCase + ".pdf", FileMode.Create));
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

            Thread.Sleep(sleepTimerSlow);
            //documento.Add(new Paragraph(""));
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
        }
    }
}
