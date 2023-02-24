using System.Text;

namespace TradeArt.Extensions
{
    public static class StringExtension
    {
        public static string Invert(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException("Text cannot be null or empty: " + text);
            }

            int textLength = text.Length;
            char[] textArray = new char[textLength];

            for (int i = 0; i < textLength; i++)
            {
                textArray[i] = text[textLength - 1 - i];
            }

            string invertedText = new string(textArray);

            return invertedText;
        }

        public static string InvertBySpace(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException("Text cannot be null or empty: " + text);
            }

            string[] textArray = text.Split(' ');
            int textLength = textArray.Length;
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = textLength - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    stringBuilder.Append(textArray[i] + ' ');
                }
                else
                {
                    stringBuilder.Append(textArray[i]);
                }
            }

            string invertedText = stringBuilder.ToString();

            return invertedText;
        }
    }
}
