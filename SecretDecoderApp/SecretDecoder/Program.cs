UIHelper.Run();



public static class UIHelper
{
    public static void Run()
    {
        do
        {
            ShowMenu();
            MenuSelection(PromptUser("Select a Menu Option: "));
        }
        while (true);
    }

    private static string PromptUser(this string input)
    {
        Console.Write(input);
        return Console.ReadLine() ?? "";
    }

    private static void ShowMenu()
    {
        Console.WriteLine(
            $"""
            1 - Encrypt
            2 - Decrypt
            3 - Clear Console
            4 - Exit Application

            """);
    }

    private static void MenuSelection(string selection)
    {
        switch (selection)
        {
            case "1":
                Console.WriteLine(Encrypter.Encrypt(PromptUser("Enter words to Encrypt: ")));
                break;
            case "2":
                Console.WriteLine(Encrypter.Decrypt(PromptUser("Enter words to Decrypt: ")));
                break;
            case "3":
                Console.Clear();
                break;
            case "4":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine($"\"{selection}\" was not a valid menu option.\n");
                break;
        }
    }
}