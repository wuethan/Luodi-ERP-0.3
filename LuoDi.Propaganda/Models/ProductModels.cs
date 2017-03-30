using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 产品目录
    /// </summary>
    public class ProductModels
    {
        public int ProductId { get; set; }

        [MaxLength(100)]
        [Required]
        [DisplayName("产品名称")]
        public string ProductName { get; set; }

        [MaxLength(50)]
        [Required]
        [DisplayName("产品代号")]
        public string ProductCode { get; set; }

        [DisplayName("品牌")]
        public int BrandId { get; set; }
        public virtual BrandModels Brand { get; set; }  

        [DisplayName("分类")]
        public int ClassId { get; set; }
        public virtual ClassModels Class { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("批发价")]
        public decimal LotPrice { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("零售价")]
        public decimal Price { get; set; }

        [DisplayName("创建时间")]
        public DateTime CreateDate { get; set; }

        [DisplayName("描述")]
        public string Remark { get; set; }


    }
}