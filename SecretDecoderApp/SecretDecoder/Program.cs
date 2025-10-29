



public static class Encrypter
{
    public static string Encrypt(string input)
    {
        var encoded = input.Select((c, i) =>
        (char)(c + ( 2 * ( (i + i + 1) - 2 ) ))).ToList();

        return string.Join("", encoded);
    }
}