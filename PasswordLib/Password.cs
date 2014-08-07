﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Numerics;

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

            byte[] data = new byte[length + 1]; // +1 because of http://stackoverflow.com/questions/5649190/byte-to-unsigned-biginteger
            RandGenerator.GetBytes(data);
            data[length] = 0; // clear sign = make positive number
            var dataNum = new BigInteger(data); // from lowest-order byte [0] to highest-order byte [length+1]

            while (length-- > 0)
            {
                uint characterIndex = (uint)(dataNum % AllowedCharacters.Length);
                dataNum = dataNum / AllowedCharacters.Length;

                builder.Append(AllowedCharacters[characterIndex]);
            }

            return builder.ToString();
        }

        public static string GenerateDictionaryPassword(String filepath, int how_many_words)
        {
            FileInfo info = new FileInfo(filepath);
            RNGCryptoServiceProvider RandGenerator = new RNGCryptoServiceProvider();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < how_many_words; i++)
            {
                byte[] data = new byte[sizeof(long)];
                RandGenerator.GetBytes(data);
                ulong offset = BitConverter.ToUInt64(data, 0);
                offset = offset % (ulong) info.Length;

                FileStream stream = info.OpenRead();               
                
                // Move to new row or beginning.
                char c;
                while (offset > 0)
                {
                    stream.Seek((long)offset, SeekOrigin.Begin);
                    c = (char)stream.ReadByte();
                    if(c == '\n')
                        break;                    
                    offset--;
                }
                
                if(offset == 0)
                    stream.Seek((long)offset, SeekOrigin.Begin);
                
                // Read word                
                c = (char)stream.ReadByte();
                builder.Append(Char.ToUpper(c));
                while (stream.Position < info.Length)
                {
                    c = (char)stream.ReadByte();
                    if (c == '\r' || c == '\n')
                        break;
                    builder.Append(c);
                }
                

            }

            return builder.ToString();            
        }

        public static string GenerateHexadecimalPassword(int length)
        {
            StringBuilder builder = new StringBuilder();

            RNGCryptoServiceProvider RandGenerator = new RNGCryptoServiceProvider();
            byte[] data = new byte[length];
            RandGenerator.GetBytes(data);

            foreach (byte d in data)
                builder.Append(d.ToString("X"));

            return builder.ToString();
        }

    }
}
