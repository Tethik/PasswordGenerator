using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PasswordLib;

namespace PasswordGenerator.Generators
{
    class AsciiGenerator : IPasswordGenerator
    {
        public string generatePassword(short length)
        {
            String password = Password.GeneratePassword((int)length);
            Properties.Settings.Default.AsciiLength = (short)length;
            return password;
        }

        public short getCachedLength()
        {
            return Properties.Settings.Default.AsciiLength;
        }
    }
}
