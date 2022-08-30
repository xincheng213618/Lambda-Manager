using ACE.Global;
using System.IO;

namespace ACE
{
    public class AESHelper
    {
        public FileRegisterinfo fileRegisterinfo;

        public AESHelper(FileRegisterinfo fileRegisterinfo)
        {
            this.fileRegisterinfo = fileRegisterinfo;
        }
        public string EncryptFileName = "application.xml";
        public string DecryptFileName = "application.sys";
        public string Vector = "Grid";




        public bool Encrypt()
        {
            if (File.Exists(EncryptFileName))
            {
                var Registerinfo = fileRegisterinfo.GetRegisterInfo();
                if (Registerinfo==null) { return false; }
                string RegisterCode = Registerinfo.GetMD5();
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
            var Registerinfo = fileRegisterinfo.GetRegisterInfo();
            if (Registerinfo == null) { return false; }
            string RegisterCode = Registerinfo.GetMD5();
            byte[] bytes = AES_EnorDecrypt.AESEncrypt(EncryptData, RegisterCode ?? string.Empty, "Grid");

            if (File.Exists(DecryptFileName))
                File.Delete(DecryptFileName);
            using (FileStream fs = new FileStream(DecryptFileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            return true;    
        }

        public byte[]? Decrypt()
        {
            var Registerinfo = fileRegisterinfo.GetRegisterInfo();
            if (Registerinfo == null) { return null; }
            string RegisterCode = Registerinfo.GetMD5(); return AES_EnorDecrypt.AESDecrypt(File.ReadAllBytes(DecryptFileName), RegisterCode ?? string.Empty, "Grid");
        }



    }
}
