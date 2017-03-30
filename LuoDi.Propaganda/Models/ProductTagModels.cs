using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 产品 - 标签
    /// </summary>
    public class ProductTagModels
    {
        public int ProductTagId { get; set; }

        [DisplayName("产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("标签")]
        public int TagId { get; set; }
        public virtual TagModels Tags { get; set; } 
    }
}