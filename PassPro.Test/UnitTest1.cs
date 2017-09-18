using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassPro.DataAccess;
using PassPro.Business;
using PassPro.Common;

namespace PassPro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BllAccount bll = new BllAccount();
            OperateStatus status;
            var result=bll.Login("admin", "123456", out status);
        }
    }
}
