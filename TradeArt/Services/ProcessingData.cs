namespace TradeArt.Services
{
    public class ProcessingData : IProcessingData
    {
        public async IAsyncEnumerable<Task> FunctionAAsync(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                await FunctionBAsync(i);
                yield return Task.CompletedTask;
            }
        }

        public async Task<bool> FunctionBAsync(int data)
        {
            await Task.Delay(100);
            return true;
        }
    }
}
