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
public class ProfileButtonRedirectOnlyRegistarLoginFormTest {
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
  public void profileButtonRedirectOnlyRegistarLoginForm() {
    driver.Navigate().GoToUrl("https://www.bogdanmebel.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
    var elements = driver.FindElements(By.LinkText("Профил"));
    Assert.True(elements.Count > 0);
    driver.FindElement(By.LinkText("Профил")).Click();
    driver.SwitchTo().Frame(1);
    Assert.That(driver.FindElement(By.CssSelector(".title")).Text, Is.EqualTo("РЕГИСТРИРАН КЛИЕНТ"));
    var elements = driver.FindElements(By.CssSelector(".btn > span"));
    Assert.True(elements.Count > 0);
    driver.Close();
  }
}