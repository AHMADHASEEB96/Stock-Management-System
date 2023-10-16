namespace Stock_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RemovedItem")]
    public partial class RemovedItem
    {
        public int ID { get; set; }

        public long? Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        [StringLength(50)]
        public string Currency { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(50)]
        public string MeasuringUnit { get; set; }

        public DateTime? ProdDate { get; set; }

        public decimal? ValidationPeriod { get; set; }

        [StringLength(50)]
        public string ValidationPeriodType { get; set; }

        public string Notes { get; set; }

        public int? WarehouseID { get; set; }

        public int? SupplierId { get; set; }

        public int? SupplyOrderId { get; set; }

        public DateTime AddedAt { get; set; }

        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
