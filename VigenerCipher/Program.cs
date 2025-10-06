using VigenerCipher;
using static VigenerCipher.ProgramHelper;


Console.WriteLine("Welcome to vigener cipher");

Menu menuLoop = Menu.Other;
while (menuLoop != Menu.Exit)
{
    ProgramHelper.PrintMenu();
    menuLoop = ProgramHelper.MenuInputValidation(Console.ReadLine());

    if (menuLoop == Menu.Exit)
        break;

    ProgramHelper.PrintEnterText(menuLoop);
    string text = Console.ReadLine().ToUpper();
    if (!ProgramHelper.IsValidText(text))
    {
        Console.WriteLine("Text must be alphabetic only.");
        break;
    }


    ProgramHelper.PrintKeyText(menuLoop);
    string key = Console.ReadLine().ToUpper();
    if (!ProgramHelper.IsValidText(text))
    {
        Console.WriteLine("Text must be alphabetic only.");
        break;
    }

    switch (menuLoop)
    {
        case Menu.Encrypt:
            VigenerEncryption vigener = new VigenerEncryption(text, key);
            string e = vigener.Encrypt();
            Console.WriteLine($"Encrypted text: {e}");
            break;
        case Menu.Decrypt:
            VigenerDecryption vigenerDecryption = new VigenerDecryption(text, key);
            string d = vigenerDecryption.Decrypt();
            Console.WriteLine($"Decrypted text: {d}");
            break;
        default:
            break;
    }


}
