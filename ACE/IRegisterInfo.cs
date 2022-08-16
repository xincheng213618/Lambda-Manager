using ACE.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE
{
    public interface IRegisterInfo
    {
        void SetRegisterInfo(RegisterInfo  registerInfo);
        RegisterInfo? GetRegisterInfo();
    }
}
