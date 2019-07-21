namespace OnlineShopWebApp.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stock
    {
        public int ID { get; set; }

        public int? ProductID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }

        [StringLength(50)]
        public string InvoiceNo { get; set; }

        public int? SupplierID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ManufacturedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpireDate { get; set; }

        public int? Quantity { get; set; }

        public double? UnitPrice { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public int? MRP { get; set; }

        public int? CustomerID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SalesDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
