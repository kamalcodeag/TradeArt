namespace TradeArt.Services
{
    public interface IFileService
    {
        byte[] CalculateHashedFile(string filePath, int chunkSize);
    }
}
