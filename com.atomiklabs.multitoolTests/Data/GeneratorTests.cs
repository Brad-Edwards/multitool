using NUnit.Framework;
using com.atomiklabs.multitool.Data;
using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace com.atomiklabs.multitool.Data.Tests
{
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

        [Test()]
        [Author("Brad-Edwards")]
        public void GetRandomStringTest()
        {
            Assert.Fail();
        }

        [Test()]
        [Author("Brad-Edwards")]
        public void GetRandomAlphaStringTest()
        {
            Assert.Fail();
        }

        [Test()]
        [Author("Brad-Edwards")]
        public void GetRandomNumericStringTest()
        {
            Assert.Fail();
        }

        [Test()]
        [Author("Brad-Edwards")]
        public void GetRandomPasswordStringTest()
        {
            Assert.Fail();
        }
    }
}