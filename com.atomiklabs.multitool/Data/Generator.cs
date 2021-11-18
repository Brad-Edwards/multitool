using System;
using System.Security.Cryptography;
using System.Text;

namespace com.atomiklabs.multitool.Data
{
    public class Generator
    {
        /// <summary>
        /// The set of lowercase and uppercase alphabetic characters.
        /// </summary>
        public const string AlphaChars = AlphaCharsLower + AlphaCharsUpper;

        /// <summary>
        /// The set of lowercase alphabetic characters.
        /// </summary>
        public const string AlphaCharsLower = "abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// The set of uppercase alphabetic characters.
        /// </summary>
        public const string AlphaCharsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// The set of alpha-numeric characters.
        /// </summary>
        public const string AlphaNumericChars = AlphaChars + NumericChars;

        /// <summary>
        /// The set of numeric characters.
        /// </summary>
        public const string NumericChars = "1234567890";

        /// <summary>
        /// The set of characters for passwords.
        /// </summary>
        public const string PasswordChars = AlphaChars + NumericChars + SpecialChars;

        /// <summary>
        /// The set of password special characters.
        /// </summary>
        public const string SpecialChars = @" !""#$%&'()*+,-./:;<=>?@[\]^_`{|}~";

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
        /// Creates a random alphanumeric string of a given
        /// length using all available char types.
        /// </summary>
        /// <param name="size">The size of of string to generate.</param>
        /// <returns>A string of random characters of the requested size</returns>
        public static string GetRandomString(int size)
        {
            var randomString = new StringBuilder();
            var validChars = AlphaChars + NumericChars + SpecialChars;
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                randomString.Append(validChars[random.Next(validChars.Length)]);
            }
            return randomString.ToString();
        }

        public static string GetRandomAlphaString(int size)
        {
            throw new NotImplementedException();
        }

        public static string GetRandomNumericString(int size)
        {
            throw new NotImplementedException();
        }

        public static string GetRandomPasswordString(int size)
        {
            throw new NotImplementedException();
        }
    }
}
