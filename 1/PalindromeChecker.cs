
namespace Practics1
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            if (input == null || input.Equals(""))
            {
                return false;
            }
            string s = new string(input.ToCharArray()
                .Where(c => Char.IsAsciiLetter(c))
                .ToArray());
           
            s = s.ToLower();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string s2 = new string(charArray);

            Console.WriteLine(s);
            Console.WriteLine(s2);
            
            if (s2 == s) { 
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
