﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wireboy.Socket.P2PHome.Models
{
    public class ApplicationConfig
    {
        /// <summary>
        /// 服务器通讯端口号
        /// </summary>
        public int ServerPort { get; set; } = 3388;
        /// <summary>
        /// 服务器ip地址
        /// </summary>
        public string ServerIp { set; get; } = "39.105.115.162";
        /// <summary> 
        /// 本地服务端口号
        /// </summary>
        public int LocalPort { get; set; } = 3388;
        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServerName { set; get; } = "";
    }
}
