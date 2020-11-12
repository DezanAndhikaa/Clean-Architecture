using System;

namespace Domain.Entities
{
    public class Car
    {
        public Guid IdGuid { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public int CarSeat { get; set; }
        public long CarPrice { get; set; }
    }
}