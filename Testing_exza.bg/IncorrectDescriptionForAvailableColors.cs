// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class IncorrectdescriptionforavailablecolorsTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void incorrectdescriptionforavailablecolors() {
    driver.Navigate().GoToUrl("https://www.exza.bg/");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
    driver.FindElement(By.XPath("//button[@id=\'yui_3_12_0_1_1680384860837_352\']")).Click();
    driver.FindElement(By.Id("mod1562search")).SendKeys("къса пола");
    driver.FindElement(By.XPath("//button[@id=\'yui_3_12_0_1_1680384860837_410\']")).Click();
    driver.FindElement(By.XPath("//a[contains(text(),\'Къса пола с колан в два цвята\')]")).Click();
    Assert.That(driver.Title, Is.EqualTo("Къса пола с колан в два цвята | ExXxtravaganza"));
    Assert.That(driver.FindElement(By.XPath("//a[contains(text(),\'Жълт\')]")).Text, Is.EqualTo("Жълт"));
    Assert.That(driver.FindElement(By.XPath("//a[contains(text(),\'Червен\')]")).Text, Is.EqualTo("Червен"));
    Assert.That(driver.FindElement(By.XPath("//a[contains(text(),\'Бежов\')]")).Text, Is.EqualTo("Бежов"));
    Assert.That(driver.FindElement(By.XPath("//a[contains(text(),\'Лилав\')]")).Text, Is.EqualTo("Лилав"));
    driver.Close();
  }
}
