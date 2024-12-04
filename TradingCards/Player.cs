namespace TradingCards
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string PhotoPath { get; set; }
        public string Position { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Appearances { get; set; }

        public Player(string name, string team, string photoPath, string position, int goals, int assists, int appearances)
        {
            Name = name;
            Team = team;
            PhotoPath = photoPath;
            Position = position;
            Goals = goals;
            Assists = assists;
            Appearances = appearances;
        }
    }
}
