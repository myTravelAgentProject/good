﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime? EarlyCheckIn { get; set; }
        public DateTime? LateCheckOut { get; set; }
        public bool SeprateBeds { get; set; }
        public bool MultipleRooms { get; set; }
        public bool? HighFloor { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal CostPrice { get; set; }
        public int? BookingId { get; set; }
        public int NumOfAdults { get; set; }
        public int? NumOfKids { get; set; }
        public bool Status { get; set; }
        public decimal? NewPrice { get; set; }
        public bool? Change { get; set; }
        public int HotelId { get; set; }
        public string Comments { get; set; }
        public bool? IsImportant { get; set; }
        public decimal HotelPrice { get; set; }
        public bool? Porch { get; set; }
        public string? TypeOfRoom { get; set; }

        //[JsonIgnore]
        public virtual Customer Customer { get; set; }
        [JsonIgnore]
        public virtual Hotel Hotel { get; set; }
    }
}
