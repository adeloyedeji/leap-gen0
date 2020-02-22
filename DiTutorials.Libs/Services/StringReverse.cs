using DiTutorials.Libs.Contracts;

namespace DiTutorials.Libs.Services
{
    public class StringReverse : IReverse<string>
    {
        public string Reverse(string input)
        {
            string reverse = string.Empty;
            int startIndex = input.Length - 1; ///a = 0, b =  1, c = 2
            for(int i = startIndex; i >= 0; i--)
            {
                reverse += input[i];
            }
            return reverse;
        }
    }
}
