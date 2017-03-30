using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    public class CommonInfoModels
    {
        public int InfoId { get; set; }

        [MaxLength(100)]
        [Required]
        [DisplayName("信息标题")]
        public string InfoTile { get; set; }

        [DisplayName("信息发布时间")]
        public DateTime InfoReleaseTime { get; set; }

        [DisplayName("排序值")]
        public string InfoOrderVal { get; set; }

        [DisplayName("栏目")]
        public int ColumnId { get; set; }
        public virtual CommonColumnModels Column { get; set; }

        [DisplayName("信息内容")]
        public string InfoContent { get; set; }
    }
}