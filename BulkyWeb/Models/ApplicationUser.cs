using BulkyWeb.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostCode { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public Company Company { get; set; }


    }
}
