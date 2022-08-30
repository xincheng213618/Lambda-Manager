using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ACE.Global
{
    public class FileRegisterinfo : IRegisterInfo
    {
        private string Filepath;

        public FileRegisterinfo()
        {
            Filepath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\LambdaManager\\" + "default.json";
        }

        public RegisterInfo? GetRegisterInfo()
        {
            if (!File.Exists(Filepath))
                return new RegisterInfo();
            string result = File.ReadAllText(Filepath);
            if (result == null)
            {
                return new RegisterInfo();
            }
            var config = JsonSerializer.Deserialize<Config>(result);
            if (config == null)
            {
                return new RegisterInfo();
            }
            else
            {
                try
                {
                    string RegisterInfostring = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(config.RegisterInfo));
                    var RegisterInfos = JsonSerializer.Deserialize<RegisterInfo>(RegisterInfostring);
                    return RegisterInfos;
                }
                catch
                {
                    return new RegisterInfo();
                }

            }
       
        }

        public void SetRegisterInfo(RegisterInfo registerInfo)
        {
            Config config = new Config() { RegisterInfo = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(JsonSerializer.Serialize(registerInfo, new JsonSerializerOptions()))) };
            string jsonString = JsonSerializer.Serialize(config);
            File.WriteAllText(Filepath, jsonString);
        }
    }
}
