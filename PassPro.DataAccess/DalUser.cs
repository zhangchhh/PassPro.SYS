using PassPro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
