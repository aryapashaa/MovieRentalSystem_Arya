﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieRentalSystem_Arya.Models;

[Table("tb_ary_m_countries")]
public class Country
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("name"), MaxLength(50)]
    public string Name { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }

    // Cardinality
    [JsonIgnore]
    public ICollection<City>? Cities { get; set; }
}
