using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 进货合同
    /// </summary>
    public class BuyOrderModels
    {
        public int BuyOrderId { get; set; }

        [DisplayName("合同签订日期")]
        public DateTime WriteDate { get; set; }

        [DisplayName("合同生效日期")]
        public DateTime InsureDate { get; set; }

        [DisplayName("合同到期日期")]
        public DateTime EndDate { get; set; }

        [DisplayName("供应商")]
        public int SupplierId { get; set; }
        public virtual SupplierModels Supplier { get; set; } 
    }
}