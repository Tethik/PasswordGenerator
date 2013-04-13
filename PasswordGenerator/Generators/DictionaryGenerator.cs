using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PasswordLib;
using System.IO;

namespace PasswordGenerator.Generators
{
    class DictionaryGenerator : IPasswordGenerator
    {
        public string generatePassword(short length)
        {
            String password = "";
            try
            {
                password = Password.GenerateDictionaryPassword(Properties.Settings.Default.Dictionary, length);
                Properties.Settings.Default.DictionaryLength = length;             
            }
            catch (Exception)
            {
                if (Properties.Settings.Default.Dictionary == null || Properties.Settings.Default.Dictionary == "")
                    throw new Exception("Dictionary not set. You can set the dictionary under Settings");

                if (!File.Exists(Properties.Settings.Default.Dictionary))
                    throw new Exception("Dictionary does not exist!");
            }
            return password;
        }

        public short getCachedLength()
        {
            return Properties.Settings.Default.DictionaryLength;
        }
    }
}
