using System;
using System.ComponentModel.DataAnnotations;

namespace CryptoNotification.Models
{
    public class BuyerModel
    {
            [Key]
            public int BuyerID { get; set; }

            [Required]
            public string BuyerEmail { get; set; }

            [Required]
            [Range(0, 1000000.00)]
            public decimal BuyerCost { get; set; }

            [Required]
            public string Cryptocurrency { get; set; }
    }
}
