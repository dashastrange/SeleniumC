using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Selenium_Test 
{
    class FirstTestCase 
    {
static void Main(String[] args)
{
    IWebDriver driver = new ChromeDriver();
    driver.Url = "https://www.saucedemo.com";
}
    }
}