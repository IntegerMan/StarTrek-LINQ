using System;

namespace TechElevator.ConsoleApp
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string AltTitle { get; internal set; }

        public bool HasKlingons { get; set; }
        public bool HasRomulans { get; set; }
        public bool CharacterDies { get; set; }
        public bool HasTimeTravel { get; set; }
        public bool HasBadFederation { get; set; }
        public bool ShipIsDestroyed { get; set; }
        public bool HasLethalProbe { get; set; }
        public bool IsOnEarth { get; set; }
        public bool HasBorg { get; set; }
        public bool IsGood { get; set; }

        public int NumSpaceBattles { get; set; }
        public int NumSpaceWhales { get; set; }

        public Movie(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
