using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpNetCore 
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1");
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Mango");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            //Commented to write custom control code for combobox
            //IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            //comboControl.Clear();
            //comboControl.SendKeys("Almonds");
            //Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almonds']")).Click();

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");


            Assert.Pass();
        }
    }
}