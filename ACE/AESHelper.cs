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
            byte[] bytes = AES_EnorDecrypt.AESEncrypt(File.ReadAllBytes(FilePath), registerCode.GetRegisterCode(), "Grid");
            using (FileStream fs = new FileStream(FilePath.Replace(".xml",".sys"), FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        public byte[] Decrypt()
        {
            return AES_EnorDecrypt.AESDecrypt(File.ReadAllBytes(FilePath.Replace(".xml", ".sys")), registerCode.GetRegisterCode(), "Grid");
        }



    }
}
