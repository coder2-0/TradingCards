using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        private List<Player> players;
        private List<Player> filteredPlayers;

        public Form1()
        {
            InitializeComponent();
            InitializePlayers();
            PopulatePlayerList();
        }

        private void InitializePlayers()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagesPath = Path.Combine(basePath, "Images");

            players = new List<Player>
            {
                new Player("Lionel Messi", "Inter Miami", Path.Combine(imagesPath, "messi.jpg"), "Forward", 50, 20, 60),
                new Player("Cristiano Ronaldo", "Al Nassr", Path.Combine(imagesPath, "ronaldo.jpg"), "Forward", 45, 15, 55),
                new Player("Kylian Mbappé", "PSG", Path.Combine(imagesPath, "mbappe.jpg"), "Forward", 40, 18, 50),
                new Player("Neymar Jr.", "Al Hilal", Path.Combine(imagesPath, "neymar.jpg"), "Forward", 30, 25, 45),
                new Player("Kevin De Bruyne", "Man City", Path.Combine(imagesPath, "debruyne.jpg"), "Midfielder", 15, 30, 40),
                new Player("Erling Haaland", "Man City", Path.Combine(imagesPath, "haaland.jpeg"), "Forward", 60, 10, 50),
                new Player("Virgil van Dijk", "Liverpool", Path.Combine(imagesPath, "vandijk.jpg"), "Defender", 5, 2, 40),
                new Player("Mohamed Salah", "Liverpool", Path.Combine(imagesPath, "salah.jpg"), "Forward", 35, 20, 50),
                new Player("Luka Modrić", "Real Madrid", Path.Combine(imagesPath, "modric.jpg"), "Midfielder", 10, 15, 45),
                new Player("Robert Lewandowski", "Barcelona", Path.Combine(imagesPath, "lewandowski.jpg"), "Forward", 55, 10, 50)
            };

            filteredPlayers = new List<Player>(players);
        }

        private void PopulatePlayerList()
        {
            listBoxPlayers.Items.Clear();
            foreach (var player in filteredPlayers)
            {
                listBoxPlayers.Items.Add(player.Name);
            }
        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPlayers.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < filteredPlayers.Count)
            {
                var selectedPlayer = filteredPlayers[selectedIndex];
                UpdateCard(selectedPlayer);
            }
        }

        private void UpdateCard(Player player)
        {
            pictureBoxPhoto.ImageLocation = player.PhotoPath;
            labelName.Text = $"Name: {player.Name}";
            labelTeam.Text = $"Team: {player.Team}";
            labelPosition.Text = $"Position: {player.Position}";
            labelGoals.Text = $"Goals: {player.Goals}";
            labelAssists.Text = $"Assists: {player.Assists}";
            labelAppearances.Text = $"Appearances: {player.Appearances}";

            panelCard.BackColor = GetTeamColor(player.Team);
            labelGoals.ForeColor = player.Goals > 30 ? Color.Green : Color.DarkRed;
            labelAssists.ForeColor = player.Assists > 15 ? Color.Blue : Color.OrangeRed;
            labelAppearances.ForeColor = player.Appearances > 50 ? Color.Purple : Color.DarkGoldenrod;
        }

        private Color GetTeamColor(string team)
        {
            return team switch
            {
                "Man City" => Color.SkyBlue, 
                "Liverpool" => Color.Crimson, 
                "Barcelona" => Color.DarkSlateBlue, 
                "Inter Miami" => Color.LightPink, 
                "Al Nassr" => Color.Gold, 
                "PSG" => Color.MediumPurple, 
                "Al Hilal" => Color.CornflowerBlue, 
                "Real Madrid" => Color.WhiteSmoke, 
                _ => Color.LightGray, 
            };
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text.ToLower();
            filteredPlayers = players.Where(p => p.Name.ToLower().Contains(query) || p.Team.ToLower().Contains(query)).ToList();
            PopulatePlayerList();
        }
    }
}
