using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieRentalSystem_Arya.ViewModels;

public class RegisterVM
{
    public int Id { get; set; }
    public int? PaymentId { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [MaxLength(1, ErrorMessage = "Ex : 0/1"), MinLength(1, ErrorMessage = "Ex : 0/1")]
    public string Active { get; set; }
    [StringLength(255, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    public string Password { get; set; }
    [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
    public DateTime LastUpdate { get; set; }
    public string? PictureUrl { get; set; }
    public int AddressId { get; set; }
    public int StoreId { get; set; }
}
