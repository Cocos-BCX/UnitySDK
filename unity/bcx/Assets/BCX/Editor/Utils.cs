using System.IO;

public class Utils
{
    public static string PathCombine(string path, params string[] parts)
    {
        string s = path;
        foreach(var part in parts)
        {
            s = Path.Combine(s, part);
        }
        return s;
    }
}
