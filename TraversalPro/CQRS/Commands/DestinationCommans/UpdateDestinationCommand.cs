﻿namespace TraversalPro.CQRS.Commands.DestinationCommans
{
    public class UpdateDestinationCommand
    {
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
    }
}
