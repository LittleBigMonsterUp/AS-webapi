using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASWebapi22.ViewModels
{
    public class Meassage
    {
        /// <summary>
        /// 接收API的状态
        /// </summary>
        public string statue { get; set; }
        /// <summary>
        /// 指示信息
        /// </summary>
        public string meassage { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string other { get; set; }
    }
}