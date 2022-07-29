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
            Filepath = "default.json";
        }

        public RegisterInfo GetRegisterInfo()
        {
            string result = File.ReadAllText(Filepath);
            if (result == null)
            {
                return null;
            }
            var config = JsonSerializer.Deserialize<Config>(result);
            if (config == null)
            {
                return null;
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
                    return null;
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
