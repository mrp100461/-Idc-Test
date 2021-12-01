using System.Collections.Generic;
using System.Diagnostics;

namespace IDC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new Dictionary<string,string>();
            Console.WriteLine("To stop enter empty line");
            string userInput = Console.ReadLine();
            while (userInput != string.Empty)
            {
                var changedstring = CheckString(userInput);
                list.Add(userInput,changedstring);
                Console.WriteLine("Please add another string");
                userInput = Console.ReadLine();
            }

            foreach (var pair in list)
            {
                Console.WriteLine($"Original: {pair.Key}, changed: {pair.Value}") ;
            }
            Console.ReadKey();
        }
        
        private static string CheckString(string token)
        {
            try
            {
                ITokenActions tokenActions = new TokenActions();
                if (tokenActions.LenthOfString(token)== 0)
                {
                    return "Invalid String";
                }

                if (tokenActions.TokenReturnsEmptyString(token))
                {
                       return "Invalid String";
                }

                var result =  tokenActions.RemoveUnderscoresAndNumberFour(token);
                result = tokenActions.ChangeDollarToPoundSign(result);
                result = tokenActions.RemoveDuplicateCharacters(result);
                result = tokenActions.TruncateTokenToFifteenChars(result);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}

