using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 销售
    /// </summary>
    public class SaleModels
    {
        public int SaleId { get; set; }

        [DisplayName("销售日期")]
        public DateTime SaleDate { get; set; }
    }
}