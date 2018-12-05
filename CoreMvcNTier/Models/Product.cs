using CoreMvcNTier.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcNTier.Models
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        [DisplayName("ÜrünAdı")]
        public string ProductName { get; set; }
        [DisplayName("Fiyat")]
        public decimal ProductPrice { get; set; }
        [DisplayName("Stok  Adedi")]
        public decimal ProductStock { get; set; }
        [DisplayName("Görsel")]
        public string ProductImg { get; set; }

        [DisplayName("Marka")]
        public string ProductBrand { get; set; }

    }
}
