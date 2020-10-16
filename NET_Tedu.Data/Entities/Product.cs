﻿using NET_Tedu.Data.Enums;
using NET_Tedu.Data.Interfaces;
using NET_Tedu.Infrastructure.ShareKanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace NET_Tedu.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {

        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryID { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }

        [Required]
        public decimal OriginalPrice { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }

        [StringLength(255)]
        public int? ViewCount { get; set; }
        public string Tags { get; set; }
        public string Unit { get; set; }


        [ForeignKey("CategoryID")]
        //Khóa ngoại
        public virtual ProductCategory ProductCategory { get; set;  }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public Status Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModified { get; set; }
        public string SeoPageTitle { get; set; }

        [StringLength(255)]
        public string SeoAlias { get; set; }

        [StringLength(255)]
        public string SeoKeywords { get; set; }

        [StringLength(255)]
        public string SeoDescription { get; set; }
    }
}
