namespace CSharp
{

    public class Solution
    {
        static void Main(string[] args)
        {
            int testCaseOne = LengthOfLastWord("Hello World");
            // Expected 5
            Console.WriteLine(testCaseOne);

            int testCaseTwo = LengthOfLastWord("   fly me   to   the moon  ");
            // Expected 4
            Console.WriteLine(testCaseTwo);

            int testCaseOThree = LengthOfLastWord("luffy is still joyboy");
            // Expected 6
            Console.WriteLine(testCaseOThree);
        }

        public static int LengthOfLastWord(string s)
        {
            if (s.IndexOf(" ") != -1)
            {
                string trimmed = s.Trim();
                int lastSpace = trimmed.LastIndexOf(" ");

                return (trimmed.Length - 1) - lastSpace;
            }
            else
            {
                return s.Length;
            }
        }
    }
}