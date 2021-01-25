namespace calculator
{
    public class CalculateFeeFrom20250101 :ICalculate
    {
        public decimal CalculateSomeFee(CalculateFeeModel model)
        {
            return model.AnotherValue * model.SomeOtherValue * model.SomeValue;
        }
    }
}
