using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.Pages
{
    public class CalculatorNet
    {
        public PersonalLoanPage PersonalLoan { get; set; }
        public AutoLoanPage AutoLoan { get; set; }

        public CalculatorNet()
        {
            PersonalLoan = new PersonalLoanPage();
            AutoLoan = new AutoLoanPage();
        }
    }
}
