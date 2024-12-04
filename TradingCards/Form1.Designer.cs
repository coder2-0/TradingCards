namespace TradingCards
{
    partial class Form1
    {
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelGoals;
        private System.Windows.Forms.Label labelAssists;
        private System.Windows.Forms.Label labelAppearances;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelCard;

        private void InitializeComponent()
        {
            textBoxSearch = new System.Windows.Forms.TextBox();
            listBoxPlayers = new System.Windows.Forms.ListBox();
            panelCard = new System.Windows.Forms.Panel();
            pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            labelName = new System.Windows.Forms.Label();
            labelTeam = new System.Windows.Forms.Label();
            labelPosition = new System.Windows.Forms.Label();
            labelGoals = new System.Windows.Forms.Label();
            labelAssists = new System.Windows.Forms.Label();
            labelAppearances = new System.Windows.Forms.Label();

            SuspendLayout();

            // textBoxSearch
            textBoxSearch.Location = new System.Drawing.Point(12, 12);
            textBoxSearch.Size = new System.Drawing.Size(200, 23);
            textBoxSearch.PlaceholderText = "Search...";
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;

            // listBoxPlayers
            listBoxPlayers.Location = new System.Drawing.Point(12, 45);
            listBoxPlayers.Size = new System.Drawing.Size(200, 290);
            listBoxPlayers.SelectedIndexChanged += listBoxPlayers_SelectedIndexChanged;

            // panelCard
            panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCard.Location = new System.Drawing.Point(230, 12);
            panelCard.Size = new System.Drawing.Size(260, 500);
            panelCard.Controls.Add(pictureBoxPhoto);
            panelCard.Controls.Add(labelName);
            panelCard.Controls.Add(labelTeam);
            panelCard.Controls.Add(labelPosition);
            panelCard.Controls.Add(labelGoals);
            panelCard.Controls.Add(labelAssists);
            panelCard.Controls.Add(labelAppearances);

            // pictureBoxPhoto
            pictureBoxPhoto.Location = new System.Drawing.Point(5, 5);
            pictureBoxPhoto.Size = new System.Drawing.Size(250, 300);
            pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // Labels
            labelName.Location = new System.Drawing.Point(5, 310);
            labelName.Size = new System.Drawing.Size(250, 23);
            labelTeam.Location = new System.Drawing.Point(5, 330);
            labelTeam.Size = new System.Drawing.Size(250, 23);
            labelPosition.Location = new System.Drawing.Point(5, 350);
            labelPosition.Size = new System.Drawing.Size(250, 23);
            labelGoals.Location = new System.Drawing.Point(5, 370);
            labelGoals.Size = new System.Drawing.Size(250, 23);
            labelAssists.Location = new System.Drawing.Point(5, 390);
            labelAssists.Size = new System.Drawing.Size(250, 23);
            labelAppearances.Location = new System.Drawing.Point(5, 410);
            labelAppearances.Size = new System.Drawing.Size(250, 23);

            // Add controls to form
            Controls.Add(textBoxSearch);
            Controls.Add(listBoxPlayers);
            Controls.Add(panelCard);
            ClientSize = new System.Drawing.Size(500, 530);
            Name = "Form1";
            Text = "Trading Cards";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
