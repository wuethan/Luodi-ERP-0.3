using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 入库单明细
    /// </summary>
    public class EnterStockDetailModels
    {
        public int EnterStockDetailId { get; set; }

        [DisplayName("入库单")]
        public int EnterStockId { get; set; }
        public virtual EnterStockModels EnterStock { get; set; }

        [DisplayName("入库产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("商品数量")]
        public int Quantity { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("商品参考价")]
        public decimal Price { get; set; }

        [DisplayName("是否有发票")]
        public bool HaveInvoice { get; set; }

        [DisplayName("发票号")]
        public string InvoiceNum { get; set; }
    }
}