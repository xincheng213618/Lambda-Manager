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
            Filepath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\LambdaManager\\default.json";
        }

        public FileRegisterCode(string filepath)
        {
            Filepath = filepath;
        }

        public string GetRegisterCode()
        {
            return File.ReadAllText(Filepath);
        }

        public void SetRegisterCode(string registerCode)
        {
            File.WriteAllText(Filepath, registerCode);
        }
    }
}
