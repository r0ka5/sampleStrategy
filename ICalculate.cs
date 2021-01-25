using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public interface ICalculate
    {
        public decimal CalculateSomeFee(CalculateFeeModel model);
    }
}
