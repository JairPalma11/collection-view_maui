using System;
namespace CollectionViewMAUI.Models
{
	public class MyContact
    {
		public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsFavorite { get; set; }
        public DateTime DateCreated { get; set; }
        public string Fullname => $"{FirstName} {LastName}";
    }
}

