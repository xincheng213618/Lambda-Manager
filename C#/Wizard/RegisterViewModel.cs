using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wizard
{


    public class Request
    {

        private RegisterViewModel registerInfo = new RegisterViewModel();
        public RegisterViewModel RegisterInfo
        {
            get { return registerInfo; }
            set
            {
                registerInfo = value;
            }
        }

        private string sn= "abcdefghijklmnopqrstuvwx";
        public string SN
        {
            get { return sn; }
            set
            {
                sn = value;
            }
        }

        private string macAddress= "add44444";

        public string MacAddress
        {
            get { return macAddress; }
            set
            {
                macAddress = value;
            }

        }

        public string equipId= "012345678901234567890123";
        public string EquipID
        {
            get { return equipId; }
            set
            {
                equipId = value;
            }

        }




        
    }

    public class RegisterViewModel
    {
        private string name = "用户名";
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
        private string legalAddress = "注册地址";
        public string LegalAddress
        {
            get { return legalAddress; }
            set
            {
                legalAddress = value;
                NotifyPropertyChanged("LegalAddress");
            }
        }

        private string emailAddress = "注册邮件地址";
        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                emailAddress = value;
                NotifyPropertyChanged("EmailAddress");
            }
        }
        private string contactNumber = "联系电话";
        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                contactNumber = value;
                NotifyPropertyChanged("ContactNumber");
            }
        }
        private string sn1 = "0123456";
        public string SN1
        {
            get { return sn1; }
            set
            {
                sn1 = value;
                NotifyPropertyChanged("SN1");
            }
        }
        private string sn2 = "0123456";
        public string SN2
        {
            get { return sn2; }
            set
            {
                sn2 = value;
                NotifyPropertyChanged("SN2");
            }
        }
        private string sn3 = "0123456";
        public string SN3
        {
            get { return sn3; }
            set
            {
                sn3 = value;
                NotifyPropertyChanged("SN3");
            }
        }
        private string sn4 = "0123456";
        public string SN4
        {
            get { return sn4; }
            set
            {
                sn4 = value;
                NotifyPropertyChanged("SN4");
            }
        }
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Private Helpers

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }

    public class RegisterBack
    {
        [JsonPropertyName("state")]
        public int State { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("userClass")]
        public int UserClass { get; set; }
        [JsonPropertyName("feature-list")]
        public string FeatureList { get; set; }

    }




}
