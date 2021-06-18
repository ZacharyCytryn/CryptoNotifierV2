using System;
using System.ComponentModel.DataAnnotations;

namespace CryptoNotification.Models
{
    public class NotifierModel
    {
        [Key]
        public int NotifyID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Range(0, 1000000.00)]
        public decimal Price { get; set; }

        [Required]
        public string Direction { get; set; }

        [Required]
        public string Crypto { get; set; }
    }
}
