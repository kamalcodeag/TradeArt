using System.Security.Cryptography;

namespace TradeArt.Services
{
    public class FileService : IFileService
    {
        public byte[] CalculateHashedFile(string filePath, int chunkSize)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The file could not be found: " + filePath);
            }

            byte[] hash = new byte[0];

            using (SHA256 sha256 = SHA256.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    byte[] buffer = new byte[chunkSize];

                    int bytesRead;

                    while ((bytesRead = fileStream.Read(buffer, 0, chunkSize)) > 0)
                    {
                        hash = sha256.ComputeHash(buffer, 0, bytesRead);
                    }
                }
            }

            return hash;
        }
    }
}
