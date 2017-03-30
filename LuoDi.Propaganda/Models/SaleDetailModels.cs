using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 销售明细
    /// SaleOrder 为 NULL 时, 为现金销售 */ 
    /// </summary>
    public class SaleDetailModels
    {
        public int SaleDetailId { get; set; }

        [DisplayName("产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("销售合同")]
        public int SaleOrderId { get; set; }
        public virtual SaleOrderModels SaleOrder { get; set; }

        [DisplayName("数量")]
        public int Quantity { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("价格")]
        public decimal Price { get; set; }

        [DisplayName("折扣")]
        public int Discount { get; set; } 
    }
}