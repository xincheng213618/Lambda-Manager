using System.IO;

namespace ACE
{
    public class AESHelper
    {
        public IRegisterCode registerCode;
        public string FilePath;

        public AESHelper()
        {
            registerCode = new ReadRegisterCode();
            FilePath = "application.xml";
        }

        public AESHelper(string filepath)
        {
            registerCode = new ReadRegisterCode();
            FilePath = filepath;
        }

        public void Encrypt()
        {
            string RegisterCode = registerCode.GetRegisterCode();
            byte[] bytes = AES_EnorDecrypt.AESEncrypt(File.ReadAllBytes(FilePath), RegisterCode, "Grid");
            using (FileStream fs = new FileStream(FilePath.Replace(".xml",".sys"), FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }   
        }

        public byte[] Decrypt()
        {
            string RegisterCode = registerCode.GetRegisterCode();
            byte[] bytes = File.ReadAllBytes(FilePath.Replace(".xml", ".sys"));
            return AES_EnorDecrypt.AESDecrypt(bytes, RegisterCode, "Grid");
        }



    }
}
