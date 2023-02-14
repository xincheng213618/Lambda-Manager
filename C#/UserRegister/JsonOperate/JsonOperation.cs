using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UserRegister.JsonOperate
{
    public class RegisterInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        //public string CreateDate { get; set; }
        //public string ExpireDate { get; set; }
        [JsonPropertyName("legal_address")]
        public string LeaglAddress { get; set; }
        [JsonPropertyName("email_address")]
        public string EmailAddress { get; set; }
        [JsonPropertyName("contact_number")]
        public string ContactNumber { get; set; }
        [JsonPropertyName("sn")]
        public string SN { get; set; }
        [JsonPropertyName("sha")]
        public string SHA { get; set; } 

    }




    public class JsonOperation
    {
        public static RegisterInfo registerInfo = new RegisterInfo();
        public static void ReadDefaultConfig(string path)
        {
            string result = File.ReadAllText(path);
            JsonNode document = JsonNode.Parse(result)!;
            JsonNode root = document.Root;
            if (root["lambda-manager"] != null)
            {
                if (root["lambda-manager"]!["register-info"] != null)
                {
                    JsonNode RegisterInfo = root["lambda-manager"]!["register-info"]!;

                    if (RegisterInfo != null)
                    {
                        JsonNode sn = RegisterInfo["sn"];
                    }
                }
            }




        }

        public static RegisterInfo ReadRegisterNode(string path)
        {

            string result = File.ReadAllText(path);
            JsonObject defaultConfig = (JsonObject)JsonNode.Parse(result);
            JsonNode forecastNode = JsonNode.Parse(result)!;
            if (defaultConfig["lambda-manager"] != null)
            {
                if (defaultConfig["lambda-manager"]!["register-info"] != null)
                {
                    JsonObject register = forecastNode!["lambda-manager"]!["register-info"]!.AsObject();
                    using var stream = new MemoryStream();
                    using var writer = new Utf8JsonWriter(stream);
                    register.WriteTo(writer);
                    writer.Flush();
                    try
                    {
                        registerInfo =
                        JsonSerializer.Deserialize<RegisterInfo>(stream.ToArray());
                    }
                    catch
                    {

                    }

                }

            }
            return registerInfo;

        }

        public static void RegisterInfoWrite(RegisterInfo registerInfo, string Path)
        {
            var registerObj = new JsonObject
            {
                ["name"] = registerInfo.Name,
                ["legal_address"] = registerInfo.LeaglAddress,
                ["email_address"] = registerInfo.EmailAddress,
                ["contact_number"] = registerInfo.ContactNumber,
                ["sn"] = registerInfo.SN,
                ["sha"] = registerInfo.SHA,

            };

            string result = File.ReadAllText(Path);
            JsonObject defaultConfig = (JsonObject)JsonNode.Parse(result);
            if (defaultConfig["lambda-manager"] != null)
            {
                if (defaultConfig["lambda-manager"]!["register-info"] != null)
                {
                    JsonObject lambda = defaultConfig!["lambda-manager"]!.AsObject();
                    lambda.Remove("register-info");
                    defaultConfig["lambda-manager"]!["register-info"] = registerObj;

                }
                else
                {
                    defaultConfig["lambda-manager"]!["register-info"] = registerObj;
                }
                File.WriteAllText(Path, defaultConfig.ToJsonString());

            }

        }

    }
    
}
