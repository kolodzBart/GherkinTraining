using OpenQA.Selenium;

namespace UnitTestProject1.Pages
{
    public class PersonalLoanPage : BaseLoanPage
    {
        public By LoanTermYears
        {
            get
            {
                return By.Id("cyears");
            }
        }

        public By NumberOfMonths
        {
            get
            {
                return By.XPath("//td[contains(text(),'Loan Payment')]");
            }
         }
    }
}
