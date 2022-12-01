namespace Challenges.Util;

public static class ReaderExtensions
{
    public static string ReadNum(this StringReader s, int amount)
    {
        var result = "";
        for (int i = 0; i < amount; i++)
        {
            result += s.Read();
        }

        return result;
    }
}
