namespace CSharp
{

    public class Solution
    {

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