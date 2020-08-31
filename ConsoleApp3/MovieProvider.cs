using System.Collections.Generic;

namespace TechElevator.ConsoleApp
{
    public static class MovieProvider
    {
        public static IEnumerable<Movie> BuildMovieDatabase()
        {
            return new List<Movie>
            {
                new Movie(1, "Stellar Voyage I: Stop Motion Pictures") { 
                    HasKlingons = true,
                    HasLethalProbe = true,
                    NumSpaceBattles = 1,
                    CharacterDies = true
                },
                new Movie(2, "Stellar Voyage II: Khan Needs a Bath") {
                    NumSpaceBattles = 3,
                    CharacterDies = true,
                    IsGood = true,
                },
                new Movie(3, "Stellar Voyage III: What, the torpedo we made that reconstructs planets is a weapon?") {
                    AltTitle = "Stellar Voyage III: Grand Theft Starship",
                    NumSpaceBattles = 2,
                    CharacterDies = true,
                    HasKlingons = true,
                    ShipIsDestroyed = true
                },
                new Movie(4, "Stellar Voyage IV: Probes Designed to Communicate with Whales Probably Shouldn't Vaporize Oceans") {
                    AltTitle = "Stellar Voyage IV: Adventures in Swearing",
                    HasKlingons = true,
                    HasTimeTravel = true,
                    HasLethalProbe = true,
                    IsOnEarth = true,
                    ShipIsDestroyed = true,
                    IsGood = true,
                },
                new Movie(5, "Stellar Voyage V: The Enterprise Joins a Cult!") {
                    HasKlingons = true,
                    NumSpaceBattles = 2,
                },
                new Movie(6, "Stellar Voyage VI: Klingon Poetry Battles") {
                    HasKlingons = true,
                    NumSpaceBattles = 2,
                    HasBadFederation = true,
                    IsGood = true,
                },
                new Movie(7, "Stellar Voyage VII: Old Men Fighting on a Mountain") {
                    HasKlingons = true,
                    NumSpaceBattles = 1,
                    HasTimeTravel = true,
                    ShipIsDestroyed = true
                },
                new Movie(8, "Stellar Voyage VIII: Data Meets a Girl") {
                    NumSpaceBattles = 1,
                    HasTimeTravel = true,
                    IsOnEarth = true,
                    HasBorg = true,
                    IsGood = true,
                },
                new Movie(9, "Stellar Voyage IX: Bad Federation, No Twinkee") {
                    NumSpaceBattles = 1,
                    HasBadFederation = true
                },
                new Movie(10, "Stellar Voyage X: Romulans, I guess") {
                    NumSpaceBattles = 2,
                    HasRomulans = true
                },
                new Movie(11, "Stellar Voyage 2009: Have you seen our lens flare?")
                {
                    NumSpaceBattles = 3,
                    HasRomulans = true,
                    HasTimeTravel = true,
                    IsGood = true,
                },
                new Movie(12, "Stellar Voyage 2009-A: Let's Try Khan")
                {
                    AltTitle = "Khan really likes his torpedos",
                    NumSpaceBattles = 1,
                    HasBadFederation = true,
                    CharacterDies = true,
                },
                new Movie(13, "Stellar Voyage 2009-B: This is what happens when you have giant pylons holding your engines")
                {
                    NumSpaceBattles = 2,
                    HasBadFederation = true,
                    ShipIsDestroyed = true,
                }
            };
        }
    }
}
