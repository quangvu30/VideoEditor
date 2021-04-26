using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Threading;

namespace VideoEditor.Controller
{
    class FireFoxController
    {
        private static FirefoxDriver driver;
        private static WebDriverWait wait;

        public FireFoxController()
        {
            InitDriver();
        }

        private static void InitDriver()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("--disable-notifiactions");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--allow-cross-origin-auth-prompt");
            options.AddArgument("no-sandbox");

            options.SetPreference("dom.webdriver.enabled", false);
            options.SetPreference("webdriver_enable_native_events", false);
            options.SetPreference("webdriver_assume_untrusted_issuer", false);
            options.SetPreference("media.navigator.permission.disabled", true);

            driver = new FirefoxDriver(service, options);
            driver.Manage().Window.Size = new System.Drawing.Size(800, 600);
            driver.Navigate().GoToUrl("https://translate.google.com/");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        public static void Translate(string filePath)
        {
            int timeout = 0;
            do
            {
                timeout++;
                try
                {
                    driver.ExecuteScript("document.getElementsByClassName('VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-INsAgc Rj2Mlf OLiIxf PDpWxe hL2wFc')[0].click();");
                    break;
                }
                catch { }
                Thread.Sleep(1000);
            } while (timeout < 10);
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector("div.hYXSWe input")).SendKeys(filePath);
            Thread.Sleep(1000);

            timeout = 0;
            do
            {
                timeout++;
                try
                {
                    driver.ExecuteScript("document.getElementsByClassName('VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ nCP5yc AjY5Oe DuMIQc')[0].click();");
                    break;
                }
                catch { }
                Thread.Sleep(1000);
            } while (timeout < 10);

            wait.Until(ExpectedConditions.ElementToBeClickable(By.TagName("pre")));
            File.WriteAllText("SubTranslated.srt", driver.FindElementByTagName("pre").Text);
            driver.Close();
            driver.Quit();
        }
    }
}
