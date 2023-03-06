public class ListSpiral
{
    public int number;
    List<string> list = new List<string>
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "g", "k", "l", "m", "n", "o", "p", "q"
        };
    public void Spiral()
    {

        do
        {
            try
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write(list[0]);
                    list.RemoveAt(0);
                }
            }
            catch { Environment.Exit(0); }
            Console.WriteLine();
            try
            {
                for (int i = number - 1; i > -1; i--)
                {
                    Console.Write(list[i]);
                    list.RemoveAt(i);
                }
            }
            catch
            {
                for (int i = list.Count - 1; i > -1; i--)
                {
                    Console.Write(list[i]);
                    list.RemoveAt(i);
                }
            }
            Console.WriteLine();
        } while (true);

    }
    public ListSpiral(int number)
    {
        this.number = number;
    }
}


