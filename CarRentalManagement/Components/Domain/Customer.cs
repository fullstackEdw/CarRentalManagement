﻿namespace CarRentalManagement.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? DrivingLicense { get; set; }

        public List<Booking>? Bookings { get; set; }


        public string? Address { get; set; }

        public string? ContactNumber { get; set; }

        public string? EmailAddress { get; set; }

    }
}
