using OpenQA.Selenium;

namespace YellowBox_TestAut.WebDriversComponents.LogInObjects
{
    //Clase que crea los elementos del modulo de loguin
    class LogInElements
    {
        public IWebElement UserElement (IWebDriver driver)
        {
            IWebElement userTextBox = driver.FindElement(By.Id("UserName"));
            return userTextBox;
        }

        public IWebElement UserPassword (IWebDriver driver)
        {
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            return passwordTextBox;
        }

        public IWebElement LogIn (IWebDriver driver)
        {
            IWebElement LogInSession = driver.FindElement(By.ClassName("Submit"));
            return LogInSession;
        }
        //Agregar metodo para determianr si el acceso es exito
        //Agregar metodo para determinar si el usuario es correcto
        //Agregar metodo para determinar si es fallida la prueba
    }
}
