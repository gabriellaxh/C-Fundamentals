using _03.DependencyInversion;

namespace P03_DependencyInversion
{
    public class PrimitiveCalculator
    {
        private bool isAddition;
        private bool isMultiplication;

        private AdditionStrategy additionStrategy;
        private SubtractionStrategy subtractionStrategy;
        private MultiplicationStrategy multiplicationStrategy;
        private DivisionStrategy divisionStrategy;

        public PrimitiveCalculator()
        {
            this.additionStrategy = new AdditionStrategy();
            this.subtractionStrategy = new SubtractionStrategy();
            this.multiplicationStrategy = new MultiplicationStrategy();
            this.divisionStrategy = new DivisionStrategy();
            this.isAddition = true;
            this.isMultiplication = false;
        }

        public void ChangeStrategy(char @operator)
        {
            switch (@operator)
            {

                case '+':
                    this.isAddition = true;
                    this.isMultiplication = false;
                    break;

                case '-':
                    this.isAddition = false;
                    this.isMultiplication = true;
                    break;

                case '*':
                    this.isAddition = true;
                    this.isMultiplication = true;
                    break;

                case '/':
                    this.isAddition = false;
                    this.isMultiplication = false;
                    break;
            }
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            if (this.isAddition)
            {
                if (this.isMultiplication)
                    return multiplicationStrategy.Calculate(firstOperand, secondOperand);
                else
                    return additionStrategy.Calculate(firstOperand, secondOperand);
            }
            else
            {
                if (!this.isMultiplication)
                    return divisionStrategy.Calculate(firstOperand, secondOperand);
                else
                    return subtractionStrategy.Calculate(firstOperand, secondOperand);
            }
        }
    }
}
