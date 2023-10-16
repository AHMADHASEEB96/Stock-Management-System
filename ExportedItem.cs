namespace Stock_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExportedItem
    {
        public int ProductId { get; set; }

        public int CustomerId { get; set; }

        public decimal? ExportedQuantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExportingDate { get; set; }

        public string Notes { get; set; }

        public int? ExprtedOrderId { get; set; }

        public int ID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
