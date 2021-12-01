using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC
{
    public interface ITokenActions
    {
        int LenthOfString(string token);
        string RemoveUnderscoresAndNumberFour(string token);
        bool TokenReturnsEmptyString(string token);
        string ChangeDollarToPoundSign(string token);
        string RemoveDuplicateCharacters(string token);
        string TruncateTokenToFifteenChars(string token);




    }
}
