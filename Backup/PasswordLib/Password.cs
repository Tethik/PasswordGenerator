using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace PasswordLib
{
    public class Password
    {
        private static char[] AllowedCharacters = GetAllowedCharacters();

        public static char[] GetAllowedCharacters()
        {
            List<char> allowed = new List<char>();            
            allowed.AddRange("!#$%&");
            for (char c = '('; c < 127; c++)
                if(c != '`')
                    allowed.Add(c);

            return allowed.ToArray();
        }

        public static string GeneratePassword()
        {
            return GeneratePassword(8);
        }

        public static string GeneratePassword(int length)
        {           
            StringBuilder builder = new StringBuilder();
            RNGCryptoServiceProvider RandGenerator = new RNGCryptoServiceProvider();

            byte[] data = new byte[length];

            RandGenerator.GetBytes(data);

            while (length-- > 0)
            {
                builder.Append(AllowedCharacters[data[length] % AllowedCharacters.Length]);
            }

            return builder.ToString();
        }

    }
}
