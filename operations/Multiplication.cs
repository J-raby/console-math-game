
namespace MatchGame.operations;

public class Multiplication : IOperation
{

    private int _result;
    private int _firstNumber;
    private int _secondNumber;
    public Multiplication(){
        Random randomGenerator = new();
         _firstNumber = randomGenerator.Next(0, 1000);
         _secondNumber = randomGenerator.Next(0, 1000);
        _result = _firstNumber * _secondNumber;
    }

    public int GetResult()
    {
        return _result;
    }

    public List<int> GetOperationNumbers()
    {
        List<int> operands = new();
        operands.Add(_firstNumber);
        operands.Add(_secondNumber);
        return operands;
    }
}