// See https://aka.ms/new-console-template for more information


public class Program
{
    public static void Main(string[] args)
    {
        string word = "java";
        string result = Convert.ToString(word);
        for (int i = word.Length-1; i >= 0 ; i--)
        {
            word = word.ToUpper();
            Console.Write(word[i]);

        }
        Console.Read();
    }
}