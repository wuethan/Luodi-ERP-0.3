using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 供应商
    /// </summary>
    public class SupplierModels
    {
        public int SupplierId { get; set; }

        [MaxLength(100)]
        [Required]
        [DisplayName("供应商名字")]
        public string SupplierName { get; set; }

        [MaxLength(300)]
        [Required]
        [DisplayName("地址")]
        public string Address { get; set; }

        [MaxLength(50)]
        [Required]
        [DisplayName("电话")]
        public string Phone { get; set; }

        [MaxLength(50)]
        [Required]
        [DisplayName("传真")]
        public string Fax { get; set; }

        [MaxLength(20)]
        [Required]
        [DisplayName("邮编")]
        public string PostalCode { get; set; }

        [MaxLength(20)]
        [Required]
        [DisplayName("联系人")]
        public string ConstactPerson { get; set; }
    }
}