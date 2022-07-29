using System.Text.Json.Serialization;

namespace ACE.Global
{

    /// <summary>
    /// 注册信息
    /// </summary>
    public class RegisterInfo : ViewModelBase
    {

        public void SetValue(RegisterInfo registerInfo)
        {
            this.UserName = registerInfo.UserName;
            this.RegistrationDate = registerInfo.RegistrationDate;
            this.RegisteredAddress = registerInfo.RegisteredAddress;
            this.ExpirationDate =registerInfo.ExpirationDate;
            this.Email = registerInfo.Email;
            this.PhoneNumber = registerInfo.PhoneNumber;
        }

        private string userName = string.Empty;
        /// <summary>
        /// 用户名
        /// </summary>
       [JsonPropertyName("name")]
        public string UserName
        {
            get { return userName; }
            set { userName = value; NotifyPropertyChanged(); }
        }

        private string registrationDate = string.Empty;

        
        /// <summary>
        /// 注册日期
        /// </summary>
        [JsonPropertyName("create_date")]
        public string RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; NotifyPropertyChanged(); }
        }


        private string registeredAddress = string.Empty;

        /// <summary>
        /// 注册地址
        /// </summary>
        [JsonPropertyName("legal_address")]
        public string RegisteredAddress
        {
            get { return registeredAddress; }
            set { registeredAddress = value; NotifyPropertyChanged(); }
        }

        private string expirationDate = string.Empty;
        /// <summary>
        /// 失效日期
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; NotifyPropertyChanged(); }
        }

        private string email = string.Empty;
        /// <summary>
        /// 注册邮件地址
        /// </summary>
        [JsonPropertyName("email_address")]
        public string Email
        {
            get { return email; }
            set { email = value; NotifyPropertyChanged(); }
        }

        private string phoneNumber = string.Empty;
        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonPropertyName("contact_number")]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; NotifyPropertyChanged(); }
        }

        public override string ToString()
        {
            return $"{UserName},{RegistrationDate},{RegisteredAddress},{ExpirationDate},{Email},{PhoneNumber}";
            //return $"{UserName},{RegisteredAddress},{ExpirationDate}";
        }


        public string GetSha512()
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(this.ToString());
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
   
    }
}
