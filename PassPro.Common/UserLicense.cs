using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassPro.Common
{
    public static class UserLicense
    {
        //获取系统全局key
        public static string ApplicationLicense()
        {
            return ConfigurationManager.AppSettings.Get("UserLicense");
        }
    }
}
