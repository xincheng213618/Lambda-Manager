using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ACE.Global
{

    /// <summary>
    /// 注册信息
    /// </summary>
    public class RegisterInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        /// <summary>
        /// 用户名
        /// </summary>
        [JsonPropertyName("name")]
        public string UserName { get => _UserName; set { _UserName = value; NotifyPropertyChanged(); } }
        private string _UserName = string.Empty;
   
        /// <summary>
        /// 注册日期
        /// </summary>
        [JsonPropertyName("create_date")]
        public string RegistrationDate { get => _RegistrationDate; set { _RegistrationDate = value; NotifyPropertyChanged(); } }
        private string _RegistrationDate = string.Empty;
        

        /// <summary>
        /// 注册地址
        /// </summary>
        [JsonPropertyName("legal_address")]
        public string RegisteredAddress { get => _RegisteredAddress; set { _RegisteredAddress = value; NotifyPropertyChanged(); } }
        private string _RegisteredAddress = string.Empty;

        /// <summary>
        /// 失效日期
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpirationDate { get => _ExpirationDate; set { _ExpirationDate = value; NotifyPropertyChanged(); } }
        private string _ExpirationDate = string.Empty;


        /// <summary>
        /// 注册邮件地址
        /// </summary>
        [JsonPropertyName("email_address")]
        public string Email { get => _Email; set { _Email = value; NotifyPropertyChanged(); } }
        private string _Email = string.Empty;


        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonPropertyName("contact_number")]
        public string PhoneNumber { get => _PhoneNumber; set { _PhoneNumber = value; NotifyPropertyChanged(); } }
        private string _PhoneNumber = string.Empty;


        /// <summary>
        /// 注册码
        /// </summary>
        [JsonPropertyName("sn")]
        public string SN { get => _SN; set { _SN = value; NotifyPropertyChanged(); } }
        private string _SN = string.Empty;


        public override string ToString()
        {
            return $"{UserName},{RegistrationDate},{RegisteredAddress},{ExpirationDate},{Email},{PhoneNumber}";
        }

        public string ToBase64()
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(this, new JsonSerializerOptions())));
        }

        public string GetMD5()
        {
            byte[] hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(this.ToString()));
            return Convert.ToHexString(hashBytes); // .NET 5 +
        }
   
    }
}
