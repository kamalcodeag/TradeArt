namespace TradeArt.Services
{
    public interface IProcessingData
    {
        IAsyncEnumerable<Task> FunctionAAsync(int count);
        Task<bool> FunctionBAsync(int data);
    }
}
