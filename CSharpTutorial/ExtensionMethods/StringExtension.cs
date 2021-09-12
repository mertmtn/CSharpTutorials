 

namespace StringExtension
{
    public static class StringExtension
    {
        public static int NumberOfCharacters(this string input)
        {
            return input.ToCharArray().Length;
        }

        public static int NumberOfWords(this string input)
        {
            char[] splitArray = { '.', ',', ';', ' ' };
            string[] stringArray= input.Split(splitArray);
            return stringArray.Length;
        }

        public static string ToUpperFirstCharacter(this string input)
        {
            if (input.Length>0)
            {
                char[] charArray = input.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                return new string(charArray);                  
            }
            return input;     
        }
    }
}
