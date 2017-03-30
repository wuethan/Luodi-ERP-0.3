using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 出库单明细
    /// </summary>
    public class LeaveStockDetailModels
    {
        public int LeaveStockDetailId { get; set; }

        [DisplayName("出库单")]
        public int LeaveStockId { get; set; }
        public virtual LeaveStockModels LeaveStock { get; set; }

        [DisplayName("所出商品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("出库数量")]
        public int Quantity { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("出库价格")]
        public decimal Price { get; set; }

    }
}