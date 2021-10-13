using OpenQA.Selenium;

namespace UnitTestProject1.Pages
{
    public class PersonalLoanPage
    {
        public By LoanTermYears
        {
            get
            {
                return By.Id("cyears");
            }
        }

        public By LoanAmount
        {
            get
            {
                return By.Id("cloanamount");
            }
        }

        public By InterestRate
        {
            get
            {
                return By.Id("cinterestrate");
            }
        }

        public By CalculateButton
        {
            get
            {
                return By.XPath("//input[@value='Calculate']");
            }
        }

        public By MonthlyPay
        {
            get
            {
                return By.XPath("//h2[@class='h2result']");
            }
        }
    }
}
