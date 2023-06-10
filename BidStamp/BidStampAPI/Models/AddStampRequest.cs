﻿namespace BidStampAPI.Models
{
    public class AddStampRequest
    {
        public string StampTitle { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Year { get; set; }
        public string? Country { get; set; }
        public string? Condition { get; set; }
        public string? CatalogNumber { get; set; }
        public int? StartingBid { get; set; }
        public int? EndingBid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
