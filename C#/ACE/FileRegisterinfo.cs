using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ACE.Global
{
    public class FileRegisterinfo 
    {

        IRegisterCode registerCode;

        public FileRegisterinfo()
        {
            registerCode = new RegRegisterCode();
        }
        public FileRegisterinfo(IRegisterCode registerCode)
        {
            this.registerCode = registerCode;
        }

        public void SetIRegisterCode(IRegisterCode registerCode)
        {
            this.registerCode = registerCode;
        }

        public RegisterInfo GetRegisterInfo()
        {
            string result = registerCode.GetRegisterCode();
            if (!string.IsNullOrEmpty(result))
            {
                try
                {
                    return JsonSerializer.Deserialize<RegisterInfo>(Encoding.UTF8.GetString(Convert.FromBase64String(result))); 
                }
                catch { }
            }
            return null;
        }

        public void SetRegisterInfo(RegisterInfo registerInfo)
        {
            registerCode.SetRegisterCode(registerInfo.ToBase64());
        }
    }
}
