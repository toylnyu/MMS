﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrayRabbit.MMS.WindowsForm
{
    public static class UserInfo
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public static int UserId { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public static string UserName { get; set; }
        /// <summary>
        /// 用户角色Id
        /// </summary>
        public static int RoleId { get; set; }
        /// <summary>
        /// 模块Id
        /// </summary>
        public static IEnumerable<int> Modules { get; set; }
    }
}