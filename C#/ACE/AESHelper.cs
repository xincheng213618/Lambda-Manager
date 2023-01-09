using ACE.Global;
using System.IO;

namespace ACE
{
    public class AESHelper
    {
        public IRegisterInfo iRegisterInfo;


        public AESHelper()
        {
            this.iRegisterInfo = new RegisterInfoReg();
        }

        public AESHelper(IRegisterInfo iRegisterInfo)
        {
            this.iRegisterInfo = iRegisterInfo;
        }

        public string EncryptFileName = "application.xml";
        public string DecryptFileName = "application.sys";

        public string Vector = "Grid";

        public bool Encrypt()
        {
            if (File.Exists(DecryptFileName))
                File.Delete(DecryptFileName);

            if (File.Exists(EncryptFileName))
            {
                var Registerinfo = iRegisterInfo.Get();
                if (Registerinfo==null) 
                    return false; 

                string RegisterCode = Registerinfo.GetMD5();
                byte[] bytes = AES_EnorDecrypt.AESEncrypt(File.ReadAllBytes(EncryptFileName), RegisterCode ?? string.Empty, Vector);

                using FileStream fs = new FileStream(DecryptFileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(bytes, 0, bytes.Length);
                return true;
            }
            return false;
        }

        public bool Encrypt(byte[] EncryptData)
        {
            var Registerinfo = iRegisterInfo.Get();
            if (Registerinfo == null) { return false; }
            string RegisterCode = Registerinfo.GetMD5();
            byte[] bytes = AES_EnorDecrypt.AESEncrypt(EncryptData, RegisterCode ?? string.Empty, Vector);

            if (File.Exists(DecryptFileName))
                File.Delete(DecryptFileName);
            using FileStream fs = new FileStream(DecryptFileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Write(bytes, 0, bytes.Length);
            return true;    
        }

        public byte[]? Decrypt()
        {
            if (DecryptFileName == null)
                return null;
            string RegisterCode = iRegisterInfo.Get()?.GetMD5(); 
            return AES_EnorDecrypt.AESDecrypt(File.ReadAllBytes(DecryptFileName), RegisterCode ?? string.Empty, Vector);
        }



    }
}
