namespace Collection_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word for reversed");
            string word = Console.ReadLine();
            Console.WriteLine($"original word : {word}  Reversed word :  {ReversedWord(word)}");
        }

        static string ReversedWord(string word)
        {
            string reversedWord = "";
            Stack<char> stack = new Stack<char>();
            foreach (char c in word)
            {
                stack.Push(c);
            }

            while (stack.Count > 0)
            {
                reversedWord += stack.Pop();

            }
            return reversedWord;

        }

    }
}
