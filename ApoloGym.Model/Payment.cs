using System;
using System.ComponentModel.DataAnnotations;

namespace ApoloGym.Model
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        // Relación con User
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

    
        public Payment() { }

      
        public Payment(decimal amount, DateTime paymentDate, int userId)
        {
            Amount = amount;
            PaymentDate = paymentDate;
            UserId = userId;
        }
    }
}