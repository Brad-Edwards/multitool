using System.Linq;
using System.Security.Cryptography;

namespace com.atomiklabs.multitool.Data
{
    public class Generator
    {
        /// <summary>
        /// The set of alphabetic characters.
        /// </summary>
        private const string _alphaChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// The set of alpha-numeric characters.
        /// </summary>
        private const string _alphaNumericChars = _alphaChars + _numericChars;

        /// <summary>
        /// The set of numeric characters.
        /// </summary>
        private const string _numericChars = "1234567890";

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
        /// Creates a random string.
        /// </summary>
        /// <returns></returns>
        public static string GetRandomString()
        {
            var random = new System.Random();
            return new string(Enumerable.Repeat(_alphaNumericChars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
