using System.Text;

namespace DiamondKata
{
    public static class DiamondStringCreator
    {
        public static string Create(char maxLetter)
        {
            var result = new StringBuilder();

            maxLetter = char.ToUpper(maxLetter);

            for (var c = 'A'; c <= maxLetter; c++)
            {
                result.Append(GetLetterLine(maxLetter, c));
            }
            for (var c = (char)(maxLetter - 1); c >= 'A'; c--)
            {
                result.Append(GetLetterLine(maxLetter, c));
            }

            return result
                .Remove(result.Length - Environment.NewLine.Length, Environment.NewLine.Length)
                .ToString();
        }

        private static string GetLetterLine(char maxLetter, char currentLetter)
        {
            var result = new StringBuilder();

            var margin = maxLetter - currentLetter;
            var centrePadding = 2 * (currentLetter - 'A') - 1;

            result.Append(new string(' ', margin));

            result.Append(currentLetter);

            if (centrePadding > 0)
            {
                result.Append(new string(' ', centrePadding));
            }

            if (currentLetter > 'A')
            {
                result.Append(currentLetter);
            }

            result.Append(new string(' ', margin));

            result.Append(Environment.NewLine);

            return result.ToString();
        }
    }
}