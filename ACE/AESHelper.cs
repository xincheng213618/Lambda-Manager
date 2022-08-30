using System.IO;

namespace ACE
{
    public class AESHelper
    {
        public IRegisterCode registerCode;

        public AESHelper()
        {
            registerCode = new ReadRegisterCode();
        }
        public string EncryptFileName = "application.xml";
        public string DecryptFileName = "application.sys";
        public string Vector = "Grid";


        public AESHelper(string filepath)
        {
            registerCode = new ReadRegisterCode();
            EncryptFileName = filepath;
        }


        public bool Encrypt()
        {
            if (File.Exists(EncryptFileName))
            {
                string RegisterCode = registerCode.GetRegisterCode();
                byte[] bytes = AES_EnorDecrypt.AESEncrypt(File.ReadAllBytes(EncryptFileName), RegisterCode ?? string.Empty, Vector);
                if (File.Exists(DecryptFileName))
                    File.Delete(DecryptFileName);
                using FileStream fs = new FileStream(DecryptFileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(bytes, 0, bytes.Length);
                File.Delete(EncryptFileName);
                return true;
            }
            return false;

        }
        public bool Encrypt(byte[] EncryptData)
        {
            string RegisterCode = registerCode.GetRegisterCode();
            byte[] bytes = AES_EnorDecrypt.AESEncrypt(EncryptData, RegisterCode ?? string.Empty, "Grid");

            if (File.Exists(DecryptFileName))
                File.Delete(DecryptFileName);
            using (FileStream fs = new FileStream(DecryptFileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            return true;    
        }

        public byte[] Decrypt()
        {
            string RegisterCode = registerCode.GetRegisterCode();
            return AES_EnorDecrypt.AESDecrypt(File.ReadAllBytes(DecryptFileName), RegisterCode ?? string.Empty, "Grid");
        }



    }
}
