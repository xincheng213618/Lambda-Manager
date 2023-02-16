using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ACE.Global
{
    public class RegisterInfoFile: IRegisterInfo
    {

        public static string FileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\default.gprj";
        public static string Key = "register-info";

        public RegisterInfo? Get()
        {
            if (!File.Exists(FileName))
                File.Create(FileName);
            string result = File.ReadAllText(FileName);
            JsonObject lamdbda = (JsonObject)JsonNode.Parse(result);

            string base64 = lamdbda?[Key]?.ToString();
            if (string.IsNullOrEmpty(base64)) return null;
            string info = Encoding.UTF8.GetString(Convert.FromBase64String(base64));
            if (string.IsNullOrEmpty(info)) return null;
            return JsonSerializer.Deserialize<RegisterInfo>(info);
        }

        public void Set(RegisterInfo registerInfo)
        {
            if (!File.Exists(FileName))
                File.Create(FileName);
            string result = File.ReadAllText(FileName);
            JsonObject lamdbda = (JsonObject)JsonNode.Parse(result);
            lamdbda![Key] = registerInfo?.ToBase64();
            File.WriteAllText(FileName, lamdbda.ToJsonString());
        }
    }
}
