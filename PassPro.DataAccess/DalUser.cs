using PassPro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PassPro.Common;

namespace PassPro.DataAccess
{
    public class DalUser
    {
        /// <summary>
        /// 通过用户名获取用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public user GetUserByUserName(string userName)
        {
            var userEntity = DB.Context.From<user>().Where(f => f.email == userName || f.phone == userName).First();
            return userEntity;
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user">用户</param>
        public OperateStatus CreateUser(user user)
        {
            OperateStatus status = new OperateStatus();
            user.id = Guid.NewGuid().ToString();
            try
            {
                DB.Context.Insert<user>(user);
                status.Success = true;
                status.Message = "注册成功";
            }
            catch (Exception ex)
            {
                status.Success = false;
                status.Message = ex.Message;
            }
            return status;
        }
    }
}
