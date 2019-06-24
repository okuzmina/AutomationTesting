using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace LessonSelenium
{
    [TestFixture]
    class Selenium
    {
        private ChromeDriver _driver;
        private readonly By _inputField = By.CssSelector("#keycode-text");
        private readonly By _okButton = By.CssSelector("#okay");
        private readonly By _confirmButton = By.XPath("//form[@class='ng-pristine ng-valid']//button[@id='confirm']");
        private readonly By _acceptCheckbox = By.XPath("//span[@class='checkmark']");
        private readonly By _continueButton = By.XPath("//button[@class='btn btn-secondary btn-lg']");
        private readonly By _startButton = By.CssSelector("#startExamButton");
        private readonly By _finishExamButton = By.CssSelector("#finishExamButton");
        private readonly By _finishConfirmButton = By.CssSelector("#details-incorrect");
        private readonly By _finishConfirmButton2 = By.CssSelector("#details-return");

       [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }

        [Test]
        public void SeleniumTest()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl("https://regression.surpass-preview.com/secureassess/htmldelivery/?isFake=true");

            var inputField = WaitElement(_inputField);
            var okButton = WaitElement(_okButton);

            Assert.IsTrue(inputField.Displayed);
            Assert.IsTrue(okButton.Enabled);

            inputField.Clear();
            inputField.SendKeys("AUTO0002");

            okButton.Click();

            var confirmButton = WaitElement(_confirmButton);

            Assert.AreEqual(_driver.Url, "https://regression.surpass-preview.com/secureassess/htmldelivery/?isFake=true#!/confirmDetails");
            Assert.IsTrue(confirmButton.Enabled);

            confirmButton.Click();

            var acceptCheckbox = WaitElement(_acceptCheckbox);
            var continueButton = WaitElement(_continueButton);
           
            Assert.AreEqual(_driver.Url, "https://regression.surpass-preview.com/secureassess/htmldelivery/?isFake=true#!/agreeToTerms");
            Assert.IsTrue(acceptCheckbox.Displayed);
            Assert.IsTrue(continueButton.Enabled);

            acceptCheckbox.Click();
            continueButton.Click();

            var startButton = WaitElement(_startButton);
            Assert.AreEqual(_driver.Url, "https://regression.surpass-preview.com/secureassess/htmldelivery/?isFake=true#!/test/items");
            Assert.IsTrue(startButton.Enabled);

            startButton.Click();

            var finishExamButton = WaitElement(_finishExamButton);
            Assert.IsTrue(finishExamButton.Enabled);

            finishExamButton.Click();

            var finishConfirmButton = WaitElement(_finishConfirmButton);
            Assert.IsTrue(finishConfirmButton.Enabled);

            finishConfirmButton.Click();

            var finishConfirmButton2 = WaitElement(_finishConfirmButton2);
            Assert.IsTrue(finishConfirmButton2.Enabled);

            finishConfirmButton2.Click();
        }

        private IWebElement WaitElement(By elementLocator)
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(elementLocator))[0];
        }
    }
}
