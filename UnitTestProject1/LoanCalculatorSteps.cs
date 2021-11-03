using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using UnitTestProject1.Pages;

namespace UnitTestProject1
{
    [Binding]
    public class LoanCalculatorSteps
    {
        private static CalculatorNet CalculatorNet { get; set; }

        [BeforeFeature]
        public static void BeforeAppFeature()
        {
            SeleniumHelper.Browser = new ChromeDriver();
            SeleniumHelper.Browser.Manage().Window.Maximize();
            CalculatorNet = new CalculatorNet();
        }

        [AfterFeature]
        public static void AfterAppFeature()
        {
            SeleniumHelper.Browser.Quit();
        }

        [When(@"the amount is set (.*)")]
        public void WhenTheAmountIsSet(string amount)
        {
            CalculatorNet.PersonalLoan.LoanAmount.Clear();
            CalculatorNet.PersonalLoan.LoanAmount.SendKeys("5000");
        }

        [When(@"the rait is set (.*)")]
        public void WhenTheRaitIsSet(string rait)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the loan term is set (.*)")]
        public void WhenTheLoanTermIsSet(string term)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the monthy pay is calculated (.*)")]
        public void ThenTheMonthyPayIsCalculated(string pay)
        {
            ScenarioContext.Current.Pending();
        }



        [Given(@"that the personal loan calculator is open")]
        public void GivenThatThePersonalLoanCalculatorIsOpen()
        {
            SeleniumHelper.Browser.Navigate().GoToUrl("https://www.calculator.net/personal-loan-calculator.html");
        }
        
        [When(@"the amount is set")]
        public void WhenTheAmountIsSet()
        {
            
        }
        
        [When(@"the rait is set")]
        public void WhenTheRaitIsSet()
        {
            CalculatorNet.PersonalLoan.InterestRate.Clear();
            CalculatorNet.PersonalLoan.InterestRate.SendKeys("5");
        }
        
        [When(@"the loan term is set")]
        public void WhenTheLoanTermIsSet()
        {
            CalculatorNet.PersonalLoan.LoanTermYears.Clear();
            CalculatorNet.PersonalLoan.LoanTermYears.SendKeys("5");
        }
        
        [When(@"I click the calculate button")]
        public void WhenIClickTheCalculateButton()
        {
            CalculatorNet.PersonalLoan.CalculateButton.Click();
        }
        
        [Then(@"the monthy pay is calculated")]
        public void ThenTheMonthyPayIsCalculated()
        {
            var pay = SeleniumHelper.Browser.FindElement(CalculatorNet.PersonalLoan.MonthlyPay).Text;
            //var message = "Expected: 95,59 but we get" + pay + months;
            Assert.IsTrue(pay.Contains("94.36"));
            Assert.IsNull(CalculatorNet.PersonalLoan.ErrorMessage.TryFindElement());
        }
        
        [Then(@"number sof months is correct")]
        public void ThenNumberSofMonthsIsCorrect()
        {
            var months = SeleniumHelper.Browser.FindElement(CalculatorNet.PersonalLoan.NumberOfMonths).Text;
            Assert.IsTrue(months.Contains("60"));
        }

        [Given(@"that the auto loan calculator is open")]
        public void GivenThatTheAutoLoanCalculatorIsOpen()
        {
            SeleniumHelper.Browser.Navigate().GoToUrl("https://www.calculator.net/auto-loan-calculator.html");
        }

        [When(@"the auto loan term is set")]
        public void WhenTheAutoLoanTermIsSet()
        {
            CalculatorNet.AutoLoan.LoanTermMonths.Clear();
            CalculatorNet.AutoLoan.LoanTermMonths.SendKeys("5");
        }

    }

}
