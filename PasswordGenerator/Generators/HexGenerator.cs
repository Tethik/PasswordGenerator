using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PasswordLib;

namespace PasswordGenerator.Generators
{
    class HexGenerator : IPasswordGenerator
    {
        public string generatePassword(short length)
        {
            String password = Password.GenerateHexadecimalPassword(length);
            Properties.Settings.Default.HexLength = length;
            return password;
        }

        public short getCachedLength()
        {
            return Properties.Settings.Default.HexLength;
        }
    }
}
