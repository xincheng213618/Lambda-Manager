using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace ACE.Tests
{
    [TestClass()]
    public class SNCodeTests
    {
        [TestMethod()]
        public void GetSNTest()
        {
            Dictionary<string,object> data = new Dictionary<string,object>();

            SNCode code = new SNCode();
            for (int i = 0; i < 10000; i++)
            {

                for (int j = 0; j < 10000; j++)
                {
                    code.AreaCode = i.ToString();
                    data.Add(code.GetSN(), code);
                }
            }



        }
    }
}