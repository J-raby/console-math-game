namespace MatchGame.operations;
public interface IOperation
{
    public int GetResult();
    public List<int> GetOperationNumbers();
    public string ShowOperation();
}