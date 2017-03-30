using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 产品 - 规格
    /// </summary>
    public class ProductSpecModels
    {
        public int ProductSpecId { get; set; }

        [DisplayName("产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("规格")]
        public int SpecId { get; set; }
        public virtual SpecModels Spec { get; set; }

        [DisplayName("规格参数")]
        public string SpecParam { get; set; }
    }
}