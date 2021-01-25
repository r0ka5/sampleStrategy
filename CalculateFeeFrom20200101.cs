using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class CalculateFeeFrom20200101 : ICalculate
    {
        public decimal CalculateSomeFee(CalculateFeeModel model)
        {
            return model.AnotherValue + model.SomeOtherValue;
        }
    }
}
