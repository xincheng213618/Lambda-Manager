using ACE.Global;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ACE
{
    public class ReadRegisterCode : IRegisterCode
    {
        private string Filepath;

        public ReadRegisterCode()
        {
            Filepath = "default.json";
            if (!File.Exists(Filepath))
            {
                File.WriteAllText(Filepath, JsonSerializer.Serialize(new Config(), new JsonSerializerOptions()));
            }
        }

        public ReadRegisterCode(string filepath)
        {
            Filepath = filepath;
        }

        public string GetRegisterCode()
        {
            string result = File.ReadAllText(Filepath);
            if (result == null)
            {
                return String.Empty;
            }
            var Config = JsonSerializer.Deserialize<Config>(result);
            if (Config == null)
            {
                return String.Empty;
            }
            string RegisterInfostring = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Config.RegisterInfo));
            var RegisterInfos = JsonSerializer.Deserialize<RegisterInfo>(RegisterInfostring);
            if (RegisterInfos ==null)
                return String.Empty;
            return RegisterInfos.GetSha512();
        }

        /// <summary>
        /// 此接口不提供读取操作
        /// </summary>
        public void SetRegisterCode(string Code)
        {
            throw new NotImplementedException();
        }
    }
}
