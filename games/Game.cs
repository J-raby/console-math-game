using MatchGame.operations;

namespace MathGame.games;

public enum GameResult
{
    Success,
    Fail    
}

public class Game
{
    private GameResult _gameResult;
    private readonly IOperation _operation;
    private string _userInput;
    public Game(IOperation operation, string userInput)
    {
        _operation = operation;
        _userInput = userInput;
        _gameResult = (_operation.GetResult() == int.Parse(userInput)) ? GameResult.Success : GameResult.Fail;
    }

    public GameResult GetGameResult()
    {
        return _gameResult;
    }

    public string GetUserInput()
    {
        return _userInput;
    }

}