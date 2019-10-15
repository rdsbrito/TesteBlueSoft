using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Xunit;
using TesteBlueSoft.src;
using OpenQA.Selenium.Support.UI;

namespace TesteBlueSoft.src
{
    public class Teste : IClassFixture<WebDriverConfig>
    {
        WebDriverConfig web;
        WebDriverWait waiter;

        public Teste(WebDriverConfig webDriverConfig)
        {
            this.web = webDriverConfig;
        }

        [Fact]
        public void LocalizaLivros()
        {
            //Acessar o site submarino
            web.driver.Navigate().GoToUrl("https://www.submarino.com.br");

            //pesquisar por livros
            web.driver.FindElement(By.CssSelector("#h_search-input")).SendKeys("Livros");

            web.driver.FindElement(By.CssSelector("#tsf > div:nth-child(2) > div.A8SBwf > div.FPdoLc.VlcLAe > center > input.gNO89b")).Submit();


           // web.waiter.Until(ExpectedConditions.ElementToBeClickable(By.Id("h_menu"))).Click();
            //web.driver.FindElement(By.XPath(@"//*[@id='h_menu']/div/div/div/div/div[2]/ul/li[2]/a")).Click();
        }
               
    }
}
