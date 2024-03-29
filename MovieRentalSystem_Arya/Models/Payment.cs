﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieRentalSystem_Arya.Models;

[Table("tb_ary_tr_payments")]
public class Payment
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("amount", TypeName = "numeric(19,0)")]
    public int Amount { get; set; }
    [Required, Column("payment_date")]
    public DateTime PaymentDate { get; set; } = DateTime.Now;
    [Required, Column("rental_id")]
    public int RentalId { get; set; }
    [Required, Column("customer_id")]
    public int CustomerId { get; set; }
    [Required, Column("staff_id")]
    public int StaffId { get; set; }

    // Cardinality
    
    [JsonIgnore]
    [ForeignKey(nameof(CustomerId))]
    public Customer? Customer { get; set; }

    // Relation

    [JsonIgnore]
    public Staff? Staff { get; set; }
    [JsonIgnore]
    public Rental? Rental { get; set; }
}