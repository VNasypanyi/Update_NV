using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Update_NV
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://nuget-tutorial.net/en/tutorial/100010/package-manager-ui";
        }
    }
}
