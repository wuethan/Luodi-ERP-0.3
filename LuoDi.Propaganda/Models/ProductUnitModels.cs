using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 产品 - 计量单位
    /// </summary>
    public class ProductUnitModels
    {
        public int ProductUnitId { get; set; }

        [DisplayName("产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("计量单位")]
        public int UnitId { get; set; }
        public virtual UnitModels Unit { get; set; }

        [DisplayName("计量单位参数")]
        public string UnitParam { get; set; }
    }
}