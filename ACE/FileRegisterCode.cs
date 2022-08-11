using ACE.Global;
using System;
using System.IO;

namespace ACE
{
    /// <summary>
    /// 从文件中保存注册码
    /// </summary>
    public class FileRegisterCode : IRegisterCode
    {
        private string Filepath;

        public FileRegisterCode()
        {
            Filepath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\\Gird\\rarreg.key";
        }

        public FileRegisterCode(string filepath)
        {
            Filepath = filepath;
        }

        public string GetRegisterCode()
        {
            return File.ReadAllText(Filepath);
        }

        public void SetRegisterCode(RegisterInfo registerInfo)
        {
            File.WriteAllText(Filepath, registerInfo.MD5());
        }
    }
}
