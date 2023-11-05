using System.ComponentModel.DataAnnotations;

namespace TobetoKurs.Models
{
    public class Customer
    {
        [Required, MaxLength(30)]
        public string Name { get; set; }
        [Required, MaxLength(30)]
        public string Surname { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
        [CreditCard]
        public string CreditCardNumber {  get; set; }
        [Phone]
        public string Phone {  get; set; }
        [EmailAddress]
        public string Email {  get; set; }
        [Url]
        public string LinkedinUrl {  get; set; }
        [RegularExpression("[a-z]{2}-[0-9]{4}-[5-9]{4}")]
        public string PostalCode {  get; set; }
        [StringLength(250, MinimumLength =30)]
        public string Address {  get; set; }
        [Required, StringLength(24,MinimumLength =8), Compare(nameof(RePassword))]
        public string Password {  get; set; }
        [Required, StringLength(24, MinimumLength = 8)]
        public string RePassword {  get; set; }


    }
}
