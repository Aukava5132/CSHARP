namespace Lab7p3;

public class BCipher : ICipher
{
    private const string alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

    public string Encode(string input)
    {
        return Transform(input);
    }

    public string Decode(string input)
    {
        return Transform(input);
    }

    private string Transform(string input)
    {
        string result = "";
        foreach (char c in input.ToUpper())
        {
            int index = alphabet.IndexOf(c);
            if (index == -1)
            {
                result += c;
            }
            else
            {
                int mirrorIndex = alphabet.Length - 1 - index;
                result += alphabet[mirrorIndex];
            }
        }
        return result;
    }
}