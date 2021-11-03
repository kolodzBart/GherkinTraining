using OpenQA.Selenium;

namespace UnitTestProject1.Pages
{
    public class AutoLoanPage : BaseLoanPage
    {
        public By LoanTermMonths
        {
            get
            {
                return By.Id("cloanterm");
            }
        }
    }
}
