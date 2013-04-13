using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    /// <summary>
    /// Basic interface for password generators to use.
    /// 
    /// // Maybe cache should be implemented automagically instead...
    /// </summary>
    interface IPasswordGenerator
    {
        /// <summary>
        /// Generate a password
        /// </summary>
        /// <param name="length">The length of the new password</param>
        /// <returns></returns>
        String generatePassword(short length);

        /// <summary>
        /// Return the cached password length
        /// </summary>
        /// <returns></returns>
        short getCachedLength();
    }
}
