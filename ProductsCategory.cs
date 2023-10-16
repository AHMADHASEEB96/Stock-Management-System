namespace Stock_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductsCategory")]
    public partial class ProductsCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatId { get; set; }

        [StringLength(50)]
        public string CatName { get; set; }
    }
}
