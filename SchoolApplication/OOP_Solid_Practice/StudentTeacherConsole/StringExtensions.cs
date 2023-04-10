namespace StringExtensionMethods
{
    public static class StringExtensions
    {
        public static string FirstLetterToCapitalAndOthersToLower(this string input)
        {
            if (!string.IsNullOrEmpty(input)) 
            {
                string output = input.ToLower();
                output = char.ToUpper(output[0]) + output.Substring(1);
                return output;
            }
            return input;
        }
    }
}
