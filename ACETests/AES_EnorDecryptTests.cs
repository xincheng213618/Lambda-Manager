using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ACE.Tests
{
    [TestClass()]
    public class AES_EnorDecryptTests
    {
        [TestMethod()]
        public void AESEncryptTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AESEncryptTest1()
        {
            byte[] bytes = AES_EnorDecrypt.AESEncrypt(new byte[0], "Grid", "XIN");
            Assert.AreEqual(16, bytes.Length);
        }
    }
}