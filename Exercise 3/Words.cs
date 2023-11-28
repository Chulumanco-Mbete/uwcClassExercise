namespace Exercise_3
{
    internal class Words
    {
        //My code solution
        public static string CapitalizeFirstWords(string inputString)
        {
            inputString = inputString.ToLower();//In Case if the entire string is in UpperCase then convert it into lower
            char[] words = inputString.ToCharArray();
            
            if (words.Length >= 1)// Handle the first letter in the string.
            {
                if (char.IsLower(words[0]))
                {
                    words[0] = char.ToUpper(words[0]);
                }
            }
            
            for (int i = 1; i < words.Length; i++)// Scan through the letters, checking for spaces ... Uppercase the lowercase letters following spaces.
            {
                if (words[i - 1] == ' ')
                {
                    if (char.IsLower(words[i]))
                    {
                        words[i] = char.ToUpper(words[i]);
                    }
                }
            }
            return new string(words);
        }

        //Allen's code solution
        /*public static string CapitalizeFirstLetter(string stringValue)
        {
            string returnString = "";
            string[] words = stringValue.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                char firstChar = char.ToUpper(word[0]);
                returnString += firstChar;

                for (int j = 1; j < word.Length; j++) 
                {
                    char currentChar = word[j];
                    returnString += currentChar;
                }

                returnString += " ";
            }

            return returnString;
        }*/
    }
}
