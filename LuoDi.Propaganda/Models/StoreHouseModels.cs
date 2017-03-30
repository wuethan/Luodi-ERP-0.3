using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 仓库
    /// </summary>
    public class StoreHouseModels
    {
        public int StoreHouseId { get; set; }

        [MaxLength(100)]
        [Required]
        [DisplayName("仓库名字")]
        public string StoreHouseName { get; set; }

        [DisplayName("创建时间")]
        public DateTime CreateDate { get; set; }

        [DisplayName("描述")]
        public string Remark { get; set; }
    }
}