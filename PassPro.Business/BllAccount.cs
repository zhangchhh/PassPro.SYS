using PassPro.Common;
using PassPro.DataAccess;
using PassPro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassPro.Business
{
    public class BllAccount
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="status">状态消息</param>
        /// <returns>用户</returns>
        public user Login(string username, string pwd,out OperateStatus status)
        {
            status = new OperateStatus();
            var userdal = new DalUser();
            //通过账号（邮箱/手机号）获取用户
            var userdata = userdal.GetUserByUserName(username);
            if (userdata == null)
            {
                status.Success = false;
                status.Message = "账号有误，请检查邮箱/手机号是否正确";
                return null;
            }
            //对用户密码进行解密并判断登录密码是否一致
            var license = UserLicense.ApplicationLicense();
            var pass = AESHelper.Decrypt(userdata.password, license);
            if (pwd != pass)
            {
                status.Success = false;
                status.Message = "密码有误，请检查";
                return null;
            }
            status.Success = true;
            status.Message = "登录成功";
            return userdata;
        }
    }
}
