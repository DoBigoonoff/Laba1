using System.Text.Json;
public class Combinations
{
    static char[] a = new char[2] { 'A', 'a' };
    static char[] b = new char[2] { 'B', 'b' };
    Dictionary<int, char[]> symbols = new Dictionary<int, char[]>
    {
        {1,a},
        {2,b}
    };
    Dictionary<int, string> done = new Dictionary<int, string>();
    public void Combine()
    {
        for (int i = 0; i < 2; i++)
        {
            string a1 = "";
            for (int j = 0; j < 2; j++)
            {
                a1 += (Convert.ToString(symbols[1][i]) + Convert.ToString(symbols[2][j]));
            }
            done.Add(i, a1);
        }
    }
    public void Json()
    {
        string json = JsonSerializer.Serialize(done);
        string path = "/Users/dobbgoonoff/Downloads/1.txt";

        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine(json);
        }
    }
}
