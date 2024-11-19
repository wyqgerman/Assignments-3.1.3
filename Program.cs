namespace Assignments_3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string: ");
            string input = Console.ReadLine();

            int spaceCount = CountSpaces(input);

            Console.WriteLine($"\"{input}\" contains {spaceCount} spaces.");
        }

        static int CountSpaces(string str)
        {
            int count = 0;

            foreach (char ch in str)
            {
                if (ch == ' ')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
