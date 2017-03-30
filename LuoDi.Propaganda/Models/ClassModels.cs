using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 分类表
    /// </summary>
    public class ClassModels
    {
        public int ClassId { get; set; }

        [MaxLength(100)]
        [Required]
        [DisplayName("分类名称")]
        public int ClassName { get; set; }


        [DisplayName("上级分类ID")]
        public Nullable<int> ParentId { get; set; }
        [DisplayName("上级分类")]
        [ForeignKey("ParentId")]
        public virtual ClassModels Parent { get; set; }


        [DisplayName("创建时间")]
        public DateTime CreateDate { get; set; }

        [DisplayName("描述")]
        public string Remark { get; set; }
    }
}