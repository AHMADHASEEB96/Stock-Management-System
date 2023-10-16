namespace Stock_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supply")]
    public partial class Supply
    {
        public int Id { get; set; }

        public int? SupplierId { get; set; }

        public int? WarehouseId { get; set; }

        public int? ProductId { get; set; }

        [StringLength(50)]
        public string Date { get; set; }
    }
}
