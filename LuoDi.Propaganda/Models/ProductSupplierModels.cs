using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 产品 - 供应商
    /// </summary>
    public class ProductSupplierModels
    {
        public int ProductSupplierId { get; set; }

        [DisplayName("产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("供应商")]
        public int SupplierId { get; set; }
        public virtual SupplierModels Supplier { get; set; } 
    }
}