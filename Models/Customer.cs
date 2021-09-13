using System.ComponentModel.DataAnnotations;

namespace MyFirstMVCApp.Models
{
    public enum Title
    {
        Mr, Ms, Miss, Mrs, Mx, Dr
    }

    public class Customer
    {
        public int ID { get; set; }

        public Title? Title { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Address 1")]
        public string Address1 { get; set; }

        [MaxLength(30)]
        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        [MaxLength(30)]
        [Display(Name = "Address 3")]
        public string Address3 { get; set; }

        [MaxLength(30)]
        [Display(Name = "Address 4")]
        public string Address4 { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }

        [Required]
        [MaxLength(30)]
        public string Telephone { get; set; }

        public byte Age { get; set; }
    }
}