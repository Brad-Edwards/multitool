using NUnit.Framework;
using com.atomiklabs.multitool.Data;
using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace com.atomiklabs.multitool.Data.Tests
{
    /// <summary>
    /// Tests for the <see cref="Generator"/> class.
    /// </summary>
    /// <remarks>
    /// These tests do not check the degree of randomness of the strings.
    /// 
    /// Modifications will be required every time a new group of characters is
    /// added to <see cref="Generator"/>.
    /// 
    /// This is not high risk code at the moment, so the test effort is low.
    /// This will need revisiting if Generator becomes key to anything important.
    /// </remarks>
    [TestFixture()]
    public class GeneratorTests
    {
        /// <summary>
        /// Should return an array of bytes of the requested size.
        /// </summary>
        /// <remarks>
        /// Currently not checking if method is failing by always sending back
        /// arrays full of the same value or ordered values.
        /// </remarks>       
        [Test()]
        [Author("Brad-Edwards")]
        public void GetRandomBytesTest()
        {
            byte[] bytes = null;
            for (var i = 0; i < 1000; i++)
            {
                bytes = Generator.GetRandomBytes(i);
                Assert.True(bytes.Length == i);
            }
        }

        /// <summary>
        /// Should return a random string using all available char
        /// types of the specified length.
        /// </summary>
        [Test()]
        [Author("Brad-Edwards")]
        public void GetRandomStringTest()
        {
            for (var i = 0; i < 1000; i++)
            {
                var randomString = Generator.GetRandomString(i);
                Assert.True(randomString.GetType() == typeof(String));
                Assert.True(randomString.Length == i);
            }
        }

        /// <summary>
        /// Should return a random string of the requested length
        /// consisting only of alphabetic chars.
        /// </summary>
        [Test()]
        [Author("Brad-Edwards")]
        public void GetRandomAlphaStringTest()
        {
            for (var i = 0; i < 1000; i++)
            {
                var randomString = Generator.GetRandomAlphaString(i);
                Assert.True(randomString.GetType() == typeof(String));
                Assert.True(randomString.Length == i);
                Assert.AreEqual(randomString.IndexOfAny(Generator.NumericChars.ToCharArray()), -1);
                Assert.AreEqual(randomString.IndexOfAny(Generator.SpecialChars.ToCharArray()), -1);
            }
        }

        /// <summary>
        /// Should return a random string of the requested length
        /// consisting only of numeric chars.
        /// </summary>
        [Test()]
        [Author("Brad-Edwards")]
        public void GetRandomNumericStringTest()
        {
            for (var i = 0; i < 1000; i++)
            {
                var randomString = Generator.GetRandomNumericString(i);
                Assert.True(randomString.GetType() == typeof(String));
                Assert.True(randomString.Length == i);
                Assert.AreEqual(randomString.IndexOfAny(Generator.AlphaChars.ToCharArray()), -1);
                Assert.AreEqual(randomString.IndexOfAny(Generator.SpecialChars.ToCharArray()), -1);
            }
        }

        /// <summary>
        /// Should return a random string of the requested length
        /// consisting only of valid password chars.
        /// </summary>
        [Test()]
        [Author("Brad-Edwards")]
        public void GetRandomPasswordStringTest()
        {
            for (var i = 0; i < 1000; i++)
            {
                var randomString = Generator.GetRandomPasswordString(i);
                Assert.True(randomString.GetType() == typeof(String));
                Assert.True(randomString.Length == i);
            }
        }
    }
}