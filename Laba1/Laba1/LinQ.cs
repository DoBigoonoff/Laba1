public class Linq
{
    List<string> list = new List<string>
    {
        "abc", "bcd", "cde", "def"
    };
    public void FirstElements()
    {
        var result = list.SelectMany(x => x, (str, ch) => (str, str.First())).Distinct().Reverse();
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}

