using System.IO;

namespace ACE
{
    public class AESHelper
    {
        public IRegisterCode registerCode;

        public AESHelper()
        {
            registerCode = new FileRegisterCode();
        }

        public void Encrypt()
        {
            byte[] bytes = AES_EnorDecrypt.AESEncrypt(File.ReadAllBytes("application.xml"), registerCode.GetRegisterCode(), "Grid");
            using (FileStream fs = new FileStream("application.sys", FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        public byte[] Decrypt()
        {
            return AES_EnorDecrypt.AESDecrypt(File.ReadAllBytes("application.sys"), registerCode.GetRegisterCode(), "Grid");
        }



    }
}
