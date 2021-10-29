using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using UnitTestProject1.Pages;

namespace UnitTestProject1
{
    [Binding]
    public class LoanCalculatorSteps
    {
        private PersonalLoanPage PersonalLoan { get; set;}
        private AutoLoanPage AutoLoan { get; set; }
        private SeleniumHelper SeleniumHelper { get; set; }

        [Given(@"that the personal loan calculator is open")]
        public void GivenThatThePersonalLoanCalculatorIsOpen()
        {
            SeleniumHelper = new SeleniumHelper();
            SeleniumHelper.Browser.Navigate().GoToUrl("https://www.calculator.net/personal-loan-calculator.html");
        }
        
        [When(@"the amount is set")]
        public void WhenTheAmountIsSet()
        {
            PersonalLoan = new PersonalLoanPage();
            SeleniumHelper.Browser.FindElement(PersonalLoan.LoanAmount).Clear();
            SeleniumHelper.Browser.FindElement(PersonalLoan.LoanAmount).SendKeys("5000");
        }
        
        [When(@"the rait is set")]
        public void WhenTheRaitIsSet()
        {
            SeleniumHelper.Browser.FindElement(PersonalLoan.InterestRate).Clear();
            SeleniumHelper.Browser.FindElement(PersonalLoan.InterestRate).SendKeys("5");
        }
        
        [When(@"the loan term is set")]
        public void WhenTheLoanTermIsSet()
        {
            SeleniumHelper.Browser.FindElement(PersonalLoan.LoanTermYears).Clear();
            SeleniumHelper.Browser.FindElement(PersonalLoan.LoanTermYears).SendKeys("5");
        }
        
        [When(@"I click the calculate button")]
        public void WhenIClickTheCalculateButton()
        {
            SeleniumHelper.Browser.FindElement(PersonalLoan.CalculateButton).Click();
        }
        
        [Then(@"the monthy pay is calculated")]
        public void ThenTheMonthyPayIsCalculated()
        {
            var pay = SeleniumHelper.Browser.FindElement(PersonalLoan.MonthlyPay).Text;
            //var message = "Expected: 95,59 but we get" + pay + months;
            Assert.IsTrue(pay.Contains("94.36"));
            
        }
        
        [Then(@"number sof months is correct")]
        public void ThenNumberSofMonthsIsCorrect()
        {
            var months = SeleniumHelper.Browser.FindElement(PersonalLoan.NumberOfMonths).Text;
            Assert.IsTrue(months.Contains("60"));
            SeleniumHelper.Browser.Quit();
        }

        [Given(@"that the auto loan calculator is open")]
        public void GivenThatTheAutoLoanCalculatorIsOpen()
        {
            SeleniumHelper = new SeleniumHelper();
            SeleniumHelper.Browser.Navigate().GoToUrl("https://www.calculator.net/auto-loan-calculator.html");
        }

        [When(@"the auto loan term is set")]
        public void WhenTheAutoLoanTermIsSet()
        {
            SeleniumHelper.Browser.FindElement(AutoLoan.LoanTermMonths).Clear();
            SeleniumHelper.Browser.FindElement(AutoLoan.LoanTermMonths).SendKeys("5");
        }

    }

}
