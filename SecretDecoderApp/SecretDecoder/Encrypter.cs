public static class Encrypter
{
    private static readonly int[ ] _pattern = { 2, 5, 3 };

    public static string Encrypt(string input)
    {
        var encoded = input.Select((c, i) =>
        (char)(c + _pattern[i % _pattern.Length])).ToList();

        return string.Join("", encoded);
    }

    public static string Decrypt(string input)
    {
        var decoded = input.Select((c, i) =>
        (char)(c - _pattern[i % _pattern.Length])).ToList();

        return string.Join("", decoded);
    }
}