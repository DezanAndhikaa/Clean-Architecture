using System;

namespace Domain.Entities
{
    public class Customer
    {
        public Guid IdCustomer { get; set; }
        public string CustomerName { get; set; }
        public int CustomerGender { get; set; }
        public string CustomerPhone { get; set; }
    }
}