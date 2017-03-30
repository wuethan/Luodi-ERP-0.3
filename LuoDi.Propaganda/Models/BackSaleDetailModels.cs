using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 退货单明细
    /// </summary>
    public class BackSaleDetailModels
    {
        public int BackSaleDetailId { get; set; }

        [DisplayName("退货单")]
        public int BackSaleId { get; set; }
        public virtual BackSaleModels BackSale { get; set; }

        [DisplayName("退货商品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("退货数量")]
        public int Quantity { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("价格")]
        public decimal Price { get; set; }
    }
}