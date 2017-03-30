using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    public class CommonMenuModels
    {
        public int MenuId { get; set; }

        [DisplayName("菜单名称")]
        public string MenuName { get; set; }

        [DisplayName("菜单请求地址")]
        public string MenuAction { get; set; }
    }
}