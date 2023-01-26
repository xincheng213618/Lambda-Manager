using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ACE
{
    public class SNCode
    {
        private static readonly string publicKeyXml = "<RSAKeyValue><Modulus>5sf/agoe+/hryIfvt7v6o9aNldWSkUoPkW6se8VbEo7B4JBT0vIUQqku635RU+0vhaF/IJ7TQw6pYerHacA83XYBy90KEN4twOBs1Gy3XfEBcjYheQO919Hif1gENzqzQEg47G36VdmWzmhjreq2YQQQN+p/ezIbYtrPXGNU4fE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private static readonly string privateKeyXml = "<RSAKeyValue><Modulus>5sf/agoe+/hryIfvt7v6o9aNldWSkUoPkW6se8VbEo7B4JBT0vIUQqku635RU+0vhaF/IJ7TQw6pYerHacA83XYBy90KEN4twOBs1Gy3XfEBcjYheQO919Hif1gENzqzQEg47G36VdmWzmhjreq2YQQQN+p/ezIbYtrPXGNU4fE=</Modulus><Exponent>AQAB</Exponent><P>/OfgYc6H7sSiFUrwkTVtQEyuSm309+Whwuvuul/3zLkNJlvorGC2D5ksTz3Q0XFehHWgWNc0jQ3MRyKp2EHxgw==</P><Q>6ZrTQbe25FVr92pxAlBeO1iONdbLRM+/VmuwrZVgeHvu++8ChAidQT13rcVfqvLDuGq5/q2bgQgmraqdgRNIew==</Q><DP>0sEQ1bDcyncGcyQOMZQKRSkhnVjgaaztDpi6Sooq4GndsXep/+xgC8Ojjy1+VOtazpuPUjmUy28SKr2SOGtLrQ==</DP><DQ>b7mMsDGdVzdDm+Fciy7E4r1HxpgkP5TcfgijR2HZ8cXUVsnI+jzkeP9c7c8oIipZUSo6KoP9i4jKduTSz5jZYQ==</DQ><InverseQ>2kXWXpMpHplGwG/eHR17tVNyfaxjl2Hu2QWnlg5Jf/vLDMcA9MspGS5mS5uCNTTPh34T9PEtmCdA5L5i8kakwg==</InverseQ><D>EmVOzr0PyzX6IXn0ecjaKcUodBEaJcqpgwY3aYZJxCjs+2GFzQLO6qFhxBPFl9MIPrao04jVfjrk9ZEpZByWvUmq79tlzpBjeZW2wcjeUrZYK0/b0D7NRelf6InSJaOb9QKw/hhSPsl3x+nXPyhUFfz6q8bThGDSriC/eb3aSyE=</D></RSAKeyValue>";


        /// <summary>
        /// 区域编码 
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// 分销商编码  
        /// </summary>
        public string DistributorCode { get; set; }

        /// <summary>
        /// 有效期信息
        /// </summary>
        public string ValidityPeriod { get; set; }

        /// <summary>
        /// 统一设备号 
        /// </summary>
        public string EquipIdentify { get; set; }


        public string GetSN()
        {
            string  SN = Create(AreaCode + ";" + DistributorCode + ";" + ValidityPeriod + ";" + EquipIdentify + ";");
            MD5 md5 = MD5.Create();
            byte[] hashByte = md5.ComputeHash(Encoding.UTF8.GetBytes(SN));
            return BitConverter.ToString(hashByte).Replace("-", "")[..24];
        }

        public static string Create(string MachineCode) => Sign(MachineCode, privateKeyXml);

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="PrivateKey"></param>
        /// <returns></returns>
        public static string Sign(string Text, string PrivateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(PrivateKey);
            return Convert.ToBase64String(rsa.SignData(Encoding.UTF8.GetBytes(Text), "MD5"));
        }




    }
}
