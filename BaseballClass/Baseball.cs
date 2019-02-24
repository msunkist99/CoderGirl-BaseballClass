using System;

namespace BaseballClass
{
    public class Baseball
    {
        public string playerFirstName { get; set; }
        public string playerLastName { get; set; }
        public int playerJerseyNumber { get; set; }
        public string playerBats { get; set; }

        public int playerGameHits { get; set; }
        public int playerGameRuns { get; set; }
        public int playerGameRBIs { get; set; }

        public int playerSeasonHits { get; set; }
        public int playerSeasonRuns { get; set; }
        public int playerSeasonRBIs { get; set; }
        public int playerSeasonGamesPlayed { get; set; }

        // run and RBI are not the same thing
        // run is when the player crosses home himself
        // rbi is when the player gets an hit and another player crosses home

        //  should we be tracking both runs and rbis at both the game and season level?

        public Baseball(string firstName, string lastName, int jerseyNumber, string bats)
        {
            playerFirstName = firstName;
            playerLastName = lastName;
            playerJerseyNumber = jerseyNumber;
            playerBats = bats;
        }

        public void RecordPlayerGameHitsRBIs(int hits, int rbis, int runs)
        {
            playerGameHits = hits;
            playerGameRuns = runs;
            playerGameRBIs = rbis;

            playerSeasonHits += hits;
            playerSeasonRuns += runs;
            playerSeasonRBIs += rbis;
        }
    }
}
