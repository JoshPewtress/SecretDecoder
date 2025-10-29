



public static class Encrypter
{
    public static string Encrypt(string input)
    {
        var encoded = input.Select((c, i) =>
        (char)(c + ( 2 * ( i + 1 ) ) )).ToList();

        return string.Join("", encoded);
    }

    public static string Decrypt(string input)
    {
        var decoded = input.Select((c, i) =>
        (char)( c - ( 2 * ( i + 1 ) ) )).ToList();

        return string.Join("", decoded);
    }
}