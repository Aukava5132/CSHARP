namespace Lab7p3;

public class ACipher : ICipher
{
    private const string alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

    public string Encode(string input)
    {
        return Shift(input, 1);
    }

    public string Decode(string input)
    {
        return Shift(input, -1);
    }

    private string Shift(string input, int shift)
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
                int newIndex = (index + shift + alphabet.Length) % alphabet.Length;
                result += alphabet[newIndex];
            }
        }
        return result;
    }
}