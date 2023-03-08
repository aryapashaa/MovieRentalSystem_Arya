using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieRentalSystem_Arya.Models;

[Table("tb_ary_m_inventories")]
public class Inventory
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("film_id")]
    public int FilmId { get; set; }

    // Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(FilmId))]
    public Film? Film { get; set; }

    // Relation
    [JsonIgnore]
    public ICollection<Rental>? Rentals { get; set; }
}
