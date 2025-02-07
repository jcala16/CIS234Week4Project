using System;
using System.ComponentModel.DataAnnotations;

namespace CH04.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        [Required(ErrorMessage = "Date Added is required.")]
        public DateTime DateAdded { get; set; }

        public string Slug => $"{FirstName}-{LastName}".ToLower().Replace(" ", "-");
    }
}

