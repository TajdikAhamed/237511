namespace OnlineShopWebApp.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Stocks = new HashSet<Stock>();
        }

        public int Id { get; set; }

        public int Code { get; set; }

        [StringLength(255)]
        public string ProductName { get; set; }

        public int? ReOrderQuantity { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? CategoryID { get; set; }

        public byte[] Image { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
