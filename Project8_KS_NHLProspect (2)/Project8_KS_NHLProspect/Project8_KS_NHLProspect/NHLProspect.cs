using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8_KS_NHLProspect
{
    public partial class NHLProspect : Form
    {
        List<string> playerList = new List<string> {"Connor McDavid",
"Jack Eichel",
"Noah Hanifin",
"Oliver Kylington",
"Pavel Zacha",
"Mitch Marner",
"Dylan Strome",
"Jeremy Roy",
"Yevgeni Svechnikov",
"Mathew Barzal",
"Travis Konecny",
"Colin White",
"Nick Merkley",
"Paul Bittner",
"Lawson Crouse",
"Mikko Rantanen",
"Daniel Sprong",
"Cameron Hughes",
"Thomas Novak",
"Kyle Connor",
"Nikita Korostelev",
"Jansen Harkins",
"Ivan Provorov",
"MacKenzie Blackwood",
"Matej Tomek",
"Nicolas Meloche",
"Jakub Zboril",
"Jesper Lindgren",
"Zack Werenski",
"Jordan Greenway"};
        List<decimal> salaryCapList = new List<decimal> { 63770043, 58777490, 67265904, 577722423, 55830628, 66090860, 69123383, 69571446, 63340718, 68453884, 64013662, 65819189, 63350895, 68938399, 62044507, 67517616, 63818328, 68556683, 59408111, 63904973, 56193701, 75063516, 71485152, 64101568, 67544796, 68664473, 67963607, 67436419, 70124971, 61647413 };
        public NHLProspect()
        {
            InitializeComponent();
        }

        private void teamLogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //define index(posi) selected from combox
            int index = teamComboBox.SelectedIndex;
            //if index >= 0 the user has selected a city
            if (index >= 0)
            {
                //hide the error label
                nHLTeamErrorLabel.Hide();
                //display the team's pic
                teamLogoPictureBox.Image = teamLogoImageList.Images[index];
            }
            else
            {
                //blank out the picturebox
                teamLogoPictureBox.Image = null;
            }
        }

        private void NHLProspect_Load(object sender, EventArgs e)
        {
            //projectionListBox.Hide();
            hideTopDraftsButton.Hide();
            //showTopDraftsButton.Show();
            showTopDraftsButton.Hide();
            nHLTeamErrorLabel.Hide();
            draftErrorLabel.Hide();
            topPlayer1Label.Text = "Connor McDavid";
            topPlayer2Label.Text = "Jack Eichel";
            topPlayer3Label.Text = "Noah Hanifin";
            StreamReader draftPicksList = File.OpenText("draftPicks.txt");
                while(!draftPicksList.EndOfStream)
                {
                    string draftPick=draftPicksList.ReadLine();
                    playersComboBox.Items.Add(draftPick);
                }
        }

        private void draftButton_Click(object sender, EventArgs e)
        {
            int team = teamComboBox.SelectedIndex;
            string teams = teamComboBox.Text;
            int player = playersComboBox.SelectedIndex;
            string pick = playersComboBox.Text;
            //string draft = playersComboBox.SelectedIndex;

            if (team <0)
            {
                nHLTeamErrorLabel.Show();
                return;
            }
            if (player <0)
            {
                draftErrorLabel.Show();
                return;
            }

            //if (string.IsNullOrWhiteSpace(pickTextBox.Text))
            //{
            //    MessageBox.Show("Lock-in your player pick for the 2014 NHL Entry Draft", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand); 
            //}
                
           
            projectionListBox.Items.Add(player +1);

            decimal salaryCap = salaryCapList[team];
            salaryCapLabel.Text = salaryCap.ToString("C");

            //string guess = islandNameTextBox.Text;
            
            draftsListBox.Items.Add(pick);
            draftedTeamListBox.Items.Add(teams);

            //islandNameTextBox.Focus();
            //islandNameTextBox.SelectAll();

            //draftsListBox.Items.Add(playersComboBox.SelectedIndex);
            //draftsListBox
            //costListBox.Items.Add(costTextBox.Text);
            //foreach (var item in collection)
            //{
                
            //}
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //define index(posi) selected from combox
            int index = playersComboBox.SelectedIndex;
            //if index >= 0 the user has selected a city
            if (index >= 0)
            {
                //hide the error label
                draftErrorLabel.Hide();
                //display the team's pic
                playerPictureBox.Image = playerImageList.Images[index];
            }
            else
            {
                //blank out the picturebox
                playerPictureBox.Image = null;
            }
        }

        private void hideTopDraftsButton_Click(object sender, EventArgs e)
        {
            //projectionListBox.Hide();
            //hideTopDraftsButton.Hide();
        }

        private void showTopDraftsButton_Click(object sender, EventArgs e)
        {
            //projectionListBox.Show();
            //hideTopDraftsButton.Show();
            //showTopDraftsButton.Show();
        }

        private void redraftButton_Click(object sender, EventArgs e)
        {
            playersComboBox.SelectedIndex = -1;
            teamComboBox.SelectedIndex = -1;
            playerPictureBox.Image = null;
            teamLogoPictureBox.Image = null;
            salaryCapLabel.Text = "";
            projectionListBox.Items.Clear();
            //pickTextBox.Clear();
            draftsListBox.Items.Clear();
            //teamsListBox.Items.Clear();
            draftedTeamListBox.Items.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
