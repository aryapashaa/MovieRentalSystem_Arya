using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieRentalSystem_Arya.Models;

[Table("tb_ary_tr_rentals")]
public class Rental
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("rental_date")]
    public DateTime RentalDate { get; set; } = DateTime.Now;
    [Column("return_date")]
    public DateTime? ReturnDate { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("staff_id")]
    public int StaffId { get; set; }
    [Required, Column("customer_id")]
    public int CustomerId { get; set; }
    [Required, Column("inventory_id")]
    public int InventoryId { get; set; }

    // Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(CustomerId))]
    public Customer? Customer { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(InventoryId))]
    public Inventory? Inventory { get; set; }

    // Relation
    [JsonIgnore]
    public ICollection<Payment>? Payments { get; set; }
    [JsonIgnore]
    public Staff? Staff { get; set; }
}
