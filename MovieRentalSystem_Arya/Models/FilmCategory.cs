﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieRentalSystem_Arya.Models;

[Table("tb_ary_tr_filmcategories")]
public class FilmCategory
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("film_id")]
    public int FilmId { get; set; }
    [Required, Column("category_id")]
    public int CategoryId { get; set; }
    
    // Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(FilmId))]
    public Film? Film { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(CategoryId))]
    public Category? Category { get; set; }
}
