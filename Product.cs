namespace Stock_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ExportedItems = new HashSet<ExportedItem>();
            RemovedItems = new HashSet<RemovedItem>();
            TransferredItems = new HashSet<TransferredItem>();
            Warehouses = new HashSet<Warehouse>();
        }

        public int ID { get; set; }

        public long? Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? TotalItemPrice { get; set; }

        [StringLength(50)]
        public string Currency { get; set; }

        [StringLength(50)]
        public string MeasuringUnit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProdDate { get; set; }

        public decimal? ValidationPeriod { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AddedAt { get; set; }

        [StringLength(50)]
        public string ValidationPeriodType { get; set; }

        public string Notes { get; set; }

        public int? WarehouseID { get; set; }

        public int? SupplierId { get; set; }

        public int? SupplyOrderId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportedItem> ExportedItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemovedItem> RemovedItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferredItem> TransferredItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
