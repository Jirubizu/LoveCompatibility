namespace LoveCompatibility.Extension
{
    public static class StringExtensions
    {
        public static char GetNext(this string str, int pos)
        {
            return pos + 1 == str.Length ? str[0] : str[pos + 1];
        }

        public static char GetPrev(this string str, int pos)
        {
            return pos - 1 == -1 ? str[^1] : str[pos - 1];
        }
    }
}