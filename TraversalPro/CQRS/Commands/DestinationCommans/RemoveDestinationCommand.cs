﻿namespace TraversalPro.CQRS.Commands.DestinationCommans
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int ıd)
        {
            Id = ıd;
        }
        public int Id { get; set; }
    }
}
