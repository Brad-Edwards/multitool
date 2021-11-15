using System;
using System.Security.Cryptography;

namespace com.atomiklabs.multitool.Data
{
    public class Generator
    {
        /// <summary>
        /// The set of alphabetic characters.
        /// </summary>
        private const string AlphaChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// The set of alpha-numeric characters.
        /// </summary>
        private const string AlphaNumericChars = AlphaChars + NumericChars;

        /// <summary>
        /// The set of numeric characters.
        /// </summary>
        private const string NumericChars = "1234567890";

        /// <summary>
        /// The set of characters for passwords.
        /// </summary>
        private const string PasswordChars = AlphaChars + NumericChars + SpecialChars;

        /// <summary>
        /// The set of password special characters.
        /// </summary>
        private const string SpecialChars = @" !""#$%&'()*+,-./:;<=>?@[\]^_`{|}~";

        /// <summary>
        /// Generates cryptographically secure random bytes.
        /// </summary>
        /// <param name="size">Number of bytes required.</param>
        /// <returns>An array with the requested number of random bytes.</returns>
        public static byte[] GetRandomBytes(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var bytes = new byte[size];
            rng.GetBytes(bytes);
            return bytes;
        }

        /// <summary>
        /// Creates a random alphanumeric string.
        /// </summary>
        /// <returns></returns>
        public static string GetRandomString()
        {
            throw new NotImplementedException();
        }

        public static string GetRandomAlphaString()
        {
            throw new NotImplementedException();
        }

        public static string GetRandomNumericString()
        {
            throw new NotImplementedException();
        }

        public static string GetRandomPasswordString()
        {
            throw new NotImplementedException();
        }
    }
}
