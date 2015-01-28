using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriverTipoCambio
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias");

            var meses = driver.FindElementByName("mes");
            var opcionMeses = new SelectElement(meses);
            opcionMeses.SelectByValue("12");

            var anos = driver.FindElementByName("anho");
            var opcionAnos = new SelectElement(anos);
            opcionAnos.SelectByValue("2014");

            var consultar = driver.FindElementByName("B1");
            consultar.Click();

            var correo = driver.FindElementById("email");
            correo.SendKeys("berczeck69@gmail.com");

            var enviar = driver.FindElementByPartialLinkText("Enviar Correo");
            enviar.Click();

            driver.Navigate().Back();

            var descargar = driver.FindElementByLinkText("Descargar");
            descargar.Click();

            driver.Close();

        }
    }
}
