using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    public class BrandModels
    {
        public int BrandId { get; set; }

        [DisplayName("品牌名字")]
        public string BrandName { get; set; }

        [DisplayName("品牌描述")]
        public string Remark { get; set; }
    }
}