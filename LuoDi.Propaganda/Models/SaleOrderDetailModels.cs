using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 销售合同明细
    /// </summary>
    public class SaleOrderDetailModels
    {
        public int SaleOrderDetailId { get; set; }

        [DisplayName("销售合同")]
        public int SaleOrderId { get; set; }
        public virtual SaleOrderModels SaleOrder { get; set; }

        [DisplayName("产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("商品数量")]
        public int Quantity { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("商品进价")]
        public decimal Price { get; set; }
    }
}