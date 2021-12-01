using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC
{
    public class TokenActions : ITokenActions
    {
       private readonly List<char> charsToRemove = new List<Char> { '4', '_',  };

        public bool TokenReturnsEmptyString(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return true;
            }
            int four = token.Count(f => f == '4');
            int underscore  = token.Count(f => f == '_');


            return (four+underscore) == token.Length;
        }

        public int LenthOfString(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return 0;
            }

            return token.Length;
        }

        public string ChangeDollarToPoundSign(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return token;
            }

            return token.Replace("$", "£"); ;
        }

        public string RemoveDuplicateCharacters(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return String.Empty;
            }

            return new string(token.ToCharArray().Distinct().ToArray());
        }


        public string RemoveUnderscoresAndNumberFour(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return String.Empty;
            }

            charsToRemove.ForEach(c => token = token.Replace(c.ToString(), String.Empty));
            return token;
            
        }
        public string TruncateTokenToFifteenChars(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return String.Empty;
            }

            return token.Length > 15 ? token[..15] : token;
        }
    }
}
