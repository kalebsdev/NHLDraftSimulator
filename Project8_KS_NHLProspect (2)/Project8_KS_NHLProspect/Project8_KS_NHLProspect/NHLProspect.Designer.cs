namespace Project8_KS_NHLProspect
{
    partial class NHLProspect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHLProspect));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.playersComboBox = new System.Windows.Forms.ComboBox();
            this.teamLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.projectionListBox = new System.Windows.Forms.ListBox();
            this.salaryCapLabel = new System.Windows.Forms.Label();
            this.topPlayer1Label = new System.Windows.Forms.Label();
            this.topPlayer2Label = new System.Windows.Forms.Label();
            this.topPlayer3Label = new System.Windows.Forms.Label();
            this.teamLogoImageList = new System.Windows.Forms.ImageList(this.components);
            this.draftButton = new System.Windows.Forms.Button();
            this.redraftButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nHLTeamErrorLabel = new System.Windows.Forms.Label();
            this.draftErrorLabel = new System.Windows.Forms.Label();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.playerImageList = new System.Windows.Forms.ImageList(this.components);
            this.showTopDraftsButton = new System.Windows.Forms.Button();
            this.hideTopDraftsButton = new System.Windows.Forms.Button();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.draftsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.draftedTeamListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picknumberListBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamLogoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Items.AddRange(new object[] {
            "Anaheim Ducks",
            "Arizona Coyotes",
            "Boston Bruins",
            "Buffalo Sabres",
            "Calgary Flames",
            "Carolina Hurricanes",
            "Chicago Blackhawks",
            "Colorado Avelanche",
            "Columbus Blue Jackets",
            "Dallas Stars",
            "Detroit Red Wings",
            "Edmonton Oilers",
            "Florida Panthers",
            "Los Angeles Kings",
            "Minnesota Wild",
            "Montreal Canadiens",
            "Nashville Predators",
            "New Jersey Devils",
            "New York Islanders",
            "New York Rangers",
            "Ottawa Senators",
            "Philadelphia Flyers",
            "San Jose Sharks",
            "St. Louis Blues",
            "Tampa Bay Lightning",
            "Toronto Maple Leafs",
            "Vancouver Canucks",
            "Washington Capitals",
            "Winnipeg Jets"});
            this.teamComboBox.Location = new System.Drawing.Point(25, 34);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(121, 21);
            this.teamComboBox.TabIndex = 0;
            this.teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // playersComboBox
            // 
            this.playersComboBox.FormattingEnabled = true;
            this.playersComboBox.Items.AddRange(new object[] {
            "Connor McDavid",
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
            "Jordan Greenway"});
            this.playersComboBox.Location = new System.Drawing.Point(25, 214);
            this.playersComboBox.Name = "playersComboBox";
            this.playersComboBox.Size = new System.Drawing.Size(121, 21);
            this.playersComboBox.TabIndex = 1;
            this.playersComboBox.SelectedIndexChanged += new System.EventHandler(this.playersComboBox_SelectedIndexChanged);
            // 
            // teamLogoPictureBox
            // 
            this.teamLogoPictureBox.Location = new System.Drawing.Point(152, 15);
            this.teamLogoPictureBox.Name = "teamLogoPictureBox";
            this.teamLogoPictureBox.Size = new System.Drawing.Size(198, 161);
            this.teamLogoPictureBox.TabIndex = 2;
            this.teamLogoPictureBox.TabStop = false;
            this.teamLogoPictureBox.Click += new System.EventHandler(this.teamLogoPictureBox_Click);
            // 
            // projectionListBox
            // 
            this.projectionListBox.FormattingEnabled = true;
            this.projectionListBox.Location = new System.Drawing.Point(458, 61);
            this.projectionListBox.Name = "projectionListBox";
            this.projectionListBox.Size = new System.Drawing.Size(56, 394);
            this.projectionListBox.TabIndex = 3;
            // 
            // salaryCapLabel
            // 
            this.salaryCapLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salaryCapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryCapLabel.Location = new System.Drawing.Point(381, 208);
            this.salaryCapLabel.Name = "salaryCapLabel";
            this.salaryCapLabel.Size = new System.Drawing.Size(137, 27);
            this.salaryCapLabel.TabIndex = 4;
            this.salaryCapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPlayer1Label
            // 
            this.topPlayer1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topPlayer1Label.Location = new System.Drawing.Point(25, 27);
            this.topPlayer1Label.Name = "topPlayer1Label";
            this.topPlayer1Label.Size = new System.Drawing.Size(120, 22);
            this.topPlayer1Label.TabIndex = 5;
            // 
            // topPlayer2Label
            // 
            this.topPlayer2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topPlayer2Label.Location = new System.Drawing.Point(25, 60);
            this.topPlayer2Label.Name = "topPlayer2Label";
            this.topPlayer2Label.Size = new System.Drawing.Size(120, 22);
            this.topPlayer2Label.TabIndex = 6;
            // 
            // topPlayer3Label
            // 
            this.topPlayer3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topPlayer3Label.Location = new System.Drawing.Point(25, 97);
            this.topPlayer3Label.Name = "topPlayer3Label";
            this.topPlayer3Label.Size = new System.Drawing.Size(120, 22);
            this.topPlayer3Label.TabIndex = 7;
            // 
            // teamLogoImageList
            // 
            this.teamLogoImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("teamLogoImageList.ImageStream")));
            this.teamLogoImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.teamLogoImageList.Images.SetKeyName(0, "Anaheim_Ducks.png");
            this.teamLogoImageList.Images.SetKeyName(1, "Arizona_Coyotes.png");
            this.teamLogoImageList.Images.SetKeyName(2, "boston bruins.png");
            this.teamLogoImageList.Images.SetKeyName(3, "Buffalo_Sabres.png");
            this.teamLogoImageList.Images.SetKeyName(4, "Calgary_Flames.png");
            this.teamLogoImageList.Images.SetKeyName(5, "Carolina_Hurricanes.png");
            this.teamLogoImageList.Images.SetKeyName(6, "Chicago Blackhawks.png");
            this.teamLogoImageList.Images.SetKeyName(7, "Colorado_Avalanche.png");
            this.teamLogoImageList.Images.SetKeyName(8, "Columbus_BlueJackets.png");
            this.teamLogoImageList.Images.SetKeyName(9, "Dallas_Stars.png");
            this.teamLogoImageList.Images.SetKeyName(10, "Detroit_Red_Wings.png");
            this.teamLogoImageList.Images.SetKeyName(11, "Edmonton Oilers.PNG");
            this.teamLogoImageList.Images.SetKeyName(12, "Florida_Panthers.png");
            this.teamLogoImageList.Images.SetKeyName(13, "Los_Angeles_Kings.png");
            this.teamLogoImageList.Images.SetKeyName(14, "Minnesota_Wild.png");
            this.teamLogoImageList.Images.SetKeyName(15, "Montreal_Canadiens.png");
            this.teamLogoImageList.Images.SetKeyName(16, "Nashville_Predators.png");
            this.teamLogoImageList.Images.SetKeyName(17, "New_Jersey_Devils.png");
            this.teamLogoImageList.Images.SetKeyName(18, "New_York_Islanders.png");
            this.teamLogoImageList.Images.SetKeyName(19, "New_York_Rangers.png");
            this.teamLogoImageList.Images.SetKeyName(20, "Ottawa_Senators.png");
            this.teamLogoImageList.Images.SetKeyName(21, "Philadelphia_Flyers.png");
            this.teamLogoImageList.Images.SetKeyName(22, "SanJoseSharks.png");
            this.teamLogoImageList.Images.SetKeyName(23, "StLouis_Blues.png");
            this.teamLogoImageList.Images.SetKeyName(24, "Tampa_Bay_Lightning.png");
            this.teamLogoImageList.Images.SetKeyName(25, "Toronto_Maple_Leafs.png");
            this.teamLogoImageList.Images.SetKeyName(26, "Vancouver_Canucks.png");
            this.teamLogoImageList.Images.SetKeyName(27, "Washington_Capitals.png");
            this.teamLogoImageList.Images.SetKeyName(28, "Winnipeg_Jets.png");
            // 
            // draftButton
            // 
            this.draftButton.Location = new System.Drawing.Point(40, 708);
            this.draftButton.Name = "draftButton";
            this.draftButton.Size = new System.Drawing.Size(119, 25);
            this.draftButton.TabIndex = 2;
            this.draftButton.Text = "&Draft";
            this.draftButton.UseVisualStyleBackColor = true;
            this.draftButton.Click += new System.EventHandler(this.draftButton_Click);
            // 
            // redraftButton
            // 
            this.redraftButton.Location = new System.Drawing.Point(165, 708);
            this.redraftButton.Name = "redraftButton";
            this.redraftButton.Size = new System.Drawing.Size(119, 25);
            this.redraftButton.TabIndex = 3;
            this.redraftButton.Text = "&ReDraft";
            this.redraftButton.UseVisualStyleBackColor = true;
            this.redraftButton.Click += new System.EventHandler(this.redraftButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(290, 708);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(119, 25);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Salary Cap:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.topPlayer3Label);
            this.groupBox1.Controls.Add(this.topPlayer2Label);
            this.groupBox1.Controls.Add(this.topPlayer1Label);
            this.groupBox1.Location = new System.Drawing.Point(24, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 139);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top Draft Picks:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "2";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "NHL Team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Draft Prospects:";
            // 
            // nHLTeamErrorLabel
            // 
            this.nHLTeamErrorLabel.AutoSize = true;
            this.nHLTeamErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nHLTeamErrorLabel.Location = new System.Drawing.Point(22, 58);
            this.nHLTeamErrorLabel.Name = "nHLTeamErrorLabel";
            this.nHLTeamErrorLabel.Size = new System.Drawing.Size(111, 13);
            this.nHLTeamErrorLabel.TabIndex = 17;
            this.nHLTeamErrorLabel.Text = "Select your NHL team";
            // 
            // draftErrorLabel
            // 
            this.draftErrorLabel.AutoSize = true;
            this.draftErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.draftErrorLabel.Location = new System.Drawing.Point(22, 238);
            this.draftErrorLabel.Name = "draftErrorLabel";
            this.draftErrorLabel.Size = new System.Drawing.Size(111, 13);
            this.draftErrorLabel.TabIndex = 18;
            this.draftErrorLabel.Text = "Draft a first round pick";
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Location = new System.Drawing.Point(152, 192);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(198, 161);
            this.playerPictureBox.TabIndex = 19;
            this.playerPictureBox.TabStop = false;
            // 
            // playerImageList
            // 
            this.playerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playerImageList.ImageStream")));
            this.playerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.playerImageList.Images.SetKeyName(0, "aMcDavid.Connor.jpg");
            this.playerImageList.Images.SetKeyName(1, "bEichel_medium.jpg");
            this.playerImageList.Images.SetKeyName(2, "cHanifin_medium.jpg");
            this.playerImageList.Images.SetKeyName(3, "doliver_kylington_farjestad.jpg");
            this.playerImageList.Images.SetKeyName(4, "epavel_zacha_sarnia.jpg");
            this.playerImageList.Images.SetKeyName(5, "fMitch Marner.jpg");
            this.playerImageList.Images.SetKeyName(6, "gStrome.Dylan_.jpg");
            this.playerImageList.Images.SetKeyName(7, "hJeremyRoy.jpg");
            this.playerImageList.Images.SetKeyName(8, "isvechnikov.jpg");
            this.playerImageList.Images.SetKeyName(9, "jmathewbarzal-e1378246583631.jpg");
            this.playerImageList.Images.SetKeyName(10, "ktravis.jpg");
            this.playerImageList.Images.SetKeyName(11, "lWhite_Colin_medium.jpg");
            this.playerImageList.Images.SetKeyName(12, "mNick Merkley.jpg");
            this.playerImageList.Images.SetKeyName(13, "nBittner_medium.jpg");
            this.playerImageList.Images.SetKeyName(14, "olawson_crouse_kingstron.jpg");
            this.playerImageList.Images.SetKeyName(15, "pMikkoRantanen.jpg");
            this.playerImageList.Images.SetKeyName(16, "qDanielSprong.jpg");
            this.playerImageList.Images.SetKeyName(17, "rHughes_Cameron_20135506.jpg");
            this.playerImageList.Images.SetKeyName(18, "sNovak_medium.jpg");
            this.playerImageList.Images.SetKeyName(19, "tConnor_medium.jpg");
            this.playerImageList.Images.SetKeyName(20, "uNikitaKorostelev.jpg");
            this.playerImageList.Images.SetKeyName(21, "vJansenHarkins.jpg");
            this.playerImageList.Images.SetKeyName(22, "wIvanProvorov.jpg");
            this.playerImageList.Images.SetKeyName(23, "xMacKenzieBlackwood.jpg");
            this.playerImageList.Images.SetKeyName(24, "yMatejTomek.jpg");
            this.playerImageList.Images.SetKeyName(25, "znicolas-meloche.jpg");
            this.playerImageList.Images.SetKeyName(26, "zzboril_jakub_karta01.jpg");
            this.playerImageList.Images.SetKeyName(27, "zzJesperLindgren.jpg");
            this.playerImageList.Images.SetKeyName(28, "zzWerenski_medium.jpg");
            this.playerImageList.Images.SetKeyName(29, "zzzGreenway_medium.jpg");
            // 
            // showTopDraftsButton
            // 
            this.showTopDraftsButton.Location = new System.Drawing.Point(459, 739);
            this.showTopDraftsButton.Name = "showTopDraftsButton";
            this.showTopDraftsButton.Size = new System.Drawing.Size(123, 29);
            this.showTopDraftsButton.TabIndex = 20;
            this.showTopDraftsButton.Text = "&Show Top Drafts";
            this.showTopDraftsButton.UseVisualStyleBackColor = true;
            this.showTopDraftsButton.Click += new System.EventHandler(this.showTopDraftsButton_Click);
            // 
            // hideTopDraftsButton
            // 
            this.hideTopDraftsButton.Location = new System.Drawing.Point(459, 739);
            this.hideTopDraftsButton.Name = "hideTopDraftsButton";
            this.hideTopDraftsButton.Size = new System.Drawing.Size(123, 29);
            this.hideTopDraftsButton.TabIndex = 21;
            this.hideTopDraftsButton.Text = "&Hide Top Drafts";
            this.hideTopDraftsButton.UseVisualStyleBackColor = true;
            this.hideTopDraftsButton.Click += new System.EventHandler(this.hideTopDraftsButton_Click);
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.Items.AddRange(new object[] {
            "Columbus",
            "Edmonton",
            "Carolina",
            "Buffalo",
            "Philadelphia",
            "New Jersey",
            "Colorado",
            "Arizona",
            "Dallas",
            "Ottawa",
            "Washington",
            "Florida",
            "San Jose",
            "Tampa Bay ",
            "Minnesota",
            "Toronto",
            "Winnipeg",
            "Los Angeles",
            "Boston",
            "Chicago",
            "Calgary",
            "Detroit",
            "Anaheim",
            "Vancouver",
            "Buffalo",
            "Pittsburgh",
            "Buffalo",
            "Nashville",
            "Montreal",
            "Tampa Bay"});
            this.teamsListBox.Location = new System.Drawing.Point(9, 61);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(123, 394);
            this.teamsListBox.TabIndex = 22;
            // 
            // draftsListBox
            // 
            this.draftsListBox.FormattingEnabled = true;
            this.draftsListBox.Location = new System.Drawing.Point(329, 61);
            this.draftsListBox.Name = "draftsListBox";
            this.draftsListBox.Size = new System.Drawing.Size(123, 394);
            this.draftsListBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Team Draft Order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Drafts Picks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Draft Projection";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 29;
            // 
            // draftedTeamListBox
            // 
            this.draftedTeamListBox.FormattingEnabled = true;
            this.draftedTeamListBox.Location = new System.Drawing.Point(200, 61);
            this.draftedTeamListBox.Name = "draftedTeamListBox";
            this.draftedTeamListBox.Size = new System.Drawing.Size(123, 394);
            this.draftedTeamListBox.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Drafted Team";
            // 
            // picknumberListBox
            // 
            this.picknumberListBox.FormattingEnabled = true;
            this.picknumberListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.picknumberListBox.Location = new System.Drawing.Point(138, 61);
            this.picknumberListBox.Name = "picknumberListBox";
            this.picknumberListBox.Size = new System.Drawing.Size(56, 394);
            this.picknumberListBox.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Pick No.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Height:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(193, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 133);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Summary:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 498);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(384, 180);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.teamsListBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.draftedTeamListBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.picknumberListBox);
            this.groupBox3.Controls.Add(this.draftsListBox);
            this.groupBox3.Controls.Add(this.projectionListBox);
            this.groupBox3.Location = new System.Drawing.Point(437, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 471);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2014 Draft Results";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(381, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 161);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Weight:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Position:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Origin:";
            // 
            // NHLProspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 768);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hideTopDraftsButton);
            this.Controls.Add(this.showTopDraftsButton);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.draftErrorLabel);
            this.Controls.Add(this.nHLTeamErrorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.redraftButton);
            this.Controls.Add(this.draftButton);
            this.Controls.Add(this.salaryCapLabel);
            this.Controls.Add(this.teamLogoPictureBox);
            this.Controls.Add(this.playersComboBox);
            this.Controls.Add(this.teamComboBox);
            this.Name = "NHLProspect";
            this.Text = "NHLProspect";
            this.Load += new System.EventHandler(this.NHLProspect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamLogoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.ComboBox playersComboBox;
        private System.Windows.Forms.PictureBox teamLogoPictureBox;
        private System.Windows.Forms.ListBox projectionListBox;
        private System.Windows.Forms.Label salaryCapLabel;
        private System.Windows.Forms.Label topPlayer1Label;
        private System.Windows.Forms.Label topPlayer2Label;
        private System.Windows.Forms.Label topPlayer3Label;
        private System.Windows.Forms.ImageList teamLogoImageList;
        private System.Windows.Forms.Button draftButton;
        private System.Windows.Forms.Button redraftButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nHLTeamErrorLabel;
        private System.Windows.Forms.Label draftErrorLabel;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.ImageList playerImageList;
        private System.Windows.Forms.Button showTopDraftsButton;
        private System.Windows.Forms.Button hideTopDraftsButton;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.ListBox draftsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox draftedTeamListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox picknumberListBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

