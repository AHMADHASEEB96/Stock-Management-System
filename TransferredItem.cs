namespace Stock_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferredItem")]
    public partial class TransferredItem
    {
        public int ID { get; set; }

        public int? FromWh { get; set; }

        public int? ToWh { get; set; }

        public DateTime? TransferTime { get; set; }

        public decimal? Quantity { get; set; }

        public long? ProductsCode { get; set; }

        public int? ProductId { get; set; }

        public int? SupplierId { get; set; }

        public DateTime? SupplyTime { get; set; }

        public virtual Product Product { get; set; }
    }
}
